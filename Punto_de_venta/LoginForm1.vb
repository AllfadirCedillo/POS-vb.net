Imports System.Data.SqlClient

Public Class LoginForm1
    Public nombre As String
    Dim con As New SqlConnection(My.Settings.POSConnectionString)
    Dim cmd As New SqlCommand


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim dr As SqlDataReader
        con.Open()
        cmd = New SqlCommand("acceso", con)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@nom_user", UsernameTextBox.Text)
        cmd.Parameters.AddWithValue("@pass", PasswordTextBox.Text)
        dr = cmd.ExecuteReader
        If dr.Read Then
            nombre = UsernameTextBox.Text
            Me.Hide()
            bienvenido.Show()
        Else
            MessageBox.Show("Usuario no encontrado", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UsernameTextBox.Focus()
        End If
        con.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As Byte
        con.Open()
        cmd = New SqlCommand("administrador", con)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@nom_admin", UsernameTextBox.Text)
        cmd.Parameters.AddWithValue("@pass", PasswordTextBox.Text)
        res = cmd.ExecuteScalar
        If res Then
            Me.Hide()
            AdministrarUsuario.Show()
        Else
            MessageBox.Show("Usuario no encontrado o no cuenta con caracteristicas de administrador", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UsernameTextBox.Focus()
        End If
        con.Close()
    End Sub
End Class
