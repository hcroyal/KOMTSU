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

namespace KOMTSU.MyForm
{
    public partial class frm_CreateBatch : DevExpress.XtraEditors.XtraForm
    {
        private string[] _lFileNames;
        public frm_CreateBatch()
        {
            InitializeComponent();
        }

        private void frm_CreateBatch_Load(object sender, EventArgs e)
        {

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
        }
    }
}