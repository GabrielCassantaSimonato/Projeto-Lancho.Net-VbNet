Public Class login

 
    Private Sub btn_criar_conta_Click(sender As Object, e As EventArgs) Handles btn_criar_conta.Click
        Try
            If txt_nome_usuario.Text = "" Or _
               txt_email.Text = "" Or _
               txt_senha_usuario.Text = "" Or _
               txt_repetir_senha.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            else

            sql = "select * from tb_login where usuario='" & txt_nome_usuario.Text & "' or email='" & txt_email.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Conta já cadastrada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_nome_usuario.Clear()
                txt_email.Clear()
                txt_senha_usuario.Clear()
                txt_repetir_senha.Clear()
                txt_nome_usuario.Focus()
                Exit Sub
            Else
                If txt_senha_usuario.Text <> txt_repetir_senha.Text Then
                    MsgBox("Senhas não congruentes!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    Exit Sub
                End If
                gerar_id_conta()
                sql = "insert into tb_login values(" & id_conta & ", '" & txt_nome_usuario.Text & "', '" & txt_email.Text & "','" & txt_senha_usuario.Text & "', 'ATIVA')"
                rs = db.Execute(sql)
                MsgBox("Conta criada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_nome_usuario.Clear()
                txt_email.Clear()
                txt_senha_usuario.Clear()
                txt_repetir_senha.Clear()
                    txt_nome_usuario.Focus()
                    carregar_login()

            End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao criar a conta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub chk_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles chk_visualizar.CheckedChanged
        If txt_senha_usuario.PasswordChar = "•" Or txt_repetir_senha.PasswordChar = "•" Then
            txt_senha_usuario.PasswordChar = ""
            txt_repetir_senha.PasswordChar = ""
        Else
            txt_senha_usuario.PasswordChar = "•"
            txt_repetir_senha.PasswordChar = "•"
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco() 'dps trocar esse comando para a tela da progress bar!!!
        carregar_dados_clientes() 'dps trocar esse comando para a tela da progress bar!!!
        carregar_dados_fornecedores() 'dps trocar esse comando para a tela da progress bar!!!
        carregar_dados_produtos() 'dps trocar esse comando para a tela da progress bar!!!
        carregar_login() 'dps trocar esse comando para a tela da progress bar!!!
        lbl_link.Visible = False
        If TabControl1.TabPages.Contains(TabPage2) And TabControl1.TabPages.Contains(TabPage3) Then
            TabControl1.TabPages.Remove(TabPage2)
            TabControl1.TabPages.Remove(TabPage3)

        End If
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_usuario.Text = "Admin" And txt_senha.Text = "admin123" Then
                MsgBox("Administrador logado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                TabControl1.TabPages.Add(TabPage2)
                TabControl1.TabPages.Add(TabPage3)
                lbl_link.Visible = True
                txt_usuario.Text = ""
                txt_senha.Text = ""
                Form1.Show()
                With Form1
                    .Label3.Text = "Bem vindo administrador!"
                End With
                Exit Sub
            End If
            sql = "select * from tb_login where (usuario='" & txt_usuario.Text & "' or email= '" & txt_usuario.Text & "') and senha= '" & txt_senha.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Conta logada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                nome = txt_usuario.Text
                With Form1
                    .Label3.Text = "Bem vindo(a) " & nome & "!"
                End With
                Form1.Show()
                ocultar_gerenciamento()
                Me.Hide()


            Else
                MsgBox("Conta inválida!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao entrar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub lbl_link_Click(sender As Object, e As EventArgs) Handles lbl_link.Click
        If TabControl1.TabPages.Contains(TabPage2) And TabControl1.TabPages.Contains(TabPage3) Then
            TabControl1.TabPages.Remove(TabPage2)
            TabControl1.TabPages.Remove(TabPage3)
            lbl_link.Visible = False
        End If
    End Sub

    Private Sub dgv_login_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_login.CellContentClick
        Try
            With dgv_login
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_usuario = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir o" + vbNewLine & _
                                  "Usuário: " & aux_usuario & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "Delete from tb_login where usuario='" & aux_usuario & "'"
                        rs = db.Execute(sql)
                        carregar_login()
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