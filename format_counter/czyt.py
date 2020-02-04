# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'czyt.ui'
#
# Created by: PyQt4 UI code generator 4.11.4
#
# WARNING! All changes made in this file will be lost!

from PyQt4 import QtCore, QtGui
from PyPDF2 import PdfFileReader
import os
import Tkinter
import tkFileDialog
import sys, csv
import subprocess

#########################zmienne globalne
A4=500990
A3=1001980
difa4=A4+A4/2
difa3=A3+A4/2
##########################################


try:
    _fromUtf8 = QtCore.QString.fromUtf8
except AttributeError:
    def _fromUtf8(s):
        return s

try:
    _encoding = QtGui.QApplication.UnicodeUTF8
    def _translate(context, text, disambig):
        return QtGui.QApplication.translate(context, text, disambig, _encoding)
except AttributeError:
    def _translate(context, text, disambig):
        return QtGui.QApplication.translate(context, text, disambig)


class Ui_Dialog(object):
    def __init__(self):
        self.j=0


        ######Browser wskazujacy pliki
    def BrowsePDF(self):
        root = Tkinter.Tk()
        root.withdraw() #use to hide tkinter window
        currdir = os.getcwd()
        tempdir = tkFileDialog.askdirectory(parent=root, initialdir=currdir, title='Wskaz pliki')
        if len(tempdir) > 0:
            print "You chose %s" % tempdir
        self.path=tempdir
        self.ReadSizePdf(self.path)

    def Browser(self):
        self.path = QtGui.QFileDialog.getOpenFileName(Dialog, 
                                                       'Single File',
                                                       "~/Desktop/",
                                                        "tekst (*.txt)")
        return(self.path)


    def FromList(self):
        listapath=[]
        self.Browser()
        with open(str(self.path),"r") as f:
            for directory in f:
                if directory.endswith('\\'):
                    direct=directory
                else:
                    direct="\\".join(directory.split("\\")[:-1])
                listapath.append(direct)
        listapath=set(listapath)
        print(listapath)
        #print(listapath)
        for sciezka in listapath:
            print(sciezka)
            self.ReadSizePdf(sciezka)
                
        
    def setupUi(self, Dialog):
        Dialog.setObjectName(_fromUtf8("Dialog"))
        Dialog.resize(1068, 637)
        self.tableWidget = QtGui.QTableWidget(Dialog)
        self.tableWidget.setGeometry(QtCore.QRect(10, 10, 901, 611))
        self.tableWidget.setObjectName(_fromUtf8("tableWidget"))
        self.tableWidget.setColumnCount(6)
        self.tableWidget.setRowCount(1)
        item = QtGui.QTableWidgetItem()
        self.tableWidget.setHorizontalHeaderItem(0, item)
        item = QtGui.QTableWidgetItem()
        self.tableWidget.setHorizontalHeaderItem(1, item)
        item = QtGui.QTableWidgetItem()
        self.tableWidget.setHorizontalHeaderItem(2, item)
        item = QtGui.QTableWidgetItem()
        self.tableWidget.setHorizontalHeaderItem(3, item)
        item = QtGui.QTableWidgetItem()
        self.tableWidget.setHorizontalHeaderItem(4, item)
        item = QtGui.QTableWidgetItem()
        self.tableWidget.setHorizontalHeaderItem(5, item)
        self.listaButton = QtGui.QPushButton(Dialog)
        self.listaButton.setGeometry(QtCore.QRect(960, 30, 75, 23))
        self.listaButton.setObjectName(_fromUtf8("listaButton"))
        self.listaButton.clicked.connect(self.FromList)
        self.folderButton = QtGui.QPushButton(Dialog)
        self.folderButton.setGeometry(QtCore.QRect(960, 70, 75, 23))
        self.folderButton.setObjectName(_fromUtf8("pdfButton"))
        self.folderButton.clicked.connect(self.BrowsePDF)

        
        self.buttonOpen = QtGui.QPushButton(Dialog)
        self.buttonOpen.setGeometry(QtCore.QRect(960, 550, 75, 23))
        self.buttonSave = QtGui.QPushButton(Dialog)
        self.buttonSave.setGeometry(QtCore.QRect(960, 590, 75, 23))
        self.buttonOpen.clicked.connect(self.handleOpen)
        self.buttonSave.clicked.connect(self.handleSave)


        self.retranslateUi(Dialog)
        QtCore.QMetaObject.connectSlotsByName(Dialog)

        

    def retranslateUi(self, Dialog):
        Dialog.setWindowTitle(_translate("Dialog", "Dialog", None))
        item = self.tableWidget.horizontalHeaderItem(0)
        item.setText(_translate("Dialog", "Folder", None))
        item = self.tableWidget.horizontalHeaderItem(1)
        item.setText(_translate("Dialog", "A4", None))
        item = self.tableWidget.horizontalHeaderItem(2)
        item.setText(_translate("Dialog", "A3", None))
        item = self.tableWidget.horizontalHeaderItem(3)
        item.setText(_translate("Dialog", "<A3", None))
        item = self.tableWidget.horizontalHeaderItem(4)
        item.setText(_translate("Dialog", "<A3/A4", None))
        item = self.tableWidget.horizontalHeaderItem(5)
        item.setText(_translate("Dialog", "Całkowita ilość A4", None))
        self.listaButton.setText(_translate("Dialog", "z listy", None))
        self.folderButton.setText(_translate("Dialog", "wskaż folder", None))
        self.buttonOpen.setText(_translate("Dialog", "otwórz csv", None))
        self.buttonSave.setText(_translate("Dialog", "zapisz csv", None))

    def handleSave(self):
        path = QtGui.QFileDialog.getSaveFileName(
                Dialog, 'Save File', '', 'CSV(*.csv)')
        if not path.isEmpty():
            with open(unicode(path), 'wb') as stream:
                writer = csv.writer(stream)
                for row in range(self.tableWidget.rowCount()):
                    rowdata = []
                    for column in range(self.tableWidget.columnCount()):
                        item = self.tableWidget.item(row, column)
                        if item is not None:
                            rowdata.append(
                                unicode(item.text()).encode('utf8'))
                        else:
                            rowdata.append('')
                    writer.writerow(rowdata)
                    
    def handleOpen(self):
        path = QtGui.QFileDialog.getOpenFileName(
                Dialog, 'Open File', '', 'CSV(*.csv)')
        if not path.isEmpty():
            with open(unicode(path), 'rb') as stream:
                self.tableWidget.setRowCount(0)
                self.tableWidget.setColumnCount(0)
                for rowdata in csv.reader(stream):
                    row = self.tableWidget.rowCount()
                    self.tableWidget.insertRow(row)
                    self.tableWidget.setColumnCount(len(rowdata))
                    for column, data in enumerate(rowdata):
                        item = QtGui.QTableWidgetItem(data.decode('utf8'))
                        self.tableWidget.setItem(row, column, item)

        
    def ReadSizePdf(self,sciezka):
        i=0
        listall=[]
        listA4=[]
        listA3=[]
        listgA3=[]
        listdivA4=[]
        self.j+=1
        try:
            print(sciezka)
            for pdf in os.listdir(sciezka):
                i+=1
                if pdf.endswith('.pdf'):
                    f=open(sciezka+"\\"+pdf, 'rb')
                    input1 = PdfFileReader(f)
                    wyn=input1.getPage(0).mediaBox
                    lh=wyn[2:]
                    p=wyn[3]*wyn[2]
                    #if debugmode==True:
                    #print(str(i)+","+str(lh)+","+str(p)+"\n")
                    f.close()
                    listall.append(p)
                else:
                    pass
            for scan in listall:
                if scan<difa4:
                     listA4.append(scan)
                elif scan>difa4 and scan<difa3:
                    listA3.append(scan)
                elif scan>difa3:
                    listgA3.append(scan)
            for skan in listgA3:
                skan=round(skan/A4)
                listdivA4.append(skan)

            pathname=QtGui.QTableWidgetItem(str(sciezka))       
            countA4=QtGui.QTableWidgetItem(str(len(listA4)))
            countA3=QtGui.QTableWidgetItem(str(len(listA3)))
            countgA3=QtGui.QTableWidgetItem(str(len(listgA3)))
            A4div=QtGui.QTableWidgetItem(str(int(sum(listdivA4))))
            sumA4=QtGui.QTableWidgetItem(str(int(len(listA4)+sum(listdivA4))))
            
            self.tableWidget.setRowCount(self.j+1)
            self.tableWidget.setItem(self.j-1,0,pathname)
            self.tableWidget.setItem(self.j-1,1,countA4)
            self.tableWidget.setItem(self.j-1,2,countA3)
            self.tableWidget.setItem(self.j-1,3,countgA3)
            self.tableWidget.setItem(self.j-1,4,A4div)
            self.tableWidget.setItem(self.j-1,5,sumA4)
            
        except Exception as ex:
                print("blad przy czytaniu plikow")
                print ex
                raw_input

if __name__ == "__main__":
    import sys
    app = QtGui.QApplication(sys.argv)
    Dialog = QtGui.QDialog()
    ui = Ui_Dialog()
    ui.setupUi(Dialog)
    Dialog.show()
    sys.exit(app.exec_())

