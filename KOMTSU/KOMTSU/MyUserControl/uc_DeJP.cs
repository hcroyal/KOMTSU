using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KOMTSU.MyUserControl
{
    public delegate void AllTextChange(object sender, EventArgs e);
    public partial class uc_DeJP : UserControl
    {
        public event AllTextChange Changed;
        public uc_DeJP()
        {
            InitializeComponent();
        }
        public class Category
        {
            public string Set_Value { get; set; }
        }
       
        public void ResetData()
        {
            txt_Truong03.Text = "28";
            txt_Truong03_1.Text = "";
            txt_Truong03_2.Text = "";
            txt_Truong05.Text = "";
            txt_Truong06.Text = "";
            txt_Truong85.Text = "";
            txt_Truong0.Text = "";

            txt_Truong03.BackColor = Color.White;
            txt_Truong03_1.BackColor = Color.White;
            txt_Truong03_2.BackColor = Color.White;
            txt_Truong05.BackColor = Color.White;
            txt_Truong06.BackColor = Color.White;
            txt_Truong85.BackColor = Color.White;
            txt_Truong0.BackColor = Color.White;

            txt_Truong03.ForeColor = Color.Black;
            txt_Truong03_1.ForeColor = Color.Black;
            txt_Truong03_2.ForeColor = Color.Black;
            txt_Truong05.ForeColor = Color.Black;
            txt_Truong06.ForeColor = Color.Black;
            txt_Truong85.ForeColor = Color.Black;
            txt_Truong0.ForeColor = Color.Black;
            
            txt_Truong03.Focus();
        }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_Truong03.Text) &&
                string.IsNullOrEmpty(txt_Truong03_1.Text) &&
                string.IsNullOrEmpty(txt_Truong03_2.Text) &&
                string.IsNullOrEmpty(txt_Truong05.Text) &&
                string.IsNullOrEmpty(txt_Truong06.Text) &&
                string.IsNullOrEmpty(txt_Truong85.Text) &&
                string.IsNullOrEmpty(txt_Truong0.Text))
                return true;
            return false;
        }

        private void txt_Truong03_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong03.Text.IndexOf('?') >= 0)
                txt_Truong03.Text = "?";
            if (txt_Truong03.Text.Length != 2 && txt_Truong03.Text != "" && txt_Truong03.Text != "?" && txt_Truong03.Text.IndexOf('●') < 0)
            {
                txt_Truong03.BackColor = Color.Red;
                txt_Truong03.ForeColor = Color.White;
            }
            else
            {
                txt_Truong03.BackColor = Color.White;
                txt_Truong03.ForeColor = Color.Black;

            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong03_1_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong03_1.Text.IndexOf('?') >= 0)
                txt_Truong03_1.Text = "?";
            if (txt_Truong03_1.Text != "" && txt_Truong03_1.Text != "?" && txt_Truong03_1.Text.IndexOf('●') < 0)
            {
                if (txt_Truong03_1.Text.Length != 8)
                {
                    txt_Truong03_1.BackColor = Color.Red;
                    txt_Truong03_1.ForeColor = Color.White;
                }
                else
                {
                    txt_Truong03_1.BackColor = Color.White;
                    txt_Truong03_1.ForeColor = Color.Black;
                }
            }
            else
            {
                txt_Truong03_1.BackColor = Color.White;
                txt_Truong03_1.ForeColor = Color.Black;
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong03_2_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong03_2.Text.IndexOf('?') >= 0)
                txt_Truong03_2.Text = "?";
            if (txt_Truong03_2.Text != "" && txt_Truong03_2.Text != "?" && txt_Truong03_2.Text.IndexOf('●') < 0)
            {
                if (txt_Truong03_2.Text.Length != 8)
                {
                    txt_Truong03_2.BackColor = Color.Red;
                    txt_Truong03_2.ForeColor = Color.White;
                }
                else
                {
                    txt_Truong03_2.BackColor = Color.White;
                    txt_Truong03_2.ForeColor = Color.Black;
                }
            }
            else
            {
                txt_Truong03_2.BackColor = Color.White;
                txt_Truong03_2.ForeColor = Color.Black;
            }
            if (Changed != null)
                Changed(sender, e);
        }
        int Hople( int ngay,int thang, int nam)
        {
            if (thang > 12 || thang < 1) return 0;
            else
            {
                if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                {
                    if (ngay > 30) return 0;
                    else return 1;
                }
                else
                {
                    if (thang == 2)
                    {
                        if (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0)
                        {
                            if (ngay > 29) return 0;
                            else return 1;
                        }
                        else
                        {
                            if (ngay > 28) return 0;
                            else return 1;
                        }
                    }
                    else
                    {
                        if (ngay > 31) return 0;
                        else return 1;
                    }
                }
            }
        }
        private void txt_Truong05_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong05.Text.IndexOf('?') >= 0)
                txt_Truong05.Text = "?";
            if (txt_Truong05.Text != "" && txt_Truong05.Text != "?" && txt_Truong05.Text.IndexOf('●') < 0)
            {
                if (txt_Truong04.Text != "" && txt_Truong04.Text != "?" && txt_Truong04.Text.IndexOf('●') < 0)
                {
                    if (Hople(Convert.ToInt32(txt_Truong05.Text), Convert.ToInt32(txt_Truong04.Text),Convert.ToInt32(txt_Truong03.Text)) == 0)
                    {
                        txt_Truong05.BackColor = Color.Red;
                        txt_Truong05.ForeColor = Color.White;
                    }
                }
            }
            else
            {
                txt_Truong05.BackColor = Color.White;
                txt_Truong05.ForeColor = Color.Black;
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong06_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong06.Text.IndexOf('?') >= 0)
                txt_Truong06.Text = "?";
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong85_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong85.Text.IndexOf('?') >= 0)
                txt_Truong85.Text = "?";
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong0_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong0.Text.IndexOf('?') >= 0)
                txt_Truong0.Text = "?";
            if (txt_Truong0.Text != txt_Truong03.Text && txt_Truong0.Text != "" && txt_Truong0.Text != "?" && txt_Truong0.Text.IndexOf('●') < 0)
            {
                txt_Truong0.BackColor = Color.Red;
                txt_Truong0.ForeColor = Color.White;
                txt_Truong03.BackColor = Color.Red;
                txt_Truong03.ForeColor = Color.White;
            }
            else
            {
                txt_Truong0.BackColor = Color.White;
                txt_Truong0.ForeColor = Color.Black;
                txt_Truong03.BackColor = Color.White;
                txt_Truong03.ForeColor = Color.Black;
            }
            if (Changed != null)
                Changed(sender, e);
        }
        private void uc_ASAHI_Load(object sender, EventArgs e)
        {
            ResetData();
            txt_Truong03.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong03_1.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong03_2.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong05.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong06.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong85.GotFocus += Txt_Truong02_GotFocus;
            txt_Truong0.GotFocus += Txt_Truong02_GotFocus;
        }

        private void Txt_Truong02_GotFocus(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
        }
        public void SaveData_ASAHI(string idImage)
        {
            
            string txtTruong03 = txt_Truong03_1.Text + txt_Truong03_2.Text;
            if (txtTruong03.ToString().IndexOf('?') >= 0)
                txtTruong03 = "?";
            //Save Data
            
            //Global.db.Insert_ASAHI_QuanLyDuAn(idImage, Global.StrBatch, Global.StrUsername,txt_Truong0.Text,txt_Truong02.Text,txtTruong03,txt_Truong05.Text,txt_Truong06.Text,txt_Truong08.Text,txt_Truong85.Text, CheckQC());
        }

        private void txt_Truong04_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong03.Text.IndexOf('?') >= 0)
                txt_Truong03.Text = "?";
            if ( txt_Truong03.Text != "" && txt_Truong03.Text != "?" && txt_Truong03.Text.IndexOf('●') < 0)
            {
                if (Convert.ToInt32(txt_Truong03.Text) <= 0 || Convert.ToInt32(txt_Truong03.Text) > 12)
                {
                    txt_Truong03.BackColor = Color.Red;
                    txt_Truong03.ForeColor = Color.White;
                }
            }
            else
            {
                txt_Truong03.BackColor = Color.White;
                txt_Truong03.ForeColor = Color.Black;

            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong08_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Truong08.Text.IndexOf('?') >= 0)
                txt_Truong08.Text = "?";
            if (Changed != null)
                Changed(sender, e);
        }
    }
}
