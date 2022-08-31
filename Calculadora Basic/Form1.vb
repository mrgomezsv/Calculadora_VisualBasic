Public Class Form1
    'Variables de la calculadora'
    Dim Operation As String 'Almacenara los caracteres de las operaciones basicas + - * /'
    Dim VResult As Nullable(Of Double) = Nothing 'Sera decimal y se declara nula si no es nula entendera que es 0 y eso afectaria una operacion'
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SeleccionOperacion As Boolean 'Almacena el operador que usemos'


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Concatena()
        TextResult.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Concatena()
        TextResult.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Concatena()
        TextResult.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Concatena()
        TextResult.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Concatena()
        TextResult.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Concatena()
        TextResult.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Concatena()
        TextResult.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Concatena()
        TextResult.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Concatena()
        TextResult.Text &= "9"
    End Sub

    Private Sub ButtonPoint_Click(sender As Object, e As EventArgs) Handles ButtonPoint.Click
        Concatena()
        If InStr(TextResult.Text, ".", CompareMethod.Text) = 0 Then 'InStr devuelve un valor numerico, el valor donde esta el . en Result, si no encuentra nada devuelve 0'
            TextResult.Text &= "." 'Si no encontro . nos va dejar poner 1 y nada mas 1'
        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Evalua() 'Funcion que evalua la operacion'
        Operation = "+" 'Establecemos el valor a estar escuchado si se preciona'
    End Sub

    Private Sub ButtonSubtract_Click(sender As Object, e As EventArgs) Handles ButtonSubtract.Click
        Evalua()
        Operation = "-"
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        Evalua()
        Operation = "*"
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        Evalua() 'Funcion que evalua la operacion'
        Operation = "/"
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        TextResult.Text = "0" 'El textbox muestra 0'
        Valor2 = Nothing 'El valor de la variable Valor2 es Nulo'
        VResult = Nothing 'El valor de la variable resultado es Nulo'
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        Evalua()
        Operation = ""
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Concatena()
        TextResult.Text &= "0"
    End Sub

    Public Sub Evalua() 'Funcion Evalua'
        SeleccionOperacion = True 'Cheka que continue si se preciona un operador y da el paso para todos'

        Valor2 = Val(TextResult.Text) 'guardamos en Valor2 el valor que tenemos en el textbox'

        If VResult IsNot Nothing Then 'ejecutamos la condicion para hacer la operacion'

            Select Case Operation 'Entra al while para hacer la operacion que corresponda a la condicion del operador seleccionado'
                Case "+"
                    VResult = VResult + Valor2
                Case "-"
                    VResult -= Valor2
                Case "*"
                    VResult *= Valor2
                Case "/"
                    VResult /= Valor2
            End Select

            TextResult.Text = VResult 'Cuando se hiso la operacion se imprime en el textbox'

        Else
            VResult = Valor2 'En caso contrario el valor2 lo guarda en el resultado'

        End If
    End Sub

    Public Sub Concatena() 'Funcion para borrar el textbox e ingresar el segundo o mas datos para hacer la operacion'
        If SeleccionOperacion = True Then
            TextResult.Text = ""
            SeleccionOperacion = False
        ElseIf TextResult.Text = "0" Then
            TextResult.Text = ""
        End If

    End Sub

End Class
