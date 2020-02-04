
sub lama
rem ----------------------------------------------------------------------
rem define variables
dim n As Long, i as Long
Dim sFileName As String
Dim sPath As String
Dim sSaveToURL as string
dim document   as object
dim dispatcher as object
rem ----------------------------------------------------------------------
rem get access to the document
document   = ThisComponent.CurrentController.Frame
dispatcher = createUnoService("com.sun.star.frame.DispatchHelper")

rem ----------------------------------------------------------------------
dim args2(0) as new com.sun.star.beans.PropertyValue
args2(0).Name = "ToPoint"
args2(0).Value = "$A$1"

dispatcher.executeDispatch(document, ".uno:GoToCell", "", 0, args2())
dispatcher.executeDispatch(document, ".uno:InsertColumns", "", 0, Array())
dim args3(0) as new com.sun.star.beans.PropertyValue

args3(0).Name = "StringName"
args3(0).Value ="=MID(CELL("+CHR$(34)+"filename"+CHR$(34)+");FIND("+CHR$(34)+"/o"+CHR$(34)+";CELL("+CHR$(34)+"filename"+CHR$(34)+"))+1;8)" 'ostatnia cyfra to dlugosc docelowej nazwy i trza zmienic litere w nazwie


dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args3())

dispatcher.executeDispatch(document, ".uno:JumpToNextCell", "", 0, Array())

n=LastRowWithData(3,0)
for i =1 to n
	args3(0).Name = "StringName"
	'args3(0).Value = "=MID(CELL("+CHR$(34)+"filename"+CHR$(34)+");SEARCH("+CHR$(34)+"["+CHR$(34)+";CELL("+CHR$(34)+"filename"+CHR$(34)+"))+1; SEARCH("+CHR$(34)+"]"+CHR$(34)+";CELL("+CHR$(34)+"filename"+CHR$(34)+"))-SEARCH("+CHR$(34)+"["+CHR$(34)+";CELL("+CHR$(34)+"filename"+CHR$(34)+"))-5)"
	'args3(0).Value ="=MID(CELL("+CHR$(34)+"filename"+CHR$(34)+");FIND("+CHR$(34)+"/o"+CHR$(34)+";CELL("+CHR$(34)+"filename"+CHR$(34)+"))+1;9)" 'ostatnia cyfra to dlugosc docelowej nazwy i trza zmienic litere w nazwie
	args3(0).Value ="=MID(CELL("+CHR$(34)+"filename"+CHR$(34)+");FIND("+CHR$(34)+"/o"+CHR$(34)+";CELL("+CHR$(34)+"filename"+CHR$(34)+"))+1;9)" 'ostatnia cyfra to dlugosc docelowej nazwy i trza zmienic litere w nazwie


	dispatcher.executeDispatch(document, ".uno:EnterString", "", 0, args3())

rem ----------------------------------------------------------------------
	dispatcher.executeDispatch(document, ".uno:JumpToNextCell", "", 0, Array())
	next i


sPath = "C:\wynik\"
sFileName = thisComponent.getSheets.getByName("Arkusz1").getCellRangeByName("A1").getString
sFileName=sFileName+".csv"
sSaveToURL = ConvertToURL(sPath & sFileName)


rem ----------------------------------------------------------------------
dim args7(2) as new com.sun.star.beans.PropertyValue
args7(0).Name = "URL"
args7(0).Value = sSaveToURL
args7(1).Name = "FilterName"
args7(1).Value = "Text - txt - csv (StarCalc)"
args7(2).Name = "FilterOptions"
args7(2).Value = Asc(";") & "," & Asc("""") & ",0,1"

ThisComponent.storeToURL( sSaveToURL, args7 ) 
'dispatcher.executeDispatch(document, ".uno:SaveAs", "", 0, args7())
ThisComponent.close(True)

End Sub


'------------------------------------------------------------------------
Function LastRowWithData (ColumnIndex as long, SheetIndex as long) as long
   Dim oCursor As Object, oRange As Object, oSheet As Object
   Dim LastRowOfUsedArea as long, R as long
   Dim RangeData

   oSheet = ThisComponent.Sheets(SheetIndex)
   oCursor = oSheet.createCursor
   oCursor.gotoEndOfUsedArea(False)
   LastRowOfUsedArea = oCursor.RangeAddress.EndRow
   oRange = oSheet.getCellRangeByPosition(ColumnIndex, 0, ColumnIndex, LastRowOfUsedArea)
   oCursor = oSheet.createCursorByRange(oRange)
   RangeData = oCursor.getDataArray

   For R = UBound(RangeData) To LBound(RangeData) Step - 1
       If RangeData(R)(0) <> "" then
          LastRowWithData = R
          Exit Function
       End If
   Next
End Function
'------------------------------------------------------------------------
