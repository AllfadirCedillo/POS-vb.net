Imports System.Data.SqlClient

Public Class agregarUsuario
    Dim con As New SqlConnection(My.Settings.POSConnectionString)
    Dim cmd As New SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        cmd = New SqlCommand("add_user", con)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@nombre", NombreTextBox.Text)
        cmd.Parameters.AddWithValue("@apellido", ApellidoTextBox.Text)
        cmd.Parameters.AddWithValue("@turno", TurnoTextBox.Text)
        cmd.Parameters.AddWithValue("@admin", AdministradorCheckBox)
        cmd.Parameters.AddWithValue("@pass", PassTextBox.Text)
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Usuario agregado correctamente", "Agregando Usuario")
            NombreTextBox.Text = ""
            ApellidoTextBox.Text = ""
            TurnoTextBox.Text = ""
            AdministradorCheckBox.Checked = False
            PassTextBox.Text = ""
        Else
            MessageBox.Show("No se pudo agregar el usuario", "Agregando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NombreTextBox.Text = ""
            ApellidoTextBox.Text = ""
            TurnoTextBox.Text = ""
            AdministradorCheckBox.Checked = False
            PassTextBox.Text = ""
        End If
        con.Close()
    End Sub
End Class