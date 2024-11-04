Imports System.Data.SqlClient

Public Class Form2
    Dim con As New SqlConnection(My.Settings.POSConnectionString)
    Dim cmd As New SqlCommand
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.Text = "Boing") Then
            PictureBox1.Image = My.Resources.Boing
        End If
        If (ComboBox1.Text = "Bolis") Then
            PictureBox1.Image = My.Resources.Bolis
        End If
        If (ComboBox1.Text = "Café") Then
            PictureBox1.Image = My.Resources.Café
        End If
        If (ComboBox1.Text = "Coca-cola") Then
            PictureBox1.Image = My.Resources.Coca_cola
        End If
        If (ComboBox1.Text = "Malteada") Then
            PictureBox1.Image = My.Resources.Malteadas
        End If
        If (ComboBox1.Text = "Té") Then
            PictureBox1.Image = My.Resources.Té
        End If
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim precio As Integer
        con.Open()
        cmd = New SqlCommand("new_detail", con)
        cmd.CommandType = CommandType.StoredProcedure

        Dim cmd2 As New SqlCommand("select precio from productos where nombre = @nombre", con)
        cmd2.Parameters.AddWithValue("@nombre", ComboBox1.Text)
        precio = cmd2.ExecuteScalar

        cmd.Parameters.AddWithValue("@venta", Form1.noVent)
        cmd.Parameters.AddWithValue("@producto", ComboBox1.SelectedIndex + 20)
        cmd.Parameters.AddWithValue("@cantidad", NumericUpDown1.Value)
        cmd.Parameters.AddWithValue("@precio", NumericUpDown1.Value * precio)
        If cmd.ExecuteNonQuery() Then
            ComboBox1.Text = ""
            NumericUpDown1.Value = 0
        Else
            MessageBox.Show("No se pudo añadir la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBox1.Text = ""
            NumericUpDown1.Value = 0
        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class