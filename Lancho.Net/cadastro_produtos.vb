Public Class cadastro_produtos

    Dim teste As String
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

    
   
    Private Sub rb_salgados_CheckedChanged(sender As Object, e As EventArgs) Handles rb_salgados.CheckedChanged
        Try
            If rb_salgados.Checked = True Then
                txt_opcao.Enabled = True
                txt_opcao.Text = "Salgados"
                cmb_produto.Enabled = True
                cmb_produto.Text = ""
                cmb_sabor.Text = ""
                cmb_sabor.Visible = False
                PictureBox5.Visible = False
                cmb_produto.Items.Clear()
                cmb_produto.Items.Add("ESFIHA")
                cmb_produto.Items.Add("COXINHA")
                cmb_produto.Items.Add("PIZZA")
                cmb_produto.Items.Add("FRANGO FRITO")
                cmb_produto.Items.Add("ENROLADINHO")
                cmb_produto.Items.Add("PASTEL")
                cmb_produto.Items.Add("FOGAZZA")
                cmb_produto.Items.Add("CROISSANT")
                cmb_produto.Items.Add("LANCHE NATURAL")
                cmb_produto.Items.Add("LANCHES ARTESANAIS")



            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar combobox", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub rb_doces_CheckedChanged(sender As Object, e As EventArgs) Handles rb_doces.CheckedChanged
        Try
            If rb_doces.Checked = True Then
                txt_opcao.Enabled = True
                txt_opcao.Text = "Doces"
                cmb_produto.Enabled = True
                cmb_produto.Text = ""
                cmb_sabor.Text = ""
                cmb_sabor.Visible = False
                PictureBox5.Visible = False
                cmb_produto.Items.Clear()
                cmb_produto.Items.Add("BRIGADEIRO")
                cmb_produto.Items.Add("PUDIM")
                cmb_produto.Items.Add("BOLO")
                cmb_produto.Items.Add("SORVETE(PICOLÉ)")


            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar combobox", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


    Private Sub cmb_salgado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_produto.SelectedIndexChanged
        Try
            If cmb_produto.Text = "COXINHA" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Frango")
                cmb_sabor.Items.Add("Frango c/Catupiry")
                cmb_sabor.Items.Add("Bacalhau")
            ElseIf cmb_produto.Text = "ESFIHA" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Carne")
                cmb_sabor.Items.Add("Calabresa")
                cmb_sabor.Items.Add("Frango")
                cmb_sabor.Items.Add("Queijo")
                cmb_sabor.Items.Add("Ricota")
                cmb_sabor.Items.Add("Queijo c/ Zatar")
            ElseIf cmb_produto.Text = "FRANGO FRITO" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("A Passarinho")
                cmb_sabor.Items.Add("À Milanesa")
            ElseIf cmb_produto.Text = "PIZZA" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Mussarela")
                cmb_sabor.Items.Add("Calabresa")
                cmb_sabor.Items.Add("Atum c/ Mussarela")
                cmb_sabor.Items.Add("Escarola")
                cmb_sabor.Items.Add("Portuguesa")
            ElseIf cmb_produto.Text = "ENROLADINHO" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Presunto e queijo")
                cmb_sabor.Items.Add("Calabresa")
                cmb_sabor.Items.Add("Salsicha")
                cmb_sabor.Items.Add("Ricota c/espinafre")
                cmb_sabor.Items.Add("Bauru")
            ElseIf cmb_produto.Text = "PASTEL" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Carne")
                cmb_sabor.Items.Add("Queijo")
                cmb_sabor.Items.Add("Pizza")
                cmb_sabor.Items.Add("Palmito")
                cmb_sabor.Items.Add("Calabresa c/ queijo")
                cmb_sabor.Items.Add("Calabresa c/ Catupiry")
                cmb_sabor.Items.Add("Frango")
                cmb_sabor.Items.Add("Frango c/ Catupiry")
                cmb_sabor.Items.Add("4 Queijos")
            ElseIf cmb_produto.Text = "FOGAZZA" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Frango")
                cmb_sabor.Items.Add("Queijo")
                cmb_sabor.Items.Add("Pizza")
                cmb_sabor.Items.Add("Calabresa")
            ElseIf cmb_produto.Text = "CROISSANT" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Presunto e queijo")
                cmb_sabor.Items.Add("Pizza")
                cmb_sabor.Items.Add("Frango c/catupiry")
                cmb_sabor.Items.Add("Calabresa")
            ElseIf cmb_produto.Text = "LANCHE NATURAL" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Patê de Atum")
                cmb_sabor.Items.Add("Salpicão de Frango")
                cmb_sabor.Items.Add("Presunto e Queijo")
                cmb_sabor.Items.Add("Vegano")
            ElseIf cmb_produto.Text = "LANCHES ARTESANAIS" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("X-BURGUER")
                cmb_sabor.Items.Add("X-SALADA")
                cmb_sabor.Items.Add("X-EGG")
                cmb_sabor.Items.Add("X-MAX")
                cmb_sabor.Items.Add("X-TUDO")
                cmb_sabor.Items.Add("X-BACON")
            ElseIf cmb_produto.Text = "BRIGADEIRO" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Com morango")
                cmb_sabor.Items.Add("Com leite ninho")
                cmb_sabor.Items.Add("Com Nutella")
                cmb_sabor.Items.Add("Com coco")
            ElseIf cmb_produto.Text = "PUDIM" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Leite Condensado")
                cmb_sabor.Items.Add("Chocolate")
                cmb_sabor.Items.Add("Coco")
                cmb_sabor.Items.Add("Frutas Vermelhas")
            ElseIf cmb_produto.Text = "BOLO" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Chocolate")
                cmb_sabor.Items.Add("Morango c/ Leite Condensado")
                cmb_sabor.Items.Add("Prestígio")
                cmb_sabor.Items.Add("Cenoura")
                cmb_sabor.Items.Add("Brownie")
            ElseIf cmb_produto.Text = "SORVETE(PICOLÉ)" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Milho-Kibon")
                cmb_sabor.Items.Add("Chocolate-Kibon")
                cmb_sabor.Items.Add("Brigadeiro-Kibon")
                cmb_sabor.Items.Add("Morango-Kibon")
                cmb_sabor.Items.Add("Limão-Kibon")
                cmb_sabor.Items.Add("Tablito-Kibon")
                cmb_sabor.Items.Add("Açai-Kibon")
                cmb_sabor.Items.Add("Carioca-Kibon")
                cmb_sabor.Items.Add("Napolitano-Kibon")
                cmb_sabor.Items.Add("Paçoca-Kibon")
                cmb_sabor.Items.Add("Eskibon-Kibon")
                cmb_sabor.Items.Add("Chikabon-Kibon")
            ElseIf cmb_produto.Text = "COCA-COLA" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("ks")
                cmb_sabor.Items.Add("350ML")
                cmb_sabor.Items.Add("600ML")
                cmb_sabor.Items.Add("1.5L")
            ElseIf cmb_produto.Text = "DOLLY" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("350ML")
                cmb_sabor.Items.Add("2L")
            ElseIf cmb_produto.Text = "CERVEJA" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("HEINEKEN-350ML")
                cmb_sabor.Items.Add("SKOL-350ML")
                cmb_sabor.Items.Add("ORIGINAL-350ML")
                cmb_sabor.Items.Add("BRAHMA-350ML")
                cmb_sabor.Items.Add("HEINEKEN-600ML")
                cmb_sabor.Items.Add("SKOL-600ML")
                cmb_sabor.Items.Add("BRAHMA-600ML")
            ElseIf cmb_produto.Text = "GUARANÁ" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("ks")
                cmb_sabor.Items.Add("350ML")
                cmb_sabor.Items.Add("600ML")
                cmb_sabor.Items.Add("1.5L")
            ElseIf cmb_produto.Text = "SODA" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("ks")
                cmb_sabor.Items.Add("350ML")
                cmb_sabor.Items.Add("600ML")
                cmb_sabor.Items.Add("1.5L")
            ElseIf cmb_produto.Text = "TUBAÍNA" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("ks")
                cmb_sabor.Items.Add("350ML")
                cmb_sabor.Items.Add("600ML")
                cmb_sabor.Items.Add("1.5L")
            ElseIf cmb_produto.Text = "SUCOS NATURAIS" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Abacaxi")
                cmb_sabor.Items.Add("Abacaxi c / Hortelã")
                cmb_sabor.Items.Add("Laranja")
                cmb_sabor.Items.Add("Maracujá")
                cmb_sabor.Items.Add("Goiaba")
                cmb_sabor.Items.Add("Limão")
                cmb_sabor.Items.Add("Acerola")
                cmb_sabor.Items.Add("Caju")
            ElseIf cmb_produto.Text = "CAFÉ" Then
                mostrar_descicao()
                cmb_sabor.Items.Clear()
                cmb_sabor.Items.Add("Expresso")
                cmb_sabor.Items.Add("C/Leite")
                cmb_sabor.Items.Add("Pingado")
                
                


            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar combobox", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


    Private Sub rb_bebidas_CheckedChanged(sender As Object, e As EventArgs) Handles rb_bebidas.CheckedChanged
        Try
            If rb_bebidas.Checked = True Then
                txt_opcao.Enabled = True
                txt_opcao.Text = "Bebidas"
                cmb_produto.Enabled = True
                cmb_produto.Text = ""
                cmb_sabor.Text = ""
                cmb_sabor.Visible = False
                PictureBox5.Visible = False
                cmb_produto.Items.Clear()
                cmb_produto.Items.Add("CAFÉ")
                cmb_produto.Items.Add("COCA-COLA")
                cmb_produto.Items.Add("CERVEJA")
                cmb_produto.Items.Add("DOLLY")
                cmb_produto.Items.Add("GUARANÁ")
                cmb_produto.Items.Add("SODA")
                cmb_produto.Items.Add("SUCOS NATURAIS")
                cmb_produto.Items.Add("TUBAÍNA")


            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar combobox", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub cadastro_produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar_tipo()

    End Sub

    
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            If txt_id.Text = "" Or _
               txt_opcao.Text = "" Or _
               cmb_produto.Text = "" Or _
               cmb_sabor.Text = "" Or _
              txt_qtd.Text = "" Or _
               txt_data_validade.Text = "" Then

                MsgBox("Preencha todos os campos do formulário!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else

                sql = "select * from tb_produtos where id='" & txt_id.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "update tb_produtos set opcao_escolhida='" & txt_opcao.Text & "'," & _
                                                  "produto= '" & cmb_produto.Text & "'," & _
                                                  "descricao= '" & cmb_sabor.Text & "'," & _
                                                  "quantidade= '" & txt_qtd.Text & "'," & _
                                                  "data_validade_produto= '" & txt_data_validade.Text & "'," & _
                                                  "foto_produto= '" & diretorio & "' where id= '" & txt_id.Text & "'"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                Else
                    sql = "insert into tb_produtos values ('" & txt_id.Text & "', " & _
                                                      "'" & txt_opcao.Text & "', " & _
                                                      "'" & cmb_produto.Text & "', " & _
                                                      "'" & cmb_sabor.Text & "', " & _
                                                      "'" & txt_qtd.Text & "', " & _
                                                      "'" & txt_data_validade.Text & "', " & _
                                                      "'" & diretorio & "')"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                End If
                limpar_cadastro_produtos()
                carregar_dados_produtos()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar o código!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")


        End Try
    End Sub

 
    Private Sub txt_id_DoubleClick(sender As Object, e As EventArgs) Handles txt_id.DoubleClick
        limpar_cadastro_produtos()
    End Sub

    Private Sub txt_id_LostFocus(sender As Object, e As EventArgs) Handles txt_id.LostFocus
        Try
            sql = "select * from tb_produtos where id='" & txt_id.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_qtd.Focus()
            Else
                mostrar_descicao()
                txt_opcao.Enabled = True
                cmb_produto.Enabled = True
                txt_opcao.Text = rs.Fields(1).Value
                cmb_produto.Text = rs.Fields(2).Value
                cmb_sabor.Text = rs.Fields(3).Value
                txt_qtd.Text = rs.Fields(4).Value
                txt_data_validade.Text = rs.Fields(5).Value
                img_foto.Load(rs.Fields(6).Value)
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