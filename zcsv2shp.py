# convert well known text to geometry, and compile shapes into a single feature class...
# 11/15/2012
import arcpy
import Tkinter, Tkconstants, tkFileDialog
from Tkinter import *

root = Tk()
root.baselink = tkFileDialog.askopenfilename(initialdir = "/",title = "Select CSV",filetypes = (('Comma Separated values', '*.csv'),("all files","*.*")))
root.shplink = tkFileDialog.asksaveasfilename(initialdir = "/",title = "Select SHP name",defaultextension = ".shp",filetypes = (('Shapefile', '*.shp'),))
print (root.baselink)

#File = r"C:\Users\Dell\Desktop\skrypty\mz.csv"

# dimension the WKT string field and poly ID field...
# the field holding the WKT string...
field1 = "wkt"
# the field holding the unique ID...
field2 = "id"

# set up the empty list...
featureList = []

# set the spatial reference to a known EPSG code...
sr = arcpy.SpatialReference(2177)
# iterate on table row...
cursor = arcpy.SearchCursor(root.baselink)
row = cursor.next()
print ('lama')
while row:
    print (row.getValue(field2))
   
    WKT = row.getValue(field1)
    # this is the part that converts the WKT string to geometry using the defined spatial reference...
    temp = arcpy.FromWKT(WKT, sr)
    # append the current geometry to the list...
    featureList.append(temp)

    row = cursor.next()
   
# copy all geometries in the list to a feature class...
arcpy.CopyFeatures_management(featureList, root.shplink)   

# clean up...
del row, temp, WKT, root.baselink, field1, featureList, cursor
