Public Class MenuUtama
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMaximized_Click(sender As Object, e As EventArgs) Handles btnMaximized.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = True
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = False

        ' tampilan panel
        pnlData.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = True
        pnlLainnya.Visible = False
        pnlTentang.Visible = False
    End Sub

    Private Sub btnLainnya_Click(sender As Object, e As EventArgs) Handles btnLainnya.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = True
        lblSelected5.Visible = False
        lblSelected6.Visible = False

        ' tampilan panel
        pnlData.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnlLainnya.Visible = True
        pnlTentang.Visible = False
    End Sub

    Private Sub btnTentang_Click(sender As Object, e As EventArgs) Handles btnTentang.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = True
        lblSelected6.Visible = False

        ' tampilan panel
        pnlData.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnlLainnya.Visible = False
        pnlTentang.Visible = True
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = True

        ' tampilan panel
        pnlData.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnlLainnya.Visible = False
        pnlTentang.Visible = False
        pnlLogout.Visible = True
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = True
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = False

        ' tampilan panel
        pnlData.Visible = False
        pnlTransaksi.Visible = True
        pnlLaporan.Visible = False
        pnlLainnya.Visible = False
        pnlTentang.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnData.Click
        lblSelected1.Visible = True
        lblSelected2.Visible = False
        lblSelected3.Visible = False
        lblSelected4.Visible = False
        lblSelected5.Visible = False
        lblSelected6.Visible = False

        ' tampilan panel
        pnlData.Visible = True
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnlLainnya.Visible = False
        pnlTentang.Visible = False
    End Sub
