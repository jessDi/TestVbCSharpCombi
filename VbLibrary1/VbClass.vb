Option Explicit On

Public Class VbClass

    Public Shared Function getSelection() As String
        Dim test As String = "x"
        'Dim test As String = ""

        test = CStr(IIf(test = "x", "test is x", "test is not x"))

        Return test

    End Function

    Public Shared Function getSelection2() As String
        Dim test As String = "x"
        'Dim test As String = ""

        Return test

    End Function

End Class
