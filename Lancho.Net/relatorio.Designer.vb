<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class relatorio
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tb_pedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lancho_netDataSet = New Lancho.Net.lancho_netDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tb_pedidosTableAdapter = New Lancho.Net.lancho_netDataSetTableAdapters.tb_pedidosTableAdapter()
        Me.txt_data = New System.Windows.Forms.DateTimePicker()
        Me.cmb_pagamento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_filtro = New System.Windows.Forms.Button()
        CType(Me.tb_pedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lancho_netDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_pedidosBindingSource
        '
        Me.tb_pedidosBindingSource.DataMember = "tb_pedidos"
        Me.tb_pedidosBindingSource.DataSource = Me.lancho_netDataSet
        '
        'lancho_netDataSet
        '
        Me.lancho_netDataSet.DataSetName = "lancho_netDataSet"
        Me.lancho_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tb_pedidosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Lancho.Net.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1347, 744)
        Me.ReportViewer1.TabIndex = 0
        '
        'tb_pedidosTableAdapter
        '
        Me.tb_pedidosTableAdapter.ClearBeforeFill = True
        '
        'txt_data
        '
        Me.txt_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data.Location = New System.Drawing.Point(794, 5)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(200, 20)
        Me.txt_data.TabIndex = 1
        '
        'cmb_pagamento
        '
        Me.cmb_pagamento.FormattingEnabled = True
        Me.cmb_pagamento.Items.AddRange(New Object() {"Dinheiro", "Cartão de Débito", "Cartão de Crédito", "Pix"})
        Me.cmb_pagamento.Location = New System.Drawing.Point(1112, 8)
        Me.cmb_pagamento.Name = "cmb_pagamento"
        Me.cmb_pagamento.Size = New System.Drawing.Size(121, 21)
        Me.cmb_pagamento.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(703, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data pedido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1025, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pagamento"
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(1260, 4)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(75, 23)
        Me.txt_filtro.TabIndex = 5
        Me.txt_filtro.Text = "filtrar"
        Me.txt_filtro.UseVisualStyleBackColor = True
        '
        'relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 744)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_pagamento)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "relatorio"
        Me.Text = "relatorio"
        CType(Me.tb_pedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lancho_netDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tb_pedidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lancho_netDataSet As Lancho.Net.lancho_netDataSet
    Friend WithEvents tb_pedidosTableAdapter As Lancho.Net.lancho_netDataSetTableAdapters.tb_pedidosTableAdapter
    Friend WithEvents txt_data As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_pagamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_filtro As System.Windows.Forms.Button
End Class
