Imports System.Data.SqlClient

Public Class eliminarUsuario
    Dim con As New SqlConnection(My.Settings.POSConnectionString)
    Dim cmd As New SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        cmd = New SqlCommand("baja_usuario", con)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@nombre", TextBox1.Text)
        cmd.Parameters.AddWithValue("@apellido", TextBox2.Text)
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Usuario eliminado correctamente", "Eliminando Usuario")
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            MessageBox.Show("Usuario no encontrado", "Eliminando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        AdministrarUsuario.Show()
    End Sub
End Class