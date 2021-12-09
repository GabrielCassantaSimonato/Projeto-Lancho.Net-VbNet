Public Class gerenciar_estoque

    Private Sub gerenciar_estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_tipo_produto_dgv()
    End Sub

  

    Private Sub txt_buscar_produto_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_produto.TextChanged
        Try
            sql = "select * from tb_produtos where " & cmb_tipo_produto_dgv.Text & " like'" & txt_buscar_produto.Text & "%'order by produto asc"
            rs = db.Execute(sql)
            With dgv_dados_produtos
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value,rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    
    Private Sub dgv_dados_produtos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_produtos.CellContentClick

        Try
            With dgv_dados_produtos
                If .CurrentRow.Cells(7).Selected = True Then
                    aux_id = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_produtos where id='" & aux_id & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        cadastro_produtos.Show()
                        mostrar_descicao()
                        cadastro_produtos.txt_opcao.Enabled = True
                        cadastro_produtos.cmb_produto.Enabled = True
                        cadastro_produtos.txt_id.Enabled = False
                        cadastro_produtos.txt_id.Text = rs.Fields(0).Value
                        cadastro_produtos.txt_opcao.Text = rs.Fields(1).Value
                        cadastro_produtos.cmb_produto.Text = rs.Fields(2).Value
                        cadastro_produtos.cmb_sabor.Text = rs.Fields(3).Value
                        cadastro_produtos.txt_qtd.Text = rs.Fields(4).Value
                        cadastro_produtos.txt_data_validade.Text = rs.Fields(5).Value
                        cadastro_produtos.img_foto.Load(rs.Fields(6).Value)
                    End If
                ElseIf .CurrentRow.Cells(8).Selected = True Then
                    aux_id = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir o" + vbNewLine & _
                                  "Produto de ID: " & aux_id & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "Delete from tb_produtos where id='" & aux_id & "'"
                        rs = db.Execute(sql)
                        carregar_dados_produtos()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class