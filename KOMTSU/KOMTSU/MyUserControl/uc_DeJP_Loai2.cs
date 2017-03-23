using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KOMTSU.MyUserControl
{
    public partial class uc_DeJP_Loai2 : UserControl
    {
        
        public event AllTextChange Changed;

        public int iStt = 0;
        public uc_DeJP_Loai2()
        {
            InitializeComponent();
        }

        private void uc_DeJP_Loai2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                uc_DeJP_Row uc = new uc_DeJP_Row();
                Point p = new Point();
                uc.Changed += Uc_Changed; ;
                foreach (Control ct in this.Controls)
                {
                    p = ct.Location;
                    p.Y += ct.Size.Height;
                }
                uc.Location = p;
                this.Controls.Add(uc);
            }
        }
        void UpdateStt()
        {
            iStt = 1;
            foreach (uc_DeJP_Row item in this.Controls)
            {
                item.lb_stt.Text = "";
                if (!item.IsEmpty())
                {
                    item.lb_stt.Text = iStt.ToString();
                    iStt++;
                }
            }
        }
        private void Uc_Changed(object sender, EventArgs e)
        {
            UpdateStt();
        }

        public void ResetData()
        {
            foreach (uc_DeJP_Row item in this.Controls)
            {
                item.ResetData();
            }
        }

        public bool IsEmpty()
        {
            bool empty=true;
            foreach (uc_DeJP_Row item in this.Controls)
            {
                if (item.IsEmpty() == false)
                {
                    empty= false;
                    break;
                }

            }
            return empty;
        }
        public void SaveData_Loai2(string idImage)
        {
            //Save Data

            //Global.db.Insert_Loai1(idImage, Global.StrBatch, Global.StrUsername, txt_Truong03.Text, txt_Truong04.Text, txt_Truong05.Text, txt_Truong06.Text, txt_Truong07.Text, txt_Truong08.Text, txt_Truong09.Text, txt_Truong10.Text, txt_Truong11.Text, txt_Truong12.Text, Global.LoaiPhieu);
        }

    }
}
