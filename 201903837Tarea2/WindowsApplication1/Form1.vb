Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAzucar.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagoSinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoConIVA As Double = 0
    Dim descuento As Double = 0
    Dim pagoFinal As Double = 0

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'Aqui va el codigo relacionado a los calculos de los pagos
        pagoSinIVA = (Val(txtArroz.Text) * precioArroz) + (Val(txtFrijol.Text) * precioFrijol) + (Val(txtAzucar.Text) * precioAzucar)
        valorIVA = pagoSinIVA * IVA
        pagoConIVA = pagoSinIVA + valorIVA
        descuento = pagoConIVA * 0.025
        pagoFinal = pagoConIVA - descuento



        lblR1.Text = pagoSinIVA
        lblR2.Text = valorIVA
        lblR3.Text = pagoConIVA
        lblR4.Text = descuento
        lblR5.Text = pagoFinal

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        'Aqui va el codigo relacionado a limpiar todas las variables
        txtArroz.Clear()
        txtAzucar.Clear()
        txtFrijol.Clear()

        'Aqui deben limpiar los textbox, los label de resultados y las variables de resultados
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        'Aqui va el codigo que pregunta si queremos cerrar la app
        Me.Close()
    End Sub

    Private Sub txtArroz_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArroz.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFrijol_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFrijol.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAzucar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAzucar.KeyPress
        'Codigo que solo permite ingresar numeros
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtArroz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArroz.TextChanged

    End Sub

    Private Sub Opciones_Enter(sender As Object, e As EventArgs) Handles Opciones.Enter

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
