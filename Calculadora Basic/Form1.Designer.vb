<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.TextResult = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.ButtonPoint = New System.Windows.Forms.Button()
        Me.ButtonEqual = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSubtract = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextResult
        '
        Me.TextResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextResult.Location = New System.Drawing.Point(2, 23)
        Me.TextResult.Name = "TextResult"
        Me.TextResult.Size = New System.Drawing.Size(173, 26)
        Me.TextResult.TabIndex = 0
        Me.TextResult.Text = "0"
        Me.TextResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(68, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(124, 173)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 117)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 50)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(68, 117)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 50)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(124, 117)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 50)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 61)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(50, 50)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(68, 61)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(50, 50)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(124, 61)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 50)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(12, 229)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(50, 50)
        Me.ButtonDelete.TabIndex = 10
        Me.ButtonDelete.Text = "C"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Location = New System.Drawing.Point(68, 229)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(50, 50)
        Me.Button0.TabIndex = 11
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'ButtonPoint
        '
        Me.ButtonPoint.Location = New System.Drawing.Point(124, 229)
        Me.ButtonPoint.Name = "ButtonPoint"
        Me.ButtonPoint.Size = New System.Drawing.Size(50, 50)
        Me.ButtonPoint.TabIndex = 12
        Me.ButtonPoint.Text = "."
        Me.ButtonPoint.UseVisualStyleBackColor = True
        '
        'ButtonEqual
        '
        Me.ButtonEqual.Location = New System.Drawing.Point(181, 229)
        Me.ButtonEqual.Name = "ButtonEqual"
        Me.ButtonEqual.Size = New System.Drawing.Size(50, 50)
        Me.ButtonEqual.TabIndex = 13
        Me.ButtonEqual.Text = "="
        Me.ButtonEqual.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(181, 173)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(50, 50)
        Me.ButtonAdd.TabIndex = 14
        Me.ButtonAdd.Text = "+"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSubtract
        '
        Me.ButtonSubtract.Location = New System.Drawing.Point(180, 117)
        Me.ButtonSubtract.Name = "ButtonSubtract"
        Me.ButtonSubtract.Size = New System.Drawing.Size(50, 50)
        Me.ButtonSubtract.TabIndex = 15
        Me.ButtonSubtract.Text = "-"
        Me.ButtonSubtract.UseVisualStyleBackColor = True
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.Location = New System.Drawing.Point(180, 63)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(50, 50)
        Me.ButtonMultiply.TabIndex = 16
        Me.ButtonMultiply.Text = "X"
        Me.ButtonMultiply.UseVisualStyleBackColor = True
        '
        'ButtonDivide
        '
        Me.ButtonDivide.Location = New System.Drawing.Point(181, 7)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(50, 50)
        Me.ButtonDivide.TabIndex = 17
        Me.ButtonDivide.Text = "/"
        Me.ButtonDivide.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 289)
        Me.Controls.Add(Me.ButtonDivide)
        Me.Controls.Add(Me.ButtonMultiply)
        Me.Controls.Add(Me.ButtonSubtract)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonEqual)
        Me.Controls.Add(Me.ButtonPoint)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextResult)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextResult As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents ButtonPoint As Button
    Friend WithEvents ButtonEqual As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonSubtract As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivide As Button
End Class
