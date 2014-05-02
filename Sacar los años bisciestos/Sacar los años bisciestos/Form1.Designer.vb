<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button_Calcular = New System.Windows.Forms.Button()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox_Final = New System.Windows.Forms.TextBox()
        Me.TextBox_Inicial = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button_Calcular
        '
        Me.Button_Calcular.Location = New System.Drawing.Point(20, 297)
        Me.Button_Calcular.Name = "Button_Calcular"
        Me.Button_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Button_Calcular.TabIndex = 0
        Me.Button_Calcular.Text = "Calcular"
        Me.Button_Calcular.UseVisualStyleBackColor = True
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.Location = New System.Drawing.Point(113, 297)
        Me.Button_Limpiar.Name = "Button_Limpiar"
        Me.Button_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Limpiar.TabIndex = 1
        Me.Button_Limpiar.Text = "Limpiar"
        Me.Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Año final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Año inicial"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 94)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(187, 186)
        Me.ListBox1.TabIndex = 4
        '
        'TextBox_Final
        '
        Me.TextBox_Final.Location = New System.Drawing.Point(99, 57)
        Me.TextBox_Final.MaxLength = 4
        Me.TextBox_Final.Name = "TextBox_Final"
        Me.TextBox_Final.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Final.TabIndex = 5
        '
        'TextBox_Inicial
        '
        Me.TextBox_Inicial.Location = New System.Drawing.Point(99, 17)
        Me.TextBox_Inicial.MaxLength = 4
        Me.TextBox_Inicial.Name = "TextBox_Inicial"
        Me.TextBox_Inicial.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Inicial.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 339)
        Me.Controls.Add(Me.TextBox_Inicial)
        Me.Controls.Add(Me.TextBox_Final)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Limpiar)
        Me.Controls.Add(Me.Button_Calcular)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sacar los años bisciestos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Calcular As System.Windows.Forms.Button
    Friend WithEvents Button_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox_Final As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Inicial As System.Windows.Forms.TextBox

End Class
