Imports System.Text.RegularExpressions
'Imports MySql.Data.MySqlClient
Public Class frmPrincipal
    'Dim conexion As MySqlConnection
    'Dim cmd As New MySqlCommand
    'Public Sub New()
    ' Esta llamada es exigida por el diseñador.
    'InitializeComponent()
    ' conexion = New MySqlConnection
    'conexion.ConnectionString = "Server=localhost; database=mercado_lider; Uid=root; pwd=;"
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    'End Sub
    Dim correo As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Domicilio.Hide()
        ocultarbarritas()
        subbarritas()
        labelsError()
        pnlInicio.Visible = True
        Combobox()
    End Sub
    Private Function checkvalidacion()
        Dim contador As Integer = 0
        '==========================================
        If TextBox1.Text = "" Then
            Label87.Visible = True
        Else
            If TextBox1.TextLength < 3 Then
                Label101.Visible = True
            Else
                contador = contador + 1
            End If
        End If
        '==========================================
        If TextBox2.Text = "" Then
            Label90.Visible = True
        Else
            VerificarCorreo(val:=TextBox2.Text)
            If (correo = 1) Then
                contador = contador + 1
            Else
                Label102.Visible = True
            End If
            correo = 0
        End If
        '==========================================
        If TextBox3.Text = "" Then
            Label91.Visible = True
        Else
            If TextBox3.TextLength < 9 Then
                Label84.Visible = True
            Else
                contador = contador + 1
            End If
        End If
        '==========================================
        If TextBox4.Text = "" Then
            Label92.Visible = True
        Else
            If TextBox4.TextLength < 8 Then
                Label86.Visible = True
            Else
                contador = contador + 1
            End If
        End If
        '==========================================
        If (contador = 4) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function VerificarCorreo(val As String) As String
        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(val, par) Then
            correo = 1
        Else
            correo = 0
        End If

    End Function
    Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
    End Function
    Private Sub labelsError()
        Label84.Visible = False
        Label86.Visible = False
        Label87.Visible = False
        Label90.Visible = False
        Label91.Visible = False
        Label92.Visible = False
        Label93.Visible = False
        Label94.Visible = False
        Label95.Visible = False
        Label96.Visible = False
        Label97.Visible = False
        Label98.Visible = False
        Label99.Visible = False
        Label100.Visible = False
        Label101.Visible = False
        Label102.Visible = False
        Label103.Visible = False
        Label104.Visible = False
        Label105.Visible = False
        Label106.Visible = False
        Label107.Visible = False
        Label108.Visible = False
        Label109.Visible = False
        Label110.Visible = False
        Label111.Visible = False
        Label112.Visible = False
        Label114.Visible = False
        Label115.Visible = False
        Label116.Visible = False
        Label117.Visible = False
        Label118.Visible = False
        Label119.Visible = False
        Label120.Visible = False
    End Sub
    Private Sub Ocultarpaneles()
        panelbotonescarrito.Visible = False
        pnlAdmin.Visible = False
        pnPerfil.Visible = False
    End Sub
    Private Sub ocultarbarritas()
        pnlInicio.Visible = False
        pnlCarrito.Visible = False
        Panel9.Visible = False
        pnlCat.Visible = False
        Button49.Visible = False
        Button13.Visible = False
    End Sub
    Private Sub subbarritas()
        Panel5.Visible = False
        Panel3.Visible = False
        Panel7.Visible = False
        pnlEnca.Visible = False
        pnlCom.Visible = False
    End Sub
    Private Sub Combobox()
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(0)
        ocultarbarritas()
        Ocultarpaneles()
        pnlInicio.Visible = True
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(12)
        Ocultarpaneles()
        ocultarbarritas()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(1)
        Ocultarpaneles()
        ocultarbarritas()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(2)
        Ocultarpaneles()
        ocultarbarritas()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(3)
        Ocultarpaneles()
        Panel8.Visible = False
        Button49.Visible = False
    End Sub
    Private Sub btnCarrito_Click(sender As Object, e As EventArgs) Handles btnCarrito.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(7)
        Ocultarpaneles()
        panelbotonescarrito.Visible = True
        ocultarbarritas()
        pnlCarrito.Visible = True
        pnlEnca.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(7)
        pnlAdmin.Visible = False
        pnPerfil.Visible = False
        subbarritas()
        pnlEnca.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(8)
        pnlAdmin.Visible = False
        pnPerfil.Visible = False
        subbarritas()
        pnlCom.Visible = True
    End Sub

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(9)
        panelbotonescarrito.Visible = False
        pnPerfil.Visible = False
        subbarritas()
        Panel5.Visible = True
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(10)
        panelbotonescarrito.Visible = False
        pnPerfil.Visible = False
        subbarritas()
        Panel3.Visible = True
    End Sub

    Private Sub btnTransacciones_Click(sender As Object, e As EventArgs) Handles btnTransacciones.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(11)
        panelbotonescarrito.Visible = False
        pnPerfil.Visible = False
        subbarritas()
        Panel7.Visible = True
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        pnPerfil.Visible = True
        ocultarbarritas()
        pnlCat.Visible = True
        Button49.Visible = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(5)
        Ocultarpaneles()
        ocultarbarritas()
        Panel9.Visible = True
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Panel8.Visible = True
        Button13.Visible = True
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(13)
        Panel8.Visible = False
        Button49.Visible = False
        Ocultarpaneles()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(1)
        Ocultarpaneles()
        ocultarbarritas()
    End Sub
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(14)
        Ocultarpaneles()
        Button49.Visible = False
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim m As Integer
        If TextBox11.Text = "" Then
            Label103.Visible = True
        Else
            m = m + 1
        End If
        If TextBox12.Text = "" Then
            Label104.Visible = True
        Else
            m = m + 1
        End If
        If (m = 2) Then
            tbTodos.SelectedTab = tbTodos.TabPages.Item(9)
            Ocultarpaneles()
            ocultarbarritas()
            pnlAdmin.Visible = True
            Panel5.Visible = True
        End If
        m = 0
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(6)
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(6)
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(6)
    End Sub
    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(4)
    End Sub
    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(4)
    End Sub
    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(4)
    End Sub
    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        pnPerfil.Visible = False
        Button49.Visible = False
    End Sub
    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        'MsgBox(checkvalidacion())
        'If (checkvalidacion()) Then
        'Try
        conexion.Open()
                MsgBox("todo correcto")
        'cmd.Connection = conexion

        'cmd.CommandText = "SELECT Nombre from user where username = @nombre"
        'cmd.Prepare()
        'cmd.Parameters.Clear()
        'cmd.Parameters.AddWithValue("@nombre", TextBox1.Text)
        ' Catch ex As Exception

        'End Try
        'End If
    End Sub
    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        Label84.Visible = False
        Label91.Visible = False
    End Sub
    Private Sub TextBox15_Click(sender As Object, e As EventArgs)
        Label85.Visible = False
        TextBox15.Clear()
        TextBox15.ForeColor = Color.Black
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Label87.Visible = False
        Label101.Visible = False
    End Sub
    Private Sub TextBox5_Click(sender As Object, e As EventArgs)
        TextBox5.Clear()
        TextBox5.ForeColor = Color.Black
    End Sub
    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        Label90.Visible = False
        Label102.Visible = False
    End Sub
    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        Label92.Visible = False
        Label86.Visible = False
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If TextBox7.Text = "" Then
            Label93.Visible = True
        End If
        '==========================================
        If TextBox6.Text = "" Then
            Label94.Visible = True
        End If
    End Sub
    Private Sub TextBox7_Click(sender As Object, e As EventArgs) Handles TextBox7.Click
        Label93.Visible = False
    End Sub
    Private Sub TextBox6_Click(sender As Object, e As EventArgs) Handles TextBox6.Click
        Label94.Visible = False
    End Sub
    Private Sub tbxBuscar_Click(sender As Object, e As EventArgs) Handles tbxBuscar.Click
        tbxBuscar.Clear()
        tbxBuscar.ForeColor = Color.Black
    End Sub
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        If TextBox13.Text = "" Then

        Else
            If TextBox13.TextLength < 3 Then
                Label96.Visible = True
            End If
        End If

        '==========================================
        If TextBox14.Text = "" Then

        Else
            VerificarCorreo(val:=TextBox14.Text)
            If (correo = 1) Then

            Else
                Label95.Visible = True
            End If
            correo = 0
        End If
        '==========================================
        If TextBox5.Text = "" Then

        Else
            If TextBox5.TextLength < 3 Then
                Label97.Visible = True
            End If
        End If
        '==========================================
        If TextBox19.Text = "" Then
        Else
            If TextBox19.TextLength < 8 Then
                Label98.Visible = True
            End If
        End If
        '==========================================
        If TextBox15.Text = "" Then
        Else
            If TextBox15.TextLength < 3 Then
                Label100.Visible = True
            End If
        End If

    End Sub
    Private Sub TextBox13_Click(sender As Object, e As EventArgs) Handles TextBox13.Click
        Label96.Visible = False
    End Sub
    Private Sub TextBox14_Click(sender As Object, e As EventArgs) Handles TextBox14.Click
        Label95.Visible = False
    End Sub
    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        MsgBox("Seleccionando el permiso de 'vendedor',¡usted estara habilitado a vender sus propios articulos!")
    End Sub
    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        Panel8.Visible = False
        Button13.Visible = False
    End Sub
    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        tbTodos.SelectedTab = tbTodos.TabPages.Item(15)
        Panel8.Visible = False
        Button49.Visible = False
        Ocultarpaneles()
    End Sub
    Private Sub TextBox19_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox19.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox21_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox21.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox5_Click_1(sender As Object, e As EventArgs) Handles TextBox5.Click
        Label97.Visible = False
    End Sub
    Private Sub TextBox19_Click(sender As Object, e As EventArgs) Handles TextBox19.Click
        Label98.Visible = False
    End Sub
    Private Sub TextBox21_Click(sender As Object, e As EventArgs) Handles TextBox21.Click
        Label99.Visible = False
    End Sub
    Private Sub TextBox15_Click_1(sender As Object, e As EventArgs) Handles TextBox15.Click
        Label100.Visible = False
    End Sub
    Private Sub TextBox20_Click(sender As Object, e As EventArgs) Handles TextBox20.Click
        Domicilio.Show()
    End Sub
    Private Sub TextBox11_Click(sender As Object, e As EventArgs) Handles TextBox11.Click
        Label103.Visible = False
    End Sub
    Private Sub TextBox12_Click(sender As Object, e As EventArgs) Handles TextBox12.Click
        Label104.Visible = False
    End Sub
    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Dim H As Integer

        If TextBox17.Text = "" Then
            Label106.Visible = True
        Else
            VerificarCorreo(val:=TextBox17.Text)
            If correo = 1 Then
                H = H + 1
            Else
                Label105.Visible = True
            End If
        End If
        '==========================================
        If TextBox16.Text = "" Then
            Label107.Visible = True
        Else
            If TextBox16.TextLength < 6 Then
                Label110.Visible = True
            Else
                H = H + 1
            End If
        End If
        '==========================================
        If TextBox18.Text = "" Then
            Label108.Visible = True
        Else
            If TextBox18.TextLength < 6 Then
                Label111.Visible = True
            Else
                If TextBox18.Text = TextBox16.Text Then
                    H = H + 1
                Else
                    Label109.Visible = True
                End If
            End If
        End If
        '==========================================
        If (H = 3) Then
            Dim resultado As String
            resultado = MsgBox("ESTA SEGURO DE QUE DESEA CAMBIAR LA CONTRASEÑA", vbOKCancel, "CONFIRMACION")

            If resultado = vbOK Then
                Label112.Visible = True
            Else
                TextBox16.Clear()
                TextBox24.Clear()
                TextBox17.Clear()
                TextBox18.Clear()
            End If
        End If
        '==========================================
        If TextBox24.Text = "" Then
            Label117.Visible = True
        End If
    End Sub
    Private Sub TextBox17_Click(sender As Object, e As EventArgs) Handles TextBox17.Click
        Label105.Visible = False
        Label106.Visible = False
    End Sub
    Private Sub TextBox16_Click(sender As Object, e As EventArgs) Handles TextBox16.Click
        Label107.Visible = False
        Label110.Visible = False
        Label109.Visible = False
    End Sub
    Private Sub TextBox18_Click(sender As Object, e As EventArgs) Handles TextBox18.Click
        Label108.Visible = False
        Label111.Visible = False
        Label109.Visible = False
    End Sub
    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox10.Text = "" Then
            Label114.Visible = True
        End If
        '==========================================
        If TextBox8.Text = "" Then
            Label115.Visible = True
        Else
            If TextBox8.TextLength < 2 Then
                Label116.Visible = True
            End If
        End If
        '==========================================
        If TextBox9.Text = "" Then
            Label120.Visible = True
        End If
        '==========================================
        If TextBox23.Text = "" Then
            Label118.Visible = True
        Else
            If TextBox23.TextLength < 10 Then
                Label119.Visible = True
            End If
        End If
    End Sub
    Private Sub TextBox10_Click(sender As Object, e As EventArgs) Handles TextBox10.Click
        Label114.Visible = False
    End Sub
    Private Sub TextBox8_Click(sender As Object, e As EventArgs) Handles TextBox8.Click
        Label115.Visible = False
        Label116.Visible = False
    End Sub
    Private Sub TextBox9_Click(sender As Object, e As EventArgs) Handles TextBox9.Click
        Label120.Visible = False
    End Sub
    Private Sub TextBox23_Click(sender As Object, e As EventArgs) Handles TextBox23.Click
        Label118.Visible = False
        Label119.Visible = False
    End Sub
    Private Sub TextBox24_Click(sender As Object, e As EventArgs) Handles TextBox24.Click
        Label117.Visible = False
    End Sub


End Class
