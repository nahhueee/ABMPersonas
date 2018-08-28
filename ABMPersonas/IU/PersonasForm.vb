Public Class PersonasForm

    Dim operacion_ As String
    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte
    Public Property indice() As Byte
        Get
            Return indice
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Dim MiPersona As New PersonasClass

    Private Sub PersonasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = MiPersona.provincias
        ComboBox2.DataSource = MiPersona.documentos
        TextBox1.Enabled = False
        TextBox1.ReadOnly = True
        'ComboBox1.SelectedIndex = 0
        'ComboBox2.SelectedIndex = 0
    End Sub

    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        Me.Close()
    End Sub

    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click
        MiPersona.id = CInt(TextBox1.Text)
        MiPersona.nombre = TextBox2.Text
        MiPersona.direccion = TextBox3.Text
        MiPersona.codPostal = CInt(TextBox4.Text)
        MiPersona.idProvincia = ComboBox1.SelectedIndex
        MiPersona.tipoDocumento = ComboBox2.SelectedIndex
        MiPersona.nroDocumento = CInt(TextBox7.Text)


        Select Case operacion_
            Case "nuevo"
                lst.InsertarPersona(MiPersona)
            Case "elimina"
                lst.EliminarPersona(MiPersona)
            Case "modifica"
                lst.ActualizarPersona(MiPersona)

                PersonasGrid.DataGridView1.Refresh()
        End Select
        Me.Close()
    End Sub
End Class