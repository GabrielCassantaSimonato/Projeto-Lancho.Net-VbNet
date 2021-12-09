Public Class Form1

    
   
    
   

    
    Private Sub AcessarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcessarToolStripMenuItem.Click
        System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "\politicadeprivacidade.pdf") 'Iniciar uma página externa
    End Sub

   
    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        Process.Start("excel.exe")

    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Shell("calc.exe")
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Try
            resp = MsgBox("Deseja sair do sistema?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
            If resp = MsgBoxResult.Yes Then
                End
            End If

        Catch ex As Exception
            MsgBox("Erro de solicitação", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    
    Private Sub AcessarONavegadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcessarONavegadorToolStripMenuItem.Click
        Process.Start("https://www.google.com.br/")
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        cadastro_clientes.Show() 'ir ao formulario de cadastro de clientes.
        Me.Hide() 'esconder o atual



    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        cadastro_fornecedores.Show()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        cadastro_produtos.Show()
    End Sub

    
    Private Sub EstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstoqueToolStripMenuItem.Click
        gerenciar_estoque.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        gerenciar_clientes.ShowDialog()
    End Sub

    Private Sub FornecedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem1.Click
        gerenciar_fornecedores.ShowDialog()
    End Sub

    Private Sub CardápioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CardápioToolStripMenuItem.Click
        cardapio.ShowDialog()
    End Sub

    

    Private Sub BlocoDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click
        Process.Start("notepad.exe")
    End Sub

    
    
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txt_data.Text = DateTime.Now
    End Sub

    
    
    Private Sub txt_data_Click(sender As Object, e As EventArgs) Handles txt_data.Click

    End Sub

    Private Sub RelatórioDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioDePedidosToolStripMenuItem.Click
        relatorio.ShowDialog()
    End Sub
End Class
