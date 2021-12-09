Public Class relatorio

    Private Sub relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'lancho_netDataSet.tb_pedidos' table. You can move, or remove it, as needed.
        
    End Sub

    Private Sub txt_filtro_Click(sender As Object, e As EventArgs) Handles txt_filtro.Click
        Me.tb_pedidosTableAdapter.Pedidos(Me.lancho_netDataSet.tb_pedidos, txt_data.Text, cmb_pagamento.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class