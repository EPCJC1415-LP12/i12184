<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblBola1 = New System.Windows.Forms.TextBox()
        Me.lblBola2 = New System.Windows.Forms.TextBox()
        Me.lblBola3 = New System.Windows.Forms.TextBox()
        Me.lblBola4 = New System.Windows.Forms.TextBox()
        Me.lblBola5 = New System.Windows.Forms.TextBox()
        Me.lblEstrela2 = New System.Windows.Forms.TextBox()
        Me.lblEstrela1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnExtracao = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBola1
        '
        Me.lblBola1.Location = New System.Drawing.Point(25, 271)
        Me.lblBola1.Name = "lblBola1"
        Me.lblBola1.Size = New System.Drawing.Size(58, 20)
        Me.lblBola1.TabIndex = 0
        '
        'lblBola2
        '
        Me.lblBola2.Location = New System.Drawing.Point(89, 271)
        Me.lblBola2.Name = "lblBola2"
        Me.lblBola2.Size = New System.Drawing.Size(58, 20)
        Me.lblBola2.TabIndex = 1
        '
        'lblBola3
        '
        Me.lblBola3.Location = New System.Drawing.Point(153, 271)
        Me.lblBola3.Name = "lblBola3"
        Me.lblBola3.Size = New System.Drawing.Size(58, 20)
        Me.lblBola3.TabIndex = 2
        '
        'lblBola4
        '
        Me.lblBola4.Location = New System.Drawing.Point(217, 271)
        Me.lblBola4.Name = "lblBola4"
        Me.lblBola4.Size = New System.Drawing.Size(58, 20)
        Me.lblBola4.TabIndex = 3
        '
        'lblBola5
        '
        Me.lblBola5.Location = New System.Drawing.Point(281, 271)
        Me.lblBola5.Name = "lblBola5"
        Me.lblBola5.Size = New System.Drawing.Size(58, 20)
        Me.lblBola5.TabIndex = 4
        '
        'lblEstrela2
        '
        Me.lblEstrela2.Location = New System.Drawing.Point(473, 271)
        Me.lblEstrela2.Name = "lblEstrela2"
        Me.lblEstrela2.Size = New System.Drawing.Size(58, 20)
        Me.lblEstrela2.TabIndex = 5
        '
        'lblEstrela1
        '
        Me.lblEstrela1.Location = New System.Drawing.Point(409, 271)
        Me.lblEstrela1.Name = "lblEstrela1"
        Me.lblEstrela1.Size = New System.Drawing.Size(58, 20)
        Me.lblEstrela1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(448, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Estrelas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Bolas"
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Location = New System.Drawing.Point(25, 390)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(75, 23)
        Me.btnOrdenar.TabIndex = 9
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = True
        '
        'btnExtracao
        '
        Me.btnExtracao.Location = New System.Drawing.Point(136, 390)
        Me.btnExtracao.Name = "btnExtracao"
        Me.btnExtracao.Size = New System.Drawing.Size(75, 23)
        Me.btnExtracao.TabIndex = 10
        Me.btnExtracao.Text = "Extração"
        Me.btnExtracao.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(473, 390)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 11
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 458)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnExtracao)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEstrela1)
        Me.Controls.Add(Me.lblEstrela2)
        Me.Controls.Add(Me.lblBola5)
        Me.Controls.Add(Me.lblBola4)
        Me.Controls.Add(Me.lblBola3)
        Me.Controls.Add(Me.lblBola2)
        Me.Controls.Add(Me.lblBola1)
        Me.Name = "Form1"
        Me.Text = "Euromilhoes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBola1 As System.Windows.Forms.TextBox
    Friend WithEvents lblBola2 As System.Windows.Forms.TextBox
    Friend WithEvents lblBola3 As System.Windows.Forms.TextBox
    Friend WithEvents lblBola4 As System.Windows.Forms.TextBox
    Friend WithEvents lblBola5 As System.Windows.Forms.TextBox
    Friend WithEvents lblEstrela2 As System.Windows.Forms.TextBox
    Friend WithEvents lblEstrela1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOrdenar As System.Windows.Forms.Button
    Friend WithEvents btnExtracao As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button

End Class
