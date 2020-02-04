import sys
import os
import subprocess
import shutil
#import Tkinter
#import tkFileDialog
import re

"""directory="C:\Users\Dell\Desktop\œ¹æ Ÿ¿\p.1231/725"""
directory=os.path.normpath(" ".join(sys.argv[1:]))
print sys.argv[1]
print(directory)
typlist=["Sprawozdanie techniczne","Protokol","Szkice","Raporty","Inne","_all"]
typdic={"Sprawozdanie techniczne":"01","Protokol":"02","Szkice":"03","Raporty":"04","Inne":"05"}
typlistfull=["Sprawozdanie techniczne","Protokol","Szkice","Raporty","Inne","_all"]

#################################wybór directory
"""root = Tkinter.Tk()
root.withdraw() #use to hide tkinter window

currdir = os.getcwd()
tempdir = tkFileDialog.askdirectory(parent=root, initialdir=currdir, title='Please select a directory')
if len(tempdir) > 0:
    print "You chose %s" % tempdir
directory=tempdir"""
##################################

def resource_path(relative):
    if hasattr(sys, "_MEIPASS"):
        return os.path.join(sys._MEIPASS, relative)
    return os.path.join(relative)

def MergePdf(path):
    if not os.path.exists(path+"//_zrobione//"):
        os.makedirs(path+"//_zrobione//")
    listaplikow=sorted(os.listdir(path))
    print listaplikow
    start= path+"\\"+listaplikow[0]
    shutil.copyfile(path+"//"+os.listdir(path)[0],path+"//_zrobione//"+os.listdir(path)[0])#kopiowanie pierwszego pliku
    iterpath = iter(listaplikow)
    next(iterpath)
    for plik in iterpath:
        if plik.endswith('.pdf'):
            shutil.copyfile(path+"//"+plik,path+"//_zrobione//"+plik)
            plik= path+"//"+plik
            filename = "cpdf.exe"
            #print([resource_path(os.path.join(os.path.dirname(os.path.abspath(sys.argv[0])), filename)),"-merge",start,plik,"-o",start])
            subprocess.call([resource_path(os.path.join(os.path.dirname(os.path.abspath(sys.argv[0])), filename)),"-merge",start,plik,"-o",start])
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
            elif nfiles==1 and not "_zrobione" in os.listdir(path[0]):
                print("pojedynczy plik w:",path[0])
                os.rename(path[0]+"//"+os.listdir(path[0])[0],path[0]+"//"+"P.pdf")
    for path in os.walk(os.path.normpath(directory)):
        string=str(path[0]).replace("/","\\")
        splt=string.split("\\")
        #print (path[0],splt[-1])
        if "P." in str(splt[-1]):
            i=0
        if not "_zrobione" in splt:
            for typ in typlistfull:
                if typ in splt:
                    for filename in os.listdir(path[0]):
                        if filename.endswith(".pdf")and typ=="_all":
                            #shutil.copyfile(path[0]+"//"+filename,splt[-2]+"_"+str(i)+"_"+splt[-1]+".pdf")
                            shutil.copyfile(path[0]+"//"+filename,re.sub(splt[-1],'',path[0])+"//"+splt[-2]+".pdf")#nazewnictwo pliku calosciowego
                            #os.remove(path[0]+"//"+"P.pdf")
                        elif filename.endswith(".pdf"):
                            #print(splt)
                            shutil.copyfile(path[0]+"//"+filename,re.sub(splt[-1],'',path[0])+"//"+splt[-2]+"_"+typdic[splt[-1]]+".pdf")#nazwenictwo plikow z katalogow
                            #os.remove(path[0]+"//"+"P.pdf")
    
except Exception as ex:
    print ex
    raw_input


print("Wykonane...")
raw_input('Naciœnij ENTER aby zakoñczyæ')


