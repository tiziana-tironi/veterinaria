<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonSearch
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
        Me.buttonSearch = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.Label()
        Me.TxtBoxCi = New System.Windows.Forms.TextBox()
        Me.CI = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Show = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonSearch
        '
        Me.buttonSearch.Location = New System.Drawing.Point(317, 344)
        Me.buttonSearch.Name = "buttonSearch"
        Me.buttonSearch.Size = New System.Drawing.Size(158, 38)
        Me.buttonSearch.TabIndex = 0
        Me.buttonSearch.Text = "Buscar"
        Me.buttonSearch.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.AutoSize = True
        Me.TxtSearch.Location = New System.Drawing.Point(339, 46)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(82, 13)
        Me.TxtSearch.TabIndex = 1
        Me.TxtSearch.Text = "Buscar Persona"
        '
        'TxtBoxCi
        '
        Me.TxtBoxCi.Location = New System.Drawing.Point(285, 134)
        Me.TxtBoxCi.Name = "TxtBoxCi"
        Me.TxtBoxCi.Size = New System.Drawing.Size(213, 20)
        Me.TxtBoxCi.TabIndex = 2
        '
        'CI
        '
        Me.CI.AutoSize = True
        Me.CI.Location = New System.Drawing.Point(247, 137)
        Me.CI.Name = "CI"
        Me.CI.Size = New System.Drawing.Size(15, 13)
        Me.CI.TabIndex = 3
        Me.CI.Text = "ci"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Show
        '
        Me.Show.AutoSize = True
        Me.Show.Location = New System.Drawing.Point(342, 192)
        Me.Show.Name = "Show"
        Me.Show.Size = New System.Drawing.Size(0, 13)
        Me.Show.TabIndex = 5
        '
        'PersonSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Show)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CI)
        Me.Controls.Add(Me.TxtBoxCi)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.buttonSearch)
        Me.Name = "PersonSearch"
        Me.Text = "PersonSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonSearch As Button
    Friend WithEvents TxtSearch As Label
    Friend WithEvents TxtBoxCi As TextBox
    Friend WithEvents CI As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Show As Label
End Class
