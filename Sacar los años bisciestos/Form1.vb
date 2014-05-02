Public Class Form1
    Public Sub AñosBisiestos()

        'Condiciones que validaran los TexBox con un mensaje 
        If TextBox_Inicial.Text = "" Then
            MessageBox.Show("Ingrese año inicial", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else                     'Menor o Igual que 
            If TextBox_Inicial.Text.Length <= 3 Then
                MessageBox.Show("Año inicial debe tener 4 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If TextBox_Final.Text = "" Then
                    MessageBox.Show("Ingrese año Final", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else                     'Menor o Igual que 
                    If TextBox_Final.Text.Length <= 3 Then
                        MessageBox.Show("Año Final debe tener 4 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else                'Mayor o Igual que
                        If (TextBox_Inicial.Text) >= CInt(TextBox_Final.Text) Then
                            'CInt convierte una cadena en un entero si es posible. Leerlo como Convert integer 
                            MessageBox.Show("Año inicial debe ser mero que año final", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            'Clico for que nos permita repetir los valores que ingresemos por los TexBox
                            For Inicial As Integer = CInt(TextBox_Inicial.Text) To CInt(TextBox_Final.Text)
                                'Condición que nos permite mostrar los mensajes en el ListBox de acuerdo a la condición

                                'Esta condicen no permitirá buscar los años bisiestos 
                                'ya que todos los años múltiplos de 4 son años Bisiestos

                                'Mod es una división para mostrar el residuo de la división 

                                'Cada 4 años si son bisiesto  cada 100 años no es bisiesto  Cada 400 años si son bisiesto
                                If (Inicial Mod 4 = 0) And (Inicial Mod 100) <> 0 Or (Inicial Mod 400) = 0 Then
                                    'Años múltiplos de 4 ,400               diferente
                                    ListBox1.Items.Add("El año " & Inicial.ToString() & " si es biciesto")
                                Else
                                    'Años no multiplos de 4 ,400
                                    ListBox1.Items.Add("El año " & Inicial.ToString() & " no es biciesto")
                                End If

                            Next

                        End If

                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Button_Calcular_Click(sender As Object, e As EventArgs) Handles Button_Calcular.Click
        AñosBisiestos()
       
    End Sub

    Private Sub Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        ListBox1.Items.Clear()
        TextBox_Inicial.Text = ""
        TextBox_Final.Text = ""
    End Sub
End Class
