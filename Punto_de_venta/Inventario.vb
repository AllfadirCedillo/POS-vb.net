Imports System.Data.SqlClient

Public Class Inventario
    Dim con As New SqlConnection(My.Settings.POSConnectionString)
    Dim cmd As New SqlCommand
    Dim res As Integer
    Private Sub Existencias()
        con.Open()
        cmd = New SqlCommand("select existencias from productos where nombre = @nom", con)
        If ComboBox1.Text = "Pastes" Then
            cmd.Parameters.AddWithValue("@nom", PastesComboBox.Text)
        End If
        If ComboBox1.Text = "Complementos" Then
            cmd.Parameters.AddWithValue("@nom", ComplementosComboBox.Text)
        End If
        res = cmd.ExecuteScalar
        con.Close()
    End Sub
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'POSDataSet.complementos' Puede moverla o quitarla según sea necesario.
        Me.ComplementosTableAdapter.Fill(Me.POSDataSet.complementos)
        'TODO: esta línea de código carga datos en la tabla 'POSDataSet.pastes' Puede moverla o quitarla según sea necesario.
        Me.PastesTableAdapter.Fill(Me.POSDataSet.pastes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        AdministrarUsuario.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Existencias()

        con.Open()
        cmd = New SqlCommand("mod_prod", con)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cant", res + NumericUpDown1.Value)
        If ComboBox1.Text = "Pastes" Then
            cmd.Parameters.AddWithValue("@nom", PastesComboBox.Text)
        End If
        If ComboBox1.Text = "Complementos" Then
            cmd.Parameters.AddWithValue("@nom", ComplementosComboBox.Text)
        End If

        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Existencias modificadas correctamente", "Modificando existencias")
            ComboBox1.Text = ""
            If ComboBox1.Text = "Pastes" Then
                PastesComboBox.Text = ""
            End If
            If ComboBox1.Text = "Complementos" Then
                ComplementosComboBox.Text = ""
            End If
        Else
            MessageBox.Show("No se pudo modificar la existencia", "Modificando existencias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBox1.Text = ""
            PastesComboBox.Text = ""
            ComplementosComboBox.Text = ""
        End If
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Pastes" Then
            PastesComboBox.Visible = True
            ComplementosComboBox.Visible = False
        End If
        If ComboBox1.Text = "Complementos" Then
            PastesComboBox.Visible = False
            ComplementosComboBox.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Existencias()

        con.Open()
        cmd = New SqlCommand("mod_prod", con)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cant", res - NumericUpDown1.Value)
        If ComboBox1.Text = "Pastes" Then
            cmd.Parameters.AddWithValue("@nom", PastesComboBox.Text)
        End If
        If ComboBox1.Text = "Complementos" Then
            cmd.Parameters.AddWithValue("@nom", ComplementosComboBox.Text)
        End If

        If cmd.ExecuteNonQuery() Then
            MessageBox.Show("Existencias modificadas correctamente", "Modificando existencias")
            ComboBox1.Text = ""
            If ComboBox1.Text = "Pastes" Then
                PastesComboBox.Text = ""
            End If
            If ComboBox1.Text = "Complementos" Then
                ComplementosComboBox.Text = ""
            End If
        Else
            MessageBox.Show("No se pudo modificar la existencia", "Modificando existencias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBox1.Text = ""
            PastesComboBox.Text = ""
            ComplementosComboBox.Text = ""
        End If
        con.Close()
    End Sub
End Class