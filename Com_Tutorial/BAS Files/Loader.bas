Attribute VB_Name = "Loader"
Global ExcelConnector As Object

Public Function getExcelConnector() As Object

    If ExcelConnector Is Nothing Then
        'Instantiate object
        Set ExcelConnector = CreateObject("Com_Tutorial")
    End If

    Set getExcelConnector = ExcelConnector
End Function

'This function is not part of the main Interface, so it will not work
Public Sub wont_work()
    MsgBox getExcelConnector.seeMe("test")
End Sub

'This function is part of the main Interface, so it can work
Public Sub will_work()
    MsgBox getExcelConnector.other("real test")
End Sub

'This function is part of the main Interface, so it can work
Public Sub visitor_example()
    MsgBox getExcelConnector.addEnvironment
End Sub
