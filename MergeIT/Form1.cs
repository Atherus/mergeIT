using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MergeIT {
    public partial class Form1 : Form {


        public Form1() {
            InitializeComponent();
            listBoxFiles.DragDrop += listBoxFiles_DragDrop;
            listBoxFiles.DragEnter += listBoxFiles_DragEnter;
        }

        private void listBoxFiles_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                listBoxFiles.Items.Add(file);
        }

        private void listBoxFiles_DragEnter(object sender, DragEventArgs e) {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void buttonUp_Click(object sender, EventArgs e) {
            MoveItem(-1);
        }

        private void buttonDown_Click(object sender, EventArgs e) {
            MoveItem(1);
        }

        public void MoveItem(int direction) {
            if (listBoxFiles.SelectedItem == null || listBoxFiles.SelectedIndex < 0) {
                return;
            }

            int newIndex = listBoxFiles.SelectedIndex + direction;
            if (newIndex < 0 || newIndex >= listBoxFiles.Items.Count) {
                return;
            }

            object selected = listBoxFiles.SelectedItem;
            listBoxFiles.Items.Remove(selected);
            listBoxFiles.Items.Insert(newIndex, selected);
            listBoxFiles.SetSelected(newIndex, true);
        }

        private void buttonMerge_Click(object sender, EventArgs e) {
            if (listBoxFiles.Items.Count > 0) {
                byte[] mergedPdf = null;
                using (MemoryStream ms = new MemoryStream()) {
                    using (Document document = new Document()) {
                        using (PdfCopy copy = new PdfCopy(document, ms)) {
                            document.Open();

                            for (int i = 0; i < listBoxFiles.Items.Count; ++i) {
                                PdfReader reader = new PdfReader(listBoxFiles.Items[i].ToString());
                                // loop over the pages in that document
                                int n = reader.NumberOfPages;
                                for (int page = 0; page < n;) {
                                    copy.AddPage(copy.GetImportedPage(reader, ++page));
                                }
                            }
                        }
                    }
                    mergedPdf = ms.ToArray();
                    ByteArrayToFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\genPDF.pdf", mergedPdf);
                }
            }  
        }

        public bool ByteArrayToFile(string _FileName, byte[] _ByteArray) {
            try {
                // Open file for reading
                System.IO.FileStream _FileStream =
                   new System.IO.FileStream(_FileName, System.IO.FileMode.Create,
                                            System.IO.FileAccess.Write);
                // Writes a block of bytes to this stream using data from
                // a byte array.
                _FileStream.Write(_ByteArray, 0, _ByteArray.Length);

                // close file stream
                _FileStream.Close();

                return true;
            } catch (Exception _Exception) {
                // Error
                Console.WriteLine("Exception caught in process: {0}",
                                  _Exception.ToString());
            }

            // error occured, return false
            return false;
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            listBoxFiles.Items.Clear(); 
        }
    }

    
}
