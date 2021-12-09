<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cardapio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cardapio))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_pedido1 = New System.Windows.Forms.Button()
        Me.txt_pedido2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, -2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1218, 636)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.btn_pedido1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1210, 610)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Página 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.txt_pedido2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1210, 610)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Página 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_pedido1
        '
        Me.btn_pedido1.BackColor = System.Drawing.Color.Black
        Me.btn_pedido1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_pedido1.ForeColor = System.Drawing.Color.White
        Me.btn_pedido1.Location = New System.Drawing.Point(1006, 537)
        Me.btn_pedido1.Name = "btn_pedido1"
        Me.btn_pedido1.Size = New System.Drawing.Size(142, 32)
        Me.btn_pedido1.TabIndex = 0
        Me.btn_pedido1.Text = "Fazer Pedido"
        Me.btn_pedido1.UseVisualStyleBackColor = False
        '
        'txt_pedido2
        '
        Me.txt_pedido2.BackColor = System.Drawing.Color.Black
        Me.txt_pedido2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_pedido2.ForeColor = System.Drawing.Color.White
        Me.txt_pedido2.Location = New System.Drawing.Point(489, 556)
        Me.txt_pedido2.Name = "txt_pedido2"
        Me.txt_pedido2.Size = New System.Drawing.Size(142, 32)
        Me.txt_pedido2.TabIndex = 1
        Me.txt_pedido2.Text = "Fazer Pedido"
        Me.txt_pedido2.UseVisualStyleBackColor = False
        '
        'cardapio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 634)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "cardapio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cardapio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_pedido1 As System.Windows.Forms.Button
    Friend WithEvents txt_pedido2 As System.Windows.Forms.Button
End Class
