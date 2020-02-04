import sys
import os
import subprocess
import shutil
import Tkinter
import tkFileDialog
import re

#directory=os.path.dirname(sys.argv[0])+"\\njowy"
typlist=["szkici","mapaw","szkicb","szkics","dzpom","dzniw","spr","zglosz","wykzm"]
typlistfull=["szkici","mapaw","szkicb","szkics","dzpom","dzniw","spr","inne","zglosz","wykzm"]
i=0

#################################wybór directory
root = Tkinter.Tk()
root.withdraw() #use to hide tkinter window

currdir = os.getcwd()
tempdir = tkFileDialog.askdirectory(parent=root, initialdir=currdir, title='Please select a directory')
if len(tempdir) > 0:
    print "You chose %s" % tempdir
directory=tempdir
##################################

def resource_path(relative):
    if hasattr(sys, "_MEIPASS"):
        return os.path.join(sys._MEIPASS, relative)
    return os.path.join(relative)

def MergePdf(path):
    if not os.path.exists(path+"//_zrobione//"):
        os.makedirs(path+"//_zrobione//")
    listaplikow=sorted(os.listdir(path))
    start= path+"\\"+listaplikow[0]
    shutil.copyfile(path+"//"+os.listdir(path)[0],path+"//_zrobione//"+os.listdir(path)[0])#kopiowanie pierwszego pliku
    iterpath = iter(listaplikow)
    next(iterpath)
    for plik in iterpath:
        if plik.endswith('.pdf'):
            shutil.copyfile(path+"//"+plik,path+"//_zrobione//"+plik)
            plik= path+"//"+plik
            #subprocess.call([os.path.dirname(sys.argv[0])+"\\cpdf.exe","-merge",start,plik,"-o",start])
            filename = "cpdf.exe"
            subprocess.call([resource_path(os.path.join(os.path.dirname(sys.argv[0])+"//Data", filename)),"-merge",start,plik,"-o",start])
            #if str(plik)=="C:\Users\Dell\Desktop\\njowy\\"+str(os.listdir(path)[0]):
            os.remove(plik)
        else:
            pass
    os.rename(path+"//"+os.listdir(path)[0],path+"//"+"P.pdf")



#print([x[0] for x in os.walk(directory)])
try:
	for path in os.walk(directory):
		typdoc=os.path.basename(os.path.normpath(path[0]))
		if typdoc in typlist:
			nfiles=len([name for name in os.listdir(path[0]) if name.endswith(".pdf")])
			if nfiles>1:
				MergePdf(path[0])
	for path in os.walk(directory):
		string=str(path[0]).replace("/","\\")
		splt=string.split("\\")
		#print (path[0],splt[-1])
		if "P." in str(splt[-1]):
			i=0
		if not "_zrobione" in splt:
			for typ in typlistfull:
				if typ in splt:
					for filename in os.listdir(path[0]):
						if filename.endswith(".pdf"):
							i+=1
							#shutil.copyfile(path[0]+"//"+filename,splt[-2]+"_"+str(i)+"_"+splt[-1]+".pdf")
							shutil.copyfile(path[0]+"//"+filename,re.sub(splt[-1],'',path[0])+"//"+splt[-2]+"_"+str(i)+"_"+splt[-1]+".pdf")
except Exception as ex:
	print ex
	raw_input


print("Wykonane...")
raw_input('Naciœnij ENTER aby zakoñczyæ')


