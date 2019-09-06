Imports QRCoder

Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim gen As New QRCodeGenerator
        Dim r As String = "hello"
        Dim data = gen.CreateQrCode(r, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        Pic.Image = code.GetGraphic(6)
    End Sub
End Class
