Public Class ticket

    Dim sabores() As String = {"Zarzamora", "Fresa", "Piña", "Durazno", "Crema pastelera", "Cajeta", "Arroz con leche", "Manzana canela", "Chocolate", "Salchicha", "Champiñones", "Hawaiano", "Jamon con queso", "3 quesos", "Mole con pollo", "Papa con carne", "Choriqueso", "Tinga", "Atún", "Chicharron"}
    Dim Nom_complementos() As String = {"Boing", "Bolis", "Café", "Coca-cola", "Malteadas", "Té"}
    Dim Total As Integer = 0

    Private Sub ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox6.Text = TextBox6.Text + Form3.Datos(0) + " " + Form3.Datos(1)
        TextBox7.Text = TextBox7.Text + Form3.Datos(2)
        TextBox8.Text = TextBox8.Text + Form3.Datos(3)
        TextBox9.Text = TextBox9.Text + Form3.Datos(4)

        TextBox12.Text = TextBox12.Text + Form1.noVent
        TextBox14.Text = TextBox14.Text + DateString
        TextBox15.Text = TextBox15.Text + LoginForm1.nombre

        TextBox19.Text = TextBox19.Text + "Total"
        TextBox20.Text = TextBox20.Text + "$" + Str(Total)

        TextBox18.Height = TextBox18.Font.Height * (TextBox18.Lines.Count + 1)
        TextBox19.Height = TextBox19.Font.Height * (TextBox19.Lines.Count + 1)
        TextBox20.Height = TextBox20.Font.Height * (TextBox20.Lines.Count + 1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
        Form1.NuevaVenta()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Visible = False
        Button2.Visible = False
        PrintForm1.Print()
        Button1.Visible = True
        Button2.Visible = True
    End Sub
End Class