<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Persona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblPerson = New System.Windows.Forms.Label()
        Me.LblCedu = New System.Windows.Forms.Label()
        Me.LblTel = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblDir = New System.Windows.Forms.Label()
        Me.TxtbCedu = New System.Windows.Forms.TextBox()
        Me.TxtbDir = New System.Windows.Forms.TextBox()
        Me.TxtbTel = New System.Windows.Forms.TextBox()
        Me.TxtbName = New System.Windows.Forms.TextBox()
        Me.BtnGuar = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.LblMostrar = New System.Windows.Forms.Label()
        Me.btntelefono = New System.Windows.Forms.Button()
        Me.lv_telefono = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'LblPerson
        '
        Me.LblPerson.AutoSize = True
        Me.LblPerson.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPerson.Location = New System.Drawing.Point(354, 21)
        Me.LblPerson.Name = "LblPerson"
        Me.LblPerson.Size = New System.Drawing.Size(108, 29)
        Me.LblPerson.TabIndex = 0
        Me.LblPerson.Text = "Persona"
        Me.LblPerson.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblCedu
        '
        Me.LblCedu.AutoSize = True
        Me.LblCedu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedu.ForeColor = System.Drawing.Color.Black
        Me.LblCedu.Location = New System.Drawing.Point(104, 90)
        Me.LblCedu.Name = "LblCedu"
        Me.LblCedu.Size = New System.Drawing.Size(65, 18)
        Me.LblCedu.TabIndex = 1
        Me.LblCedu.Text = "Cedula:"
        '
        'LblTel
        '
        Me.LblTel.AutoSize = True
        Me.LblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTel.ForeColor = System.Drawing.Color.Black
        Me.LblTel.Location = New System.Drawing.Point(104, 202)
        Me.LblTel.Name = "LblTel"
        Me.LblTel.Size = New System.Drawing.Size(79, 18)
        Me.LblTel.TabIndex = 2
        Me.LblTel.Text = "Telefono:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.Black
        Me.LblName.Location = New System.Drawing.Point(104, 145)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(73, 18)
        Me.LblName.TabIndex = 3
        Me.LblName.Text = "Nombre:"
        '
        'LblDir
        '
        Me.LblDir.AutoSize = True
        Me.LblDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDir.ForeColor = System.Drawing.Color.Black
        Me.LblDir.Location = New System.Drawing.Point(104, 255)
        Me.LblDir.Name = "LblDir"
        Me.LblDir.Size = New System.Drawing.Size(85, 18)
        Me.LblDir.TabIndex = 4
        Me.LblDir.Text = "Direccion:"
        '
        'TxtbCedu
        '
        Me.TxtbCedu.Location = New System.Drawing.Point(203, 88)
        Me.TxtbCedu.Name = "TxtbCedu"
        Me.TxtbCedu.Size = New System.Drawing.Size(100, 20)
        Me.TxtbCedu.TabIndex = 5
        '
        'TxtbDir
        '
        Me.TxtbDir.Location = New System.Drawing.Point(203, 253)
        Me.TxtbDir.Name = "TxtbDir"
        Me.TxtbDir.Size = New System.Drawing.Size(100, 20)
        Me.TxtbDir.TabIndex = 6
        '
        'TxtbTel
        '
        Me.TxtbTel.Location = New System.Drawing.Point(203, 200)
        Me.TxtbTel.Name = "TxtbTel"
        Me.TxtbTel.Size = New System.Drawing.Size(100, 20)
        Me.TxtbTel.TabIndex = 7
        '
        'TxtbName
        '
        Me.TxtbName.Location = New System.Drawing.Point(203, 143)
        Me.TxtbName.Name = "TxtbName"
        Me.TxtbName.Size = New System.Drawing.Size(100, 20)
        Me.TxtbName.TabIndex = 8
        '
        'BtnGuar
        '
        Me.BtnGuar.ForeColor = System.Drawing.Color.Black
        Me.BtnGuar.Location = New System.Drawing.Point(257, 391)
        Me.BtnGuar.Name = "BtnGuar"
        Me.BtnGuar.Size = New System.Drawing.Size(87, 29)
        Me.BtnGuar.TabIndex = 9
        Me.BtnGuar.Text = "Guardar"
        Me.BtnGuar.UseVisualStyleBackColor = True
        '
        'BtnCan
        '
        Me.BtnCan.ForeColor = System.Drawing.Color.Black
        Me.BtnCan.Location = New System.Drawing.Point(484, 391)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(87, 29)
        Me.BtnCan.TabIndex = 10
        Me.BtnCan.Text = "Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'LblMostrar
        '
        Me.LblMostrar.AutoSize = True
        Me.LblMostrar.ForeColor = System.Drawing.Color.Black
        Me.LblMostrar.Location = New System.Drawing.Point(554, 120)
        Me.LblMostrar.Name = "LblMostrar"
        Me.LblMostrar.Size = New System.Drawing.Size(39, 13)
        Me.LblMostrar.TabIndex = 11
        Me.LblMostrar.Text = "Mostar"
        '
        'btntelefono
        '
        Me.btntelefono.Location = New System.Drawing.Point(323, 195)
        Me.btntelefono.Name = "btntelefono"
        Me.btntelefono.Size = New System.Drawing.Size(35, 28)
        Me.btntelefono.TabIndex = 12
        Me.btntelefono.Text = "+"
        Me.btntelefono.UseVisualStyleBackColor = True
        '
        'lv_telefono
        '
        Me.lv_telefono.HideSelection = False
        Me.lv_telefono.Location = New System.Drawing.Point(484, 120)
        Me.lv_telefono.Name = "lv_telefono"
        Me.lv_telefono.Size = New System.Drawing.Size(194, 184)
        Me.lv_telefono.TabIndex = 13
        Me.lv_telefono.UseCompatibleStateImageBehavior = False
        Me.lv_telefono.View = System.Windows.Forms.View.List
        '
        'Persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lv_telefono)
        Me.Controls.Add(Me.btntelefono)
        Me.Controls.Add(Me.LblMostrar)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnGuar)
        Me.Controls.Add(Me.TxtbName)
        Me.Controls.Add(Me.TxtbTel)
        Me.Controls.Add(Me.TxtbDir)
        Me.Controls.Add(Me.TxtbCedu)
        Me.Controls.Add(Me.LblDir)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblTel)
        Me.Controls.Add(Me.LblCedu)
        Me.Controls.Add(Me.LblPerson)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Name = "Persona"
        Me.Text = "Persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPerson As Label
    Friend WithEvents LblCedu As Label
    Friend WithEvents LblTel As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblDir As Label
    Friend WithEvents TxtbCedu As TextBox
    Friend WithEvents TxtbDir As TextBox
    Friend WithEvents TxtbTel As TextBox
    Friend WithEvents TxtbName As TextBox
    Friend WithEvents BtnGuar As Button
    Friend WithEvents BtnCan As Button
    Friend WithEvents LblMostrar As Label
    Friend WithEvents btntelefono As Button
    Friend WithEvents lv_telefono As ListView
End Class
