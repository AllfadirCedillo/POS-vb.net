Imports System.Data.SqlClient

Public Class modificarUsuario
    Dim con As New SqlConnection(My.Settings.POSConnectionString)
    Dim cmd As New SqlCommand
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.POSDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'POSDataSet.no_admin' Puede moverla o quitarla según sea necesario.
        Me.No_adminTableAdapter.Fill(Me.POSDataSet.no_admin)
        'TODO: esta línea de código carga datos en la tabla 'POSDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.POSDataSet.usuarios)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        AdministrarUsuario.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        cmd = New SqlCommand("modif_usuario", con)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@nombre", No_adminComboBox.Text)
        cmd.Parameters.AddWithValue("@col", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@dato", TextBox1.Text)
        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Usuario modificado correctamente", "Modificando Usuario")
            TextBox1.Text = ""
        Else
            MessageBox.Show("No se pudo modificar el usuario", "Modificando Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Text = ""
        End If
        con.Close()
    End Sub
End Class