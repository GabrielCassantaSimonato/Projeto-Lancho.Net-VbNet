Public Class cadastro_clientes

    
   
   

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles img_foto.Click
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

    

    
    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            If txt_cpf.Text = "" Or _
               txt_data_nasc.Text = "" Or _
               txt_nome.Text = "" Or _
               txt_cep.Text = "" Or _
               txt_endereco.Text = "" Or _
               txt_complemento.Text = "" Or _
               txt_bairro.Text = "" Or _
               txt_email.Text = "" Or _
               txt_cidade.Text = "" Or _
               txt_celular.Text = "" Or _
               txt_uf.Text = "" Or _
               txt_residencial.Text = "" Then

                MsgBox("Preencha todos os campos do formulário!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else

                sql = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "update tb_clientes set data_nasc='" & txt_data_nasc.Text & "'," & _
                                                  "nome= '" & txt_nome.Text & "'," & _
                                                  "cep= '" & txt_cep.Text & "'," & _
                                                  "endereco= '" & txt_endereco.Text & "'," & _
                                                  "cidade= '" & txt_cidade.Text & "'," & _
                                                  "bairro= '" & txt_bairro.Text & "'," & _
                                                  "uf= '" & txt_uf.Text & "'," & _
                                                  "complemento= '" & txt_complemento.Text & "'," & _
                                                  "tel_residencial= '" & txt_residencial.Text & "'," & _
                                                  "celular= '" & txt_celular.Text & "'," & _
                                                  "email= '" & txt_email.Text & "'," & _
                                                  "foto= '" & diretorio & "' where cpf= '" & txt_cpf.Text & "'"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                Else
                    sql = "insert into tb_clientes values ('" & txt_cpf.Text & "', " & _
                                                      "'" & txt_data_nasc.Text & "', " & _
                                                      "'" & txt_nome.Text & "', " & _
                                                      "'" & txt_cep.Text & "', " & _
                                                      "'" & txt_endereco.Text & "', " & _
                                                      "'" & txt_cidade.Text & "', " & _
                                                      "'" & txt_bairro.Text & "', " & _
                                                      "'" & txt_uf.Text & "', " & _
                                                      "'" & txt_complemento.Text & "', " & _
                                                      "'" & txt_residencial.Text & "', " & _
                                                      "'" & txt_celular.Text & "', " & _
                                                      "'" & txt_email.Text & "', " & _
                                                      "'" & diretorio & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                End If
                limpar_cadastro_clientes()
                carregar_dados_clientes()
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

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        limpar_cadastro_clientes()
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "select * from tb_clientes where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_nome.Focus()
            Else
                txt_id.Text = rs.Fields(0).Value
                txt_data_nasc.Text = rs.Fields(2).Value
                txt_nome.Text = rs.Fields(3).Value
                txt_cep.Text = rs.Fields(4).Value
                txt_endereco.Text = rs.Fields(5).Value
                txt_cidade.Text = rs.Fields(6).Value
                txt_bairro.Text = rs.Fields(7).Value
                txt_uf.Text = rs.Fields(8).Value
                txt_complemento.Text = rs.Fields(9).Value
                txt_residencial.Text = rs.Fields(10).Value
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

    Private Sub txt_cep_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cep.MaskInputRejected

    End Sub

    
    
    
 
    
End Class