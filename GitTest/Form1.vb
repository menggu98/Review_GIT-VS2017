Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors

Partial Public Class Form1
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        XtraMessageBox.Show("🚧 클릭 이벤트 생성(다시)", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
