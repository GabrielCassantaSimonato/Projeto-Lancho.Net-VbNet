Module Module1
    Public resp, diretorio As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, aux_cpf, aux_cnpj, aux_id, nome, aux_usuario As String
    Public cont, id_conta As Integer

    Sub conectar_banco()
        'tratamento de erro
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=GABRIEL-PC;Initial Catalog=lancho_net;trusted_connection=yes;")
            ' MsgBox("Conexão SQL SERVER ok!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_tipo()
        With cadastro_produtos
            .txt_opcao.Enabled = False
            .txt_opcao.Text = ""
            .rb_salgados.Checked = False
            .rb_doces.Checked = False
            .rb_bebidas.Checked = False
            .cmb_produto.Enabled = False
            .cmb_sabor.Visible = False
            .PictureBox5.Visible = False
        End With
    End Sub
    Sub mostrar_descicao()
        With cadastro_produtos
            .cmb_sabor.Visible = True
            .PictureBox5.Visible = True
        End With
    End Sub

    Sub limpar_cadastro_clientes()
        Try
            With cadastro_clientes
                .txt_id.Clear()
                .txt_cpf.Clear()
                .txt_cep.Clear()
                .txt_data_nasc.Text = Date.Now
                .txt_nome.Clear()
                .txt_endereco.Clear()
                .txt_bairro.Clear()
                .txt_uf.Clear()
                .txt_cidade.Clear()
                .txt_complemento.Clear()
                .txt_residencial.Clear()
                .txt_celular.Clear()
                .txt_email.Clear()
                .img_foto.Load(Application.StartupPath & "\Imagens\noimage.png")
                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados_clientes()
        Try
            sql = "select * from tb_clientes order by nome asc"
            rs = db.Execute(sql)
            With gerenciar_clientes.dgv_dados_clientes
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(3).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_tipo_cliente_dgv()
        With gerenciar_clientes.cmb_tipo_clientes_dgv.Items
            .Clear()
            .Add("CPF")
            .Add("NOME")
        End With
        gerenciar_clientes.cmb_tipo_clientes_dgv.SelectedIndex = 1
    End Sub

    Sub limpar_cadastro_fornecedores()
        Try
            With cadastro_fornecedores
                .txt_id.Clear()
                .txt_cnpj.Clear()
                .txt_cep.Clear()
                .txt_data_entrega.Text = Date.Now
                .txt_nome.Clear()
                .txt_endereco.Clear()
                .txt_bairro.Clear()
                .txt_uf.Clear()
                .txt_cidade.Clear()
                .txt_complemento.Clear()
                .txt_comercial.Clear()
                .txt_celular.Clear()
                .txt_email.Clear()
                .img_foto.Load(Application.StartupPath & "\Imagens\noimage.png")
                .txt_cnpj.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados_fornecedores()
        Try
            sql = "select * from tb_fornecedores order by nome_fornecedor asc"
            rs = db.Execute(sql)
            With gerenciar_fornecedores.dgv_dados_fornecedores
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_tipo_fornecedor_dgv()
        With gerenciar_fornecedores.cmb_tipo_fornecedor_dgv.Items
            .Clear()
            .Add("CNPJ")
            .Add("NOME_FORNECEDOR")
            .Add("DATA_ENTREGA")
        End With
        gerenciar_fornecedores.cmb_tipo_fornecedor_dgv.SelectedIndex = 1
    End Sub

    Sub gerar_id_conta()
        sql = "select * from tb_login order by id_conta desc "
        rs = db.Execute(sql)
        If rs.BOF = True Then
            id_conta = 1
        Else
            id_conta = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub ocultar_gerenciamento()
        With Form1
            .GerenciamentoToolStripMenuItem.Enabled = False






        End With
    End Sub

    Sub limpar_cadastro_produtos()
        Try
            With cadastro_produtos
                .txt_id.Clear()
                .rb_salgados.Checked = False
                .rb_doces.Checked = False
                .rb_bebidas.Checked = False
                .txt_opcao.Clear()
                .cmb_produto.Text = ""
                .cmb_sabor.Text = ""
                .txt_qtd.Clear()
                .txt_data_validade.Text = Date.Now
                .img_foto.Load(Application.StartupPath & "\Imagens\noimage.png")
                .txt_id.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_tipo_produto_dgv()
        With gerenciar_estoque.cmb_tipo_produto_dgv.Items
            .Clear()
            .Add("OPCAO_ESCOLHIDA")
            .Add("PRODUTO")
            .Add("DESCRICAO")
            .Add("OPCAO_ESCOLHIDA")
            .Add("QUANTIDADE")
            .Add("ID")
            .Add("DATA_VALIDADE_PRODUTO")
        End With
        gerenciar_estoque.cmb_tipo_produto_dgv.SelectedIndex = 1
    End Sub

    Sub carregar_dados_produtos()
        Try
            sql = "select * from tb_produtos order by produto asc"
            rs = db.Execute(sql)
            With gerenciar_estoque.dgv_dados_produtos
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_login()
        Try
            sql = "select * from tb_login order by usuario asc"
            rs = db.Execute(sql)
            With login.dgv_login
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Module
