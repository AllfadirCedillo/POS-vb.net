Imports System.Data.SqlClient

Public Class Form3
    Dim con As New SqlConnection(My.Settings.POSConnectionString)
    Dim cmd As New SqlCommand
    Public Datos(5) As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Datos(0) = TextBox1.Text
        Datos(1) = TextBox5.Text
        Datos(2) = TextBox2.Text
        Datos(3) = TextBox3.Text
        Datos(4) = TextBox4.Text
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" Then
            Me.Hide()
            ticket.Show()
        Else
            con.Open()
            cmd = New SqlCommand("new_client", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@nombre", TextBox1.Text)
            cmd.Parameters.AddWithValue("@apellido", TextBox5.Text)
            cmd.Parameters.AddWithValue("@direccion", TextBox2.Text)
            cmd.Parameters.AddWithValue("@rfc", TextBox4.Text)
            cmd.Parameters.AddWithValue("@telefono", Convert.ToInt32(TextBox3.Text))
            If cmd.ExecuteNonQuery() Then
                Me.Hide()
                ticket.Show()
            Else
                MessageBox.Show("No pudo almacenarce el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
            End If
            con.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

End Class