Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim one As String
        Dim other As String
        one = txtSideOne.Text
        other = txtSideTwo.Text


        txtHyp.Text = TriCalc(one, other)

    End Sub

    Function TriCalc(ByVal one As String, ByVal other As String) As String
        Dim oneNum As Double
        Dim otherNum As Double
        Dim hyp As Double
        Dim hypStr As String
        oneNum = CDbl(one)
        otherNum = CDbl(other)
        hyp = Math.Sqrt(oneNum ^ 2 + otherNum ^ 2)
        hypStr = CStr(hyp)
        Return hypStr
    End Function
End Class
