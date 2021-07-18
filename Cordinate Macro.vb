subCATMain()

dim dXY(1)
dim sSelType(0)

set oDoc = CATIA.ActiveDocument
set oSel = oDoc.Selection
oSel.Clear
sSelType(0) = "Point2D"
sSelStatus = oSel.IndicateOrSelectElement2D("Select a point or click", _
sSelType, false, false, false, bObjSelected, dXY)
if sSelStatus = "Normal" then
if bObjSelected then
'An existing point was selected, get its coordinates
set oPoint = oSel.Item(1).Value
oPoint.GetCoordinates dXY
end if
end if
oSel.Clear
msgbox dXY(0) & "," & dXY(1)

end sub