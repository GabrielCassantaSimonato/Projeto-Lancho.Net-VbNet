Public Class cadastro_fornecedores

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\Imagens"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            If txt_cnpj.Text = "" Or _
               txt_data_entrega.Text = "" Or _
               txt_nome.Text = "" Or _
               txt_cep.Text = "" Or _
               txt_endereco.Text = "" Or _
               txt_complemento.Text = "" Or _
               txt_bairro.Text = "" Or _
               txt_email.Text = "" Or _
               txt_cidade.Text = "" Or _
               txt_celular.Text = "" Or _
               txt_uf.Text = "" Or _
               txt_comercial.Text = "" Then

                MsgBox("Preencha todos os campos do formulário!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else

                sql = "select * from tb_fornecedores where cnpj='" & txt_cnpj.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "update tb_fornecedores set data_entrega='" & txt_data_entrega.Text & "'," & _
                                                  "nome_fornecedor= '" & txt_nome.Text & "'," & _
                                                  "cep_fornecedor= '" & txt_cep.Text & "'," & _
                                                  "endereco_fornecedor= '" & txt_endereco.Text & "'," & _
                                                  "cidade_fornecedor= '" & txt_cidade.Text & "'," & _
                                                  "bairro_fornecedor= '" & txt_bairro.Text & "'," & _
                                                  "uf_fornecedor= '" & txt_uf.Text & "'," & _
                                                  "complemento_fornecedor= '" & txt_complemento.Text & "'," & _
                                                  "tel_comercial= '" & txt_comercial.Text & "'," & _
                                                  "celular_fornecedor= '" & txt_celular.Text & "'," & _
                                                  "email_fornecedor= '" & txt_email.Text & "'," & _
                                                  "foto_fornecedor= '" & diretorio & "' where cnpj= '" & txt_cnpj.Text & "'"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                Else
                    sql = "insert into tb_fornecedores values ('" & txt_cnpj.Text & "', " & _
                                                      "'" & txt_data_entrega.Text & "', " & _
                                                      "'" & txt_nome.Text & "', " & _
                                                      "'" & txt_cep.Text & "', " & _
                                                      "'" & txt_endereco.Text & "', " & _
                                                      "'" & txt_cidade.Text & "', " & _
                                                      "'" & txt_bairro.Text & "', " & _
                                                      "'" & txt_uf.Text & "', " & _
                                                      "'" & txt_complemento.Text & "', " & _
                                                      "'" & txt_comercial.Text & "', " & _
                                                      "'" & txt_celular.Text & "', " & _
                                                      "'" & txt_email.Text & "', " & _
                                                      "'" & diretorio & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                End If
                limpar_cadastro_fornecedores()
                carregar_dados_fornecedores()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar o código!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")


        End Try
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            sql = "select * from tb_cep where cep='" & txt_cep.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_uf.Text = rs.Fields(4).Value
                txt_complemento.Focus()
            Else
                MsgBox("CEP " & txt_cep.Text & " não encontrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cnpj_DoubleClick(sender As Object, e As EventArgs) Handles txt_cnpj.DoubleClick
        limpar_cadastro_fornecedores()
    End Sub

    Private Sub txt_cnpj_LostFocus(sender As Object, e As EventArgs) Handles txt_cnpj.LostFocus
        Try
            sql = "select * from tb_fornecedores where cnpj='" & txt_cnpj.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_nome.Focus()
            Else
                txt_id.Text = rs.Fields(0).Value
                txt_data_entrega.Text = rs.Fields(2).Value
                txt_nome.Text = rs.Fields(3).Value
                txt_cep.Text = rs.Fields(4).Value
                txt_endereco.Text = rs.Fields(5).Value
                txt_cidade.Text = rs.Fields(6).Value
                txt_bairro.Text = rs.Fields(7).Value
                txt_uf.Text = rs.Fields(8).Value
                txt_complemento.Text = rs.Fields(9).Value
                txt_comercial.Text = rs.Fields(10).Value
                txt_celular.Text = rs.Fields(11).Value
                txt_email.Text = rs.Fields(12).Value
                img_foto.Load(rs.Fields(13).Value)

            End If
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show() 'voltar a tela inicial
        Me.Hide()
    End Sub
End Class