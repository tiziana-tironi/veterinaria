<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mascota
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
        Me.LblMascot = New System.Windows.Forms.Label()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LblAño = New System.Windows.Forms.Label()
        Me.LblNam = New System.Windows.Forms.Label()
        Me.TxtbAño = New System.Windows.Forms.TextBox()
        Me.TxtbNam = New System.Windows.Forms.TextBox()
        Me.TxtbId = New System.Windows.Forms.TextBox()
        Me.LblCedum = New System.Windows.Forms.Label()
        Me.TxtbCedum = New System.Windows.Forms.TextBox()
        Me.BtnGuarM = New System.Windows.Forms.Button()
        Me.BtnCanM = New System.Windows.Forms.Button()
        Me.LblMostrar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblMascot
        '
        Me.LblMascot.AutoSize = True
        Me.LblMascot.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMascot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LblMascot.Location = New System.Drawing.Point(342, 28)
        Me.LblMascot.Name = "LblMascot"
        Me.LblMascot.Size = New System.Drawing.Size(109, 29)
        Me.LblMascot.TabIndex = 1
        Me.LblMascot.Text = "Mascota"
        Me.LblMascot.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId.ForeColor = System.Drawing.Color.Black
        Me.LblId.Location = New System.Drawing.Point(139, 131)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(29, 18)
        Me.LblId.TabIndex = 2
        Me.LblId.Text = "ID:"
        '
        'LblAño
        '
        Me.LblAño.AutoSize = True
        Me.LblAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAño.ForeColor = System.Drawing.Color.Black
        Me.LblAño.Location = New System.Drawing.Point(84, 216)
        Me.LblAño.Name = "LblAño"
        Me.LblAño.Size = New System.Drawing.Size(152, 18)
        Me.LblAño.TabIndex = 3
        Me.LblAño.Text = "Año de nacimiento:"
        '
        'LblNam
        '
        Me.LblNam.AutoSize = True
        Me.LblNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNam.ForeColor = System.Drawing.Color.Black
        Me.LblNam.Location = New System.Drawing.Point(120, 170)
        Me.LblNam.Name = "LblNam"
        Me.LblNam.Size = New System.Drawing.Size(73, 18)
        Me.LblNam.TabIndex = 4
        Me.LblNam.Text = "Nombre:"
        '
        'TxtbAño
        '
        Me.TxtbAño.Location = New System.Drawing.Point(277, 214)
        Me.TxtbAño.Name = "TxtbAño"
        Me.TxtbAño.Size = New System.Drawing.Size(100, 20)
        Me.TxtbAño.TabIndex = 6
        '
        'TxtbNam
        '
        Me.TxtbNam.Location = New System.Drawing.Point(277, 170)
        Me.TxtbNam.Name = "TxtbNam"
        Me.TxtbNam.Size = New System.Drawing.Size(100, 20)
        Me.TxtbNam.TabIndex = 7
        '
        'TxtbId
        '
        Me.TxtbId.Location = New System.Drawing.Point(277, 131)
        Me.TxtbId.Name = "TxtbId"
        Me.TxtbId.Size = New System.Drawing.Size(100, 20)
        Me.TxtbId.TabIndex = 8
        '
        'LblCedum
        '
        Me.LblCedum.AutoSize = True
        Me.LblCedum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedum.ForeColor = System.Drawing.Color.Black
        Me.LblCedum.Location = New System.Drawing.Point(94, 260)
        Me.LblCedum.Name = "LblCedum"
        Me.LblCedum.Size = New System.Drawing.Size(131, 18)
        Me.LblCedum.TabIndex = 9
        Me.LblCedum.Text = "Cedula persona:"
        '
        'TxtbCedum
        '
        Me.TxtbCedum.Location = New System.Drawing.Point(277, 258)
        Me.TxtbCedum.Name = "TxtbCedum"
        Me.TxtbCedum.Size = New System.Drawing.Size(100, 20)
        Me.TxtbCedum.TabIndex = 10
        '
        'BtnGuarM
        '
        Me.BtnGuarM.ForeColor = System.Drawing.Color.Black
        Me.BtnGuarM.Location = New System.Drawing.Point(277, 380)
        Me.BtnGuarM.Name = "BtnGuarM"
        Me.BtnGuarM.Size = New System.Drawing.Size(87, 29)
        Me.BtnGuarM.TabIndex = 11
        Me.BtnGuarM.Text = "Guardar"
        Me.BtnGuarM.UseVisualStyleBackColor = True
        '
        'BtnCanM
        '
        Me.BtnCanM.ForeColor = System.Drawing.Color.Black
        Me.BtnCanM.Location = New System.Drawing.Point(452, 380)
        Me.BtnCanM.Name = "BtnCanM"
        Me.BtnCanM.Size = New System.Drawing.Size(87, 29)
        Me.BtnCanM.TabIndex = 12
        Me.BtnCanM.Text = "Cancelar"
        Me.BtnCanM.UseVisualStyleBackColor = True
        '
        'LblMostrar
        '
        Me.LblMostrar.AutoSize = True
        Me.LblMostrar.ForeColor = System.Drawing.Color.Black
        Me.LblMostrar.Location = New System.Drawing.Point(608, 177)
        Me.LblMostrar.Name = "LblMostrar"
        Me.LblMostrar.Size = New System.Drawing.Size(39, 13)
        Me.LblMostrar.TabIndex = 13
        Me.LblMostrar.Text = "Mostar"
        '
        'Mascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblMostrar)
        Me.Controls.Add(Me.BtnCanM)
        Me.Controls.Add(Me.BtnGuarM)
        Me.Controls.Add(Me.TxtbCedum)
        Me.Controls.Add(Me.LblCedum)
        Me.Controls.Add(Me.TxtbId)
        Me.Controls.Add(Me.TxtbNam)
        Me.Controls.Add(Me.TxtbAño)
        Me.Controls.Add(Me.LblNam)
        Me.Controls.Add(Me.LblAño)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.LblMascot)
        Me.Name = "Mascota"
        Me.Text = "Mascota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblMascot As Label
    Friend WithEvents LblId As Label
    Friend WithEvents LblAño As Label
    Friend WithEvents LblNam As Label
    Friend WithEvents TxtbAño As TextBox
    Friend WithEvents TxtbNam As TextBox
    Friend WithEvents TxtbId As TextBox
    Friend WithEvents LblCedum As Label
    Friend WithEvents TxtbCedum As TextBox
    Friend WithEvents BtnGuarM As Button
    Friend WithEvents BtnCanM As Button
    Friend WithEvents LblMostrar As Label
End Class
