Public Class gerenciar_fornecedores


   
   
    Private Sub gerenciar_fornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_tipo_fornecedor_dgv()
    End Sub

    Private Sub txt_buscar_fornecedor_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_fornecedor.TextChanged
        Try
            sql = "select * from tb_fornecedores where " & cmb_tipo_fornecedor_dgv.Text & " like'" & txt_buscar_fornecedor.Text & "%'order by nome_fornecedor asc"
            rs = db.Execute(sql)
            With dgv_dados_fornecedores
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

   
    Private Sub dgv_dados_fornecedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_fornecedores.CellContentClick
        Try
            With dgv_dados_fornecedores
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_cnpj = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_fornecedores where cnpj='" & aux_cnpj & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        cadastro_fornecedores.Show()
                        cadastro_fornecedores.txt_id.Text = rs.Fields(0).Value
                        cadastro_fornecedores.txt_cnpj.Text = rs.Fields(1).Value
                        cadastro_fornecedores.txt_data_entrega.Text = rs.Fields(2).Value
                        cadastro_fornecedores.txt_nome.Text = rs.Fields(3).Value
                        cadastro_fornecedores.txt_cep.Text = rs.Fields(4).Value
                        cadastro_fornecedores.txt_endereco.Text = rs.Fields(5).Value
                        cadastro_fornecedores.txt_cidade.Text = rs.Fields(6).Value
                        cadastro_fornecedores.txt_bairro.Text = rs.Fields(7).Value
                        cadastro_fornecedores.txt_uf.Text = rs.Fields(8).Value
                        cadastro_fornecedores.txt_complemento.Text = rs.Fields(9).Value
                        cadastro_fornecedores.txt_comercial.Text = rs.Fields(10).Value
                        cadastro_fornecedores.txt_celular.Text = rs.Fields(11).Value
                        cadastro_fornecedores.txt_email.Text = rs.Fields(12).Value
                        cadastro_fornecedores.img_foto.Load(rs.Fields(13).Value)
                    End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux_cnpj = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir o" + vbNewLine & _
                                  "CNPJ: " & aux_cnpj & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "Delete from tb_fornecedores where cnpj='" & aux_cnpj & "'"
                        rs = db.Execute(sql)
                        carregar_dados_fornecedores()
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