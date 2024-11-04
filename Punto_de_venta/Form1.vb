Imports System.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection(My.Settings.POSConnectionString)
    Dim cmd As New SqlCommand
    Public noVent As Integer
    Public Sub NuevaVenta()
        con.Open()
        cmd = New SqlCommand("new_sell", con)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@corte", bienvenido.IdCor)
        cmd.ExecuteNonQuery()
        con.Close()
        NumeroVenta()
    End Sub
    Private Sub NumeroVenta()
        con.Open()
        cmd = New SqlCommand("select top 1 no_venta from ventas order by no_venta desc", con)

        noVent = cmd.ExecuteScalar()
        con.Close()
    End Sub
    Private Sub ComplementosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplementosToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        cmd = New SqlCommand("new_detail", con)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@venta", noVent)
        cmd.Parameters.AddWithValue("@producto", PastesComboBox.SelectedIndex + 1)
        cmd.Parameters.AddWithValue("@cantidad", CInt(NumericUpDown1.Value))
        cmd.Parameters.AddWithValue("@precio", CInt(NumericUpDown1.Value) * 23)
        If cmd.ExecuteNonQuery() Then
            PastesComboBox.Text = ""
            NumericUpDown1.Value = 0
        Else
            MessageBox.Show("No se pudo añadir la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PastesComboBox.Text = ""
            NumericUpDown1.Value = 0
        End If
        con.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'POSDataSet.pastes' Puede moverla o quitarla según sea necesario.
        Me.PastesTableAdapter.Fill(Me.POSDataSet.pastes)
        NuevaVenta()
    End Sub
End Class
