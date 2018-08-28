<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonasForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.id = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.nombre = New System.Windows.Forms.Label
        Me.direccion = New System.Windows.Forms.Label
        Me.codpostal = New System.Windows.Forms.Label
        Me.idprovincia = New System.Windows.Forms.Label
        Me.tipodocumento = New System.Windows.Forms.Label
        Me.nroDocumento = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.cancelar = New System.Windows.Forms.Button
        Me.aceptar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(119, 63)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(21, 13)
        Me.id.TabIndex = 0
        Me.id.Text = "ID:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(146, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 1
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Location = New System.Drawing.Point(93, 89)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(47, 13)
        Me.nombre.TabIndex = 2
        Me.nombre.Text = "Nombre:"
        '
        'direccion
        '
        Me.direccion.AutoSize = True
        Me.direccion.Location = New System.Drawing.Point(85, 115)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(55, 13)
        Me.direccion.TabIndex = 3
        Me.direccion.Text = "Direccion:"
        '
        'codpostal
        '
        Me.codpostal.AutoSize = True
        Me.codpostal.Location = New System.Drawing.Point(65, 142)
        Me.codpostal.Name = "codpostal"
        Me.codpostal.Size = New System.Drawing.Size(75, 13)
        Me.codpostal.TabIndex = 4
        Me.codpostal.Text = "Código Postal:"
        '
        'idprovincia
        '
        Me.idprovincia.AutoSize = True
        Me.idprovincia.Location = New System.Drawing.Point(72, 169)
        Me.idprovincia.Name = "idprovincia"
        Me.idprovincia.Size = New System.Drawing.Size(68, 13)
        Me.idprovincia.TabIndex = 5
        Me.idprovincia.Text = "ID Provincia:"
        '
        'tipodocumento
        '
        Me.tipodocumento.AutoSize = True
        Me.tipodocumento.Location = New System.Drawing.Point(36, 196)
        Me.tipodocumento.Name = "tipodocumento"
        Me.tipodocumento.Size = New System.Drawing.Size(104, 13)
        Me.tipodocumento.TabIndex = 6
        Me.tipodocumento.Text = "Tipo de Documento:"
        '
        'nroDocumento
        '
        Me.nroDocumento.AutoSize = True
        Me.nroDocumento.Location = New System.Drawing.Point(20, 223)
        Me.nroDocumento.Name = "nroDocumento"
        Me.nroDocumento.Size = New System.Drawing.Size(120, 13)
        Me.nroDocumento.TabIndex = 7
        Me.nroDocumento.Text = "Número de Documento:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(146, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(207, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(146, 112)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(207, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(146, 139)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(207, 20)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(146, 220)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(207, 20)
        Me.TextBox7.TabIndex = 13
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(278, 271)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cancelar.TabIndex = 14
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(197, 271)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(75, 23)
        Me.aceptar.TabIndex = 15
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Complete el formulario"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(146, 165)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(207, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(146, 193)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(207, 21)
        Me.ComboBox2.TabIndex = 18
        '
        'PersonasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 306)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.nroDocumento)
        Me.Controls.Add(Me.tipodocumento)
        Me.Controls.Add(Me.idprovincia)
        Me.Controls.Add(Me.codpostal)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.id)
        Me.Name = "PersonasForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PersonasForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents nombre As System.Windows.Forms.Label
    Friend WithEvents direccion As System.Windows.Forms.Label
    Friend WithEvents codpostal As System.Windows.Forms.Label
    Friend WithEvents idprovincia As System.Windows.Forms.Label
    Friend WithEvents tipodocumento As System.Windows.Forms.Label
    Friend WithEvents nroDocumento As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents cancelar As System.Windows.Forms.Button
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
