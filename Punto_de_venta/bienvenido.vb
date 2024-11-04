Imports System.Data.SqlClient

Public Class bienvenido
    Dim con As New SqlConnection(My.Settings.POSConnectionString)
    Dim cmd As New SqlCommand
    Public IdVen As Integer
    Public IdCor As Integer
    Private Sub Vendedor()
        con.Open()
        cmd = New SqlCommand("select id_user from usuarios where nombre = @nom", con)
        cmd.Parameters.AddWithValue("@nom", LoginForm1.nombre)
        IdVen = cmd.ExecuteScalar
        con.Close()
    End Sub
    Private Function TurnoIniciado()
        Dim Iniciado As Boolean
        Vendedor()
        con.Open()
        cmd = New SqlCommand("select * from cortes where vendedor = @user and fecha = @date", con)
        cmd.Parameters.AddWithValue("@user", IdVen)
        cmd.Parameters.AddWithValue("@date", CDate(DateTime.Now.ToShortDateString))
        Iniciado = cmd.ExecuteScalar
        con.Close()
        Return Iniciado
    End Function
    Private Sub IdCorte()
        Vendedor()
        con.Open()
        cmd = New SqlCommand("select id_corte from cortes where vendedor = @user and fecha = @date", con)
        cmd.Parameters.AddWithValue("@user", IdVen)
        cmd.Parameters.AddWithValue("@date", CDate(DateTime.Now.ToShortDateString))
        IdCor = cmd.ExecuteScalar
        con.Close()
    End Sub
    Private Sub bienvenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Label1.Text + " " + LoginForm1.nombre
        Label2.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TurnoIniciado() Then
            MessageBox.Show("Ya existia una sesion con este usuario", "Sesion ya existente")
            IdCorte()
            Me.Hide()
            Form1.Show()
        Else
            con.Open()
            cmd = New SqlCommand("new_cut", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@date", CDate(DateTime.Now.ToShortDateString))
            cmd.Parameters.AddWithValue("@vendedor", IdVen)
            If cmd.ExecuteNonQuery() Then
                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        IdCorte()
    End Sub
End Class