Public Class gerenciar_clientes

    
  
    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            sql = "select * from tb_clientes where " & cmb_tipo_clientes_dgv.Text & " like'" & txt_busca.Text & "%'order by nome asc"
            rs = db.Execute(sql)
            With dgv_dados_clientes
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


   
    Private Sub gerenciar_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_tipo_cliente_dgv()
    End Sub

    Private Sub dgv_dados_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_clientes.CellContentClick
        Try
            With dgv_dados_clientes
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_clientes where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        cadastro_clientes.Show()
                        cadastro_clientes.txt_id.Text = rs.Fields(0).Value
                        cadastro_clientes.txt_cpf.Text = rs.Fields(1).Value
                        cadastro_clientes.txt_data_nasc.Text = rs.Fields(2).Value
                        cadastro_clientes.txt_nome.Text = rs.Fields(3).Value
                        cadastro_clientes.txt_cep.Text = rs.Fields(4).Value
                        cadastro_clientes.txt_endereco.Text = rs.Fields(5).Value
                        cadastro_clientes.txt_cidade.Text = rs.Fields(6).Value
                        cadastro_clientes.txt_bairro.Text = rs.Fields(7).Value
                        cadastro_clientes.txt_uf.Text = rs.Fields(8).Value
                        cadastro_clientes.txt_complemento.Text = rs.Fields(9).Value
                        cadastro_clientes.txt_residencial.Text = rs.Fields(10).Value
                        cadastro_clientes.txt_celular.Text = rs.Fields(11).Value
                        cadastro_clientes.txt_email.Text = rs.Fields(12).Value
                        cadastro_clientes.img_foto.Load(rs.Fields(13).Value)
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir o" + vbNewLine & _
                                  "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "Delete from tb_clientes where cpf='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        carregar_dados_clientes()
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