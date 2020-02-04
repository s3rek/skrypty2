from PIL import Image
import sys
import glob
import gc
import os
import Tkinter
import tkFileDialog
#path=os.path.dirname(sys.argv[0])+"\\njowy"

######################################################
root = Tkinter.Tk()
root.withdraw() #use to hide tkinter window

currdir = os.getcwd()
tempdir = tkFileDialog.askdirectory(parent=root, initialdir=currdir, title='Please select a directory')
if len(tempdir) > 0:
	print('You chose %s' % tempdir)

directory=tempdir
####################################################

def przeniesPlik(plik):

    os.rename(plik,directory+"\\_zrobione\\"+os.path.basename(plik))

def jpg2pdf(plik):

    i = Image.open(plik)
    if plik.endswith(".tif"):
        i.save(os.path.splitext(plik)[0]+".jpg", "JPEG", Quality=100,resolution=300.0)
    i.save(os.path.splitext(plik)[0]+".pdf", "PDF", Quality=100,resolution=300.0)
    del i
    gc.collect()
    przeniesPlik(plik)
    print(plik+ " - przekonwertowany")

def tiff2pdf(plik):
    with open(plik,'rb') as f:
        i = Image.open(f)
        i.save(os.path.splitext(plik)[0]+".jpg", "JPEG", Quality=100,resolution=300.0)
        del i
        gc.collect()
    przeniesPlik(plik)
    print(plik+ " - przekonwertowany")
    jpg2pdf(os.path.splitext(plik)[0]+".jpg")

def pdf2jpg(plik):
    
pliki = glob.glob("*.jpgp") + glob.glob("*.jpg")+ glob.glob("*.tiff")

try:
    os.mkdir(directory+"\\_zrobione")
except:                 
    print()

for plik in os.listdir(directory):
    if plik.endswith(".tif"):
        plik= directory+"\\"+plik
        tiff2pdf(plik)
    elif plik.endswith('.jpg'):
        plik= directory+"\\"+plik
        jpg2pdf(plik)
    else:
        pass

print("Wykonane...")
raw_input('Naci�nij ENTER aby zako�czy�')




