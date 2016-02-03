Global ExcelConnector As Object

Public Function getExcelConnector() As Object

    If ExcelConnector Is Nothing Then
'Instantiate object
Set ExcelConnector = CreateObject("Com_Tutorial.MainClass")
End If

Set getExcelConnector = ExcelConnector
End Function

Public Sub test()
    MsgBox getExcelConnector.seeMe("test")
End Sub
