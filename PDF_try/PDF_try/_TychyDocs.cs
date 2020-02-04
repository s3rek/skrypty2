using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace PDF_try
{
    public partial class _TychyDocs : Form
    {
        public _TychyDocs()
        {
            InitializeComponent();
        }

        string activeFolder = Path.GetPathRoot(Application.StartupPath);
        string activeFile = "";
        int activeRow;

        class Plik
        {
            public string fileName;
            public string filePath;
        }

        Plik aPlik = new Plik();
        List<Plik> ListaPlikow;


        public void SkanujKatalog(string sciezka, string rozszezenie)
        {
            DirectoryInfo di = new DirectoryInfo(sciezka);
            FileInfo[] fis = di.GetFiles(rozszezenie);

            foreach (FileInfo fi in fis)
            {
                Plik pl = new Plik();
                pl.fileName = fi.Name;
                pl.filePath = fi.DirectoryName;
                ListaPlikow.Add(pl);
            }
            /* bez podkatalogow
            DirectoryInfo[] sdis = di.GetDirectories();

            foreach (DirectoryInfo sdi in sdis)
            {
                this.SkanujKatalog(sdi.FullName, rozszezenie);
            }
            */
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnStatus.BackColor = Color.GreenYellow;
                axAcroPDF1.src = activeFolder + dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                activeFile = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                activeRow = e.RowIndex;
            }
            catch { }
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                btnStatus.BackColor = Color.GreenYellow;
                axAcroPDF1.src = activeFolder + dataGridView1[0, e.RowIndex].Value.ToString();
                activeFile = dataGridView1[0, e.RowIndex].Value.ToString();
                activeRow = e.RowIndex;
            }
            catch { }
        }


        private void _TychyDocs_FormClosing(object sender, FormClosingEventArgs e)
        {
            axAcroPDF1.Dispose();
            axAcroPDF1 = null;
        }


        private class plikCompare : IComparer<Plik>
        {           
            public int Compare(Plik q, Plik r)
            {
                return string.Compare(q.fileName, r.fileName,StringComparison.OrdinalIgnoreCase);
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.Description = "Wybierz katalog z plikami PDF:";
            fb.SelectedPath  =  activeFolder;

            if (fb.ShowDialog() == DialogResult.OK)
            {
                ListaPlikow = new List<Plik>();
                activeFolder = fb.SelectedPath+"\\";
                lblFolder.Text = activeFolder;

                SkanujKatalog(fb.SelectedPath, "*.pdf");
                //SkanujKatalog(fb.SelectedPath, "*.dwg");
                //SkanujKatalog(fb.SelectedPath, "*.dxf");
            }

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            ListaPlikow.Sort(new plikCompare());

            if (ListaPlikow.Count > 0)
            {
                dataGridView1.Rows.Add(ListaPlikow.Count);
                for (int i = 0; i < ListaPlikow.Count; i++)
                {
                    aPlik = ListaPlikow[i];
                    dataGridView1[0, i].Value = aPlik.fileName;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listView1.SelectedItems.ToString());
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            kopiujPliki(listView1.SelectedItems[0].Text);
        }

        private void kopiujPliki(string documentFolder)
        {
            //jeśli jest zielony to znaczy że już był zrobiony

            if (dataGridView1.Rows[activeRow].DefaultCellStyle.BackColor == Color.GreenYellow)
            {
                btnStatus.BackColor = Color.Red;
                Application.DoEvents();
            
                MessageBox.Show("Ten dokument już został opracowany...");
            }
            else
            {
                try
                {
                    btnStatus.BackColor = Color.Red;

                    if (!Directory.Exists(activeFolder + tbKerg.Text))
                        Directory.CreateDirectory(activeFolder + tbKerg.Text);

                    if (!Directory.Exists(activeFolder + tbKerg.Text + "\\" + documentFolder))
                        Directory.CreateDirectory(activeFolder + tbKerg.Text + "\\" + documentFolder);

                    File.Copy(activeFolder + activeFile, activeFolder + tbKerg.Text + "\\" + documentFolder + "\\" + tbNumer.Text + ".pdf");

                    if (!Directory.Exists(activeFolder + "_zrobione"))
                        Directory.CreateDirectory(activeFolder + "_zrobione");

                    dataGridView1.Rows[activeRow].DefaultCellStyle.BackColor = Color.GreenYellow;
                    dataGridView1[0, activeRow].Value = tbKerg.Text + "\\" + documentFolder + "\\" + tbNumer.Text + ".pdf";
                    axAcroPDF1.src = activeFolder + dataGridView1[0, activeRow].Value.ToString();

                    try
                    {
                        tbNumer.Text = (int.Parse(tbNumer.Text) + 1).ToString();
                    }
                    catch { }

                    File.Move(activeFolder + activeFile, activeFolder + "_zrobione\\" + activeFile);

                    btnStatus.BackColor = Color.GreenYellow;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }




        private void btnInnyDokument_Click(object sender, EventArgs e)
        {
            if (txtInnyDokument.Text.Trim() == "")
            {
                MessageBox.Show("Nie uzupełniono pola z nazwą katalogu dla dokumentu");
                btnStatus.BackColor = Color.Red;
            }
            else
            {
                kopiujPliki(txtInnyDokument.Text.Trim());
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Wybierz plik tekstowy ze słownikiem";
            //od.Filter = "*.txt";
            string[] dane;
            string input;
            ListViewItem li;

            if (od.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                StreamReader sr = new StreamReader(od.FileName, Encoding.GetEncoding(1250));
                listView1.Items.Clear();

                while ((input = sr.ReadLine()) != null)
                {
                    try
                    {
                        dane = input.Split('\t');

                        li = new ListViewItem();
                        li.Text = dane[0];
                        li.ToolTipText = dane[1];
                        listView1.Items.Add(li);
                    }
                    catch
                    { }
                }

                sr.Close();
            }
        }



        private void tbKerg_TextChanged(object sender, EventArgs e)
        {
            tbNumer.Text = "1";
        }

        private void kopiujPlikiDoBiezacegoKatalogu(string activeFolder, string rootFolder)
        {
            DirectoryInfo di = new DirectoryInfo(activeFolder);
            string[] filtrPlikow = new string[2] { "*.pdf", "*.dxf" };

            foreach (string s in filtrPlikow)
            {
                FileInfo[] fis = di.GetFiles(s);

                foreach (FileInfo fi in fis)
                {
                    File.Copy(fi.FullName, rootFolder + fi.FullName.Replace(rootFolder, "").Replace("\\", "_"));
                }
            }

        }

        private void kopiujPlikiZPodfolderow(string activeFolder)
        {
            DirectoryInfo di = new DirectoryInfo(activeFolder);
            DirectoryInfo[] sdis = di.GetDirectories();

            foreach (DirectoryInfo sdi in sdis)
            {
                this.kopiujPlikiDoBiezacegoKatalogu(sdi.FullName, activeFolder);
            }
        }

        private void btnKopiujZPodfolderow_Click(object sender, EventArgs e)
        {
            if (activeFolder == Path.GetPathRoot(Application.StartupPath))
                MessageBox.Show("Należy wybrać katalog gdzie znajdują się podfoldery z plikami PDF");
            else
            {

                kopiujPlikiZPodfolderow(activeFolder);
                MessageBox.Show("Zakończono kopiowanie");
            }
        }

        private void obrotPdf(int rotateAngle)
        {
            axAcroPDF1.src = "";
            int rot;

            PdfSharp.Pdf.PdfDocument pdfDoc = PdfSharp.Pdf.IO.PdfReader.Open(activeFolder + activeFile, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Modify);
            pdfDoc.Tag = "UNIMAP";

            for (int i = 0; i < pdfDoc.PageCount; i++)
            {
                PdfSharp.Pdf.PdfPage page = pdfDoc.Pages[i];

                PdfSharp.PageOrientation po = page.Orientation;

                rot = page.Rotate + rotateAngle;

                /*
                if (rot <= -180)
                    rot += 180;
                else if (rot > 180)
                    rot -= 180;
                                */

                if (rot < 0)
                    rot += 360;
                else if (rot >= 360)
                    rot -= 360;

               // MessageBox.Show(page.Rotate.ToString());
                page.Rotate = rot;
                //MessageBox.Show(page.Rotate.ToString());

                //gdy page.Rotate jest 90 lub -90 to automatycznie zmienia się układ strony, gdy 180 to nie i zostaje stary układ trzeba go zmienić ręcznie....

                if ((Math.Abs(rotateAngle) == 90) || (rotateAngle == 270))
                {
                    if ((Math.Abs(page.Rotate) == 180) || (Math.Abs(page.Rotate) == 0))
                    {
                        if (po == PdfSharp.PageOrientation.Portrait)
                            page.Orientation = PdfSharp.PageOrientation.Landscape;
                        else
                            page.Orientation = PdfSharp.PageOrientation.Portrait;
                    }
                }
                else if ((Math.Abs(rotateAngle) == 180) || (rotateAngle == 0))
                {
                    if ((Math.Abs(page.Rotate) == 90) || (Math.Abs(page.Rotate) == 270))
                    {
                        if (po == PdfSharp.PageOrientation.Portrait)
                            page.Orientation = PdfSharp.PageOrientation.Landscape;
                        else
                            page.Orientation = PdfSharp.PageOrientation.Portrait;
                    }
                }

            }

            pdfDoc.Save(activeFolder + activeFile);

            axAcroPDF1.src = activeFolder + activeFile;
            Application.DoEvents();

        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {

            obrotPdf(-90);

            //MigraDoc.DocumentObjectModel.Pdf doc = new MigraDoc.DocumentObjectModel.Document();





        }

        private void btnRotate180_Click(object sender, EventArgs e)
        {
            obrotPdf(180);
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            obrotPdf(90);
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
