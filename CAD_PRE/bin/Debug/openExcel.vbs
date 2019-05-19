Dim xlApp 
Dim xlBook 

Set xlApp = CreateObject("Excel.Application") 
xlApp.Visible = True

If WScript.Arguments(0) = "status" Then
  Set xlBook = xlApp.Workbooks.Open("\\cenfile1\police$\Dispatching disk\databases\Status Check Sheet\Status_Checker_2.0b.xlsm", 0, True) 
  xlApp.Run "Fill_Sheet"
ElseIf WScript.Arguments(0) = "sched" Then
  Set xlBook = xlApp.Workbooks.Open("\\oprhp-smb\oprhp_shared\park police\Midstate\Schedules\" & WScript.Arguments(1), 0, True)
ElseIf WScript.Arguments(0) = "SSG" Then
  Set xlBook = xlApp.Workbooks.Open("\\cenfile1\police$\Dispatching disk\databases\TEST AREA\2015 SHIFT WORKSHEET - Changes.xls", 0, True) 
  xlApp.Run "Fill_Sheet"
ElseIf WScript.Arguments(0) = "hazmat" Then
  Set xlBook = xlApp.Workbooks.Open("P:\Dispatching disk\Other Resources\ERG2012.xls", 0, True) 
End If


