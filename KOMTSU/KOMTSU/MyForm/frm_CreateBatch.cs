using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SautinSoft;

namespace KOMTSU.MyForm
{
    public partial class frm_CreateBatch : DevExpress.XtraEditors.XtraForm
    {
        private string[] _lFileNames;
        private int TongSoTrang;
        public frm_CreateBatch()
        {
            InitializeComponent();
        }

        private void frm_CreateBatch_Load(object sender, EventArgs e)
        {
            btn_BrowserPDF.Enabled = false;
            btn_BrowserFolder.Enabled = false;
            txt_UserCreate.Text = Global.StrUsername;
            txt_DateCreate.Text = DateTime.Now.ToShortDateString() + "  -  " + DateTime.Now.ToShortTimeString();

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value != null)//Nếu ô thứ i của cột thứ 1 (cột sau cột STT ấy) mà có dữ liệu thì gán giá trị cho cột STT, nếu không thì cột STT cũng không có dữ liệu lun
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
            }}

        private void txt_BatchName_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_BatchName.Text))
            {
                btn_BrowserPDF.Enabled = true;
            }
            else
            {
                btn_BrowserPDF.Enabled = false;
            }
        }

        private void btn_BrowserPDF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_BatchName.Text))
            {
                MessageBox.Show("Vui lòng điền tên batch", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Types PDF|*.pdf";

            dlg.Multiselect = false;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _lFileNames = dlg.FileNames;
                txt_ImagePath.Text = Path.GetFullPath(dlg.FileName);
            }
            var f = new PdfFocus { Serial = "1234567890" };
            string pdfFile = txt_ImagePath.Text;
            f.OpenPdf(pdfFile);
            TongSoTrang = f.PageCount;
            lbl_Page.Text = TongSoTrang + " Pages";
        }

        private void btn_CreateBatch_Click(object sender, EventArgs e)
        {
            
        }
        
        private void ExtractImage()
        {
            int h = 1;
            string[] ImageName = new string[TongSoTrang+1];
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                string temp = "";
                string[] temp1 = null;
                
                
                if (h<dataGridView1.RowCount)
                {
                    temp = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";
                    if (temp.IndexOf(";", StringComparison.Ordinal)>0)
                    {
                        temp1 = temp.Split(';');
                        for (int i = 0; i < temp1.Length; i++)
                        {
                            if (temp1[i].IndexOf("-", StringComparison.Ordinal)>0)
                            {
                                string[] temp2 = temp1[i].Split('-');
                                for (int j = int.Parse(temp2[0]); j <= int.Parse(temp2[1]); j++)
                                {
                                    ImageName[j] = dr.Cells[1].Value.ToString();
                                }
                            }
                            else
                            {
                                ImageName[int.Parse(temp1[i])] = dr.Cells[1].Value.ToString();
                            }
                           
                        }
                    }
                    else
                    {
                        if (temp.IndexOf("-", StringComparison.Ordinal) > 0)
                        {
                            string[] temp2 = temp.Split('-');
                            for (int j = int.Parse(temp2[0]); j <= int.Parse(temp2[1]); j++)
                            {
                                ImageName[j] = dr.Cells[1].Value.ToString();
                            }
                        }
                        else
                        {
                            ImageName[int.Parse(temp)] = dr.Cells[1].Value.ToString();
                        }
                    }
                    
                }
                h++;
            }

            var f = new PdfFocus {Serial = "1234567890"};
            string pdfFile = txt_ImagePath.Text;
            string imageDir = Path.GetDirectoryName(pdfFile);
            List<PdfFocus.PdfImage> pdfImages = null;
            f.OpenPdf(pdfFile);
            if (f.PageCount > 0)
            {
                pdfImages = f.ExtractImages(1, f.PageCount);

                // Show all extracted images.
                if (pdfImages != null && pdfImages.Count > 0)
                {

                    for (int i = 0; i < pdfImages.Count; i++)
                    {
                        string imageFile = Path.Combine(txt_FolderSaveImage.Text+"\\", ImageName[i+1]+"_Page"+(i+1)+".jpg");
                        pdfImages[i].Picture.Save(imageFile);
                        
                    }
                }
            }
        }

        private void txt_ImagePath_EditValueChanged(object sender, EventArgs e)
        {
            btn_BrowserFolder.Enabled = !string.IsNullOrEmpty(txt_ImagePath.Text);
        }

        private void btn_BrowserFolder_Click(object sender, EventArgs e)
        {
            string dummyFileName = "Save Here";

            SaveFileDialog sf = new SaveFileDialog();
            // Feed the dummy name to the save dialog
            sf.FileName = dummyFileName;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                // Now here's our save folder
                string savePath = Path.GetDirectoryName(sf.FileName);
                txt_FolderSaveImage.Text = savePath;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ExtractImage();

        }
    }
}