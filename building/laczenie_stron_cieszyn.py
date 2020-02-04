import sys
import os
import subprocess
import shutil
import Tkinter
import tkFileDialog
import re

directory=os.path.abspath(sys.argv[1])#wlaczyc jak potrzeba do pdftry
#print(directory)
taglist=["GESUT","SYT"]
"""
#################################wybór directory
root = Tkinter.Tk()
root.withdraw() #use to hide tkinter window

currdir = os.getcwd()
tempdir = tkFileDialog.askdirectory(parent=root, initialdir=currdir, title='Please select a directory')
if len(tempdir) > 0:
    print "You chose %s" % tempdir
directory=tempdir
##################################"""

def resource_path(relative):
    if hasattr(sys, "_MEIPASS"):
        return os.path.join(sys._MEIPASS, relative)
    return os.path.join(relative)



#print([x[0] for x in os.walk(directory)])
listapath=[]
try:
    for path in os.walk(directory):
        listapath.append(path[0])
    print (listapath)
    
except Exception as ex:
    print ex
    raw_input


print("Wykonane...")
raw_input('Naciœnij ENTER aby zakoñczyæ')


