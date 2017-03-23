namespace KOMTSU.MyUserControl
{
    partial class uc_DeJP_Row
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_stt = new DevExpress.XtraEditors.LabelControl();
            this.txt_Truong03 = new DevExpress.XtraEditors.TextEdit();
            this.txt_Truong05 = new DevExpress.XtraEditors.TextEdit();
            this.txt_Truong06 = new DevExpress.XtraEditors.TextEdit();
            this.txt_Truong11 = new DevExpress.XtraEditors.TextEdit();
            this.txt_Truong04 = new DevExpress.XtraEditors.TextEdit();
            this.txt_Truong08 = new DevExpress.XtraEditors.TextEdit();
            this.txt_Truong10 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong03.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong05.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong06.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong04.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong08.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_stt
            // 
            this.lb_stt.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_stt.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lb_stt.Appearance.Options.UseFont = true;
            this.lb_stt.Appearance.Options.UseForeColor = true;
            this.lb_stt.Location = new System.Drawing.Point(4, 4);
            this.lb_stt.Name = "lb_stt";
            this.lb_stt.Size = new System.Drawing.Size(9, 13);
            this.lb_stt.TabIndex = 0;
            this.lb_stt.Text = "   ";
            // 
            // txt_Truong03
            // 
            this.txt_Truong03.Location = new System.Drawing.Point(24, 0);
            this.txt_Truong03.Name = "txt_Truong03";
            this.txt_Truong03.Properties.Mask.EditMask = "[0-9?●]+";
            this.txt_Truong03.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_Truong03.Size = new System.Drawing.Size(25, 20);
            this.txt_Truong03.TabIndex = 1;
            this.txt_Truong03.EditValueChanged += new System.EventHandler(this.txt_Truong03_EditValueChanged);
            // 
            // txt_Truong05
            // 
            this.txt_Truong05.Location = new System.Drawing.Point(74, 0);
            this.txt_Truong05.Name = "txt_Truong05";
            this.txt_Truong05.Properties.Mask.EditMask = "[0-9?●]+";
            this.txt_Truong05.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_Truong05.Size = new System.Drawing.Size(25, 20);
            this.txt_Truong05.TabIndex = 3;
            this.txt_Truong05.EditValueChanged += new System.EventHandler(this.txt_Truong05_EditValueChanged);
            // 
            // txt_Truong06
            // 
            this.txt_Truong06.Enabled = false;
            this.txt_Truong06.Location = new System.Drawing.Point(99, 0);
            this.txt_Truong06.Name = "txt_Truong06";
            this.txt_Truong06.Size = new System.Drawing.Size(55, 20);
            this.txt_Truong06.TabIndex = 4;
            this.txt_Truong06.EditValueChanged += new System.EventHandler(this.txt_Truong06_EditValueChanged);
            // 
            // txt_Truong11
            // 
            this.txt_Truong11.Location = new System.Drawing.Point(319, 0);
            this.txt_Truong11.Name = "txt_Truong11";
            this.txt_Truong11.Properties.Mask.EditMask = "[0-9?●]+";
            this.txt_Truong11.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_Truong11.Size = new System.Drawing.Size(70, 20);
            this.txt_Truong11.TabIndex = 9;
            this.txt_Truong11.EditValueChanged += new System.EventHandler(this.txt_Truong11_EditValueChanged);
            // 
            // txt_Truong04
            // 
            this.txt_Truong04.Location = new System.Drawing.Point(49, 0);
            this.txt_Truong04.Name = "txt_Truong04";
            this.txt_Truong04.Properties.Mask.EditMask = "[0-9?●]+";
            this.txt_Truong04.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_Truong04.Size = new System.Drawing.Size(25, 20);
            this.txt_Truong04.TabIndex = 2;
            this.txt_Truong04.EditValueChanged += new System.EventHandler(this.txt_Truong04_EditValueChanged);
            // 
            // txt_Truong08
            // 
            this.txt_Truong08.Enabled = false;
            this.txt_Truong08.Location = new System.Drawing.Point(154, 0);
            this.txt_Truong08.Name = "txt_Truong08";
            this.txt_Truong08.Size = new System.Drawing.Size(57, 20);
            this.txt_Truong08.TabIndex = 5;
            this.txt_Truong08.EditValueChanged += new System.EventHandler(this.txt_Truong08_EditValueChanged);
            // 
            // txt_Truong10
            // 
            this.txt_Truong10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txt_Truong10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_Truong10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Truong10.Location = new System.Drawing.Point(211, 0);
            this.txt_Truong10.Name = "txt_Truong10";
            this.txt_Truong10.Size = new System.Drawing.Size(108, 20);
            this.txt_Truong10.TabIndex = 8;
            this.txt_Truong10.TextChanged += new System.EventHandler(this.txt_Truong10_TextChanged);
            // 
            // uc_DeJP_Row
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txt_Truong10);
            this.Controls.Add(this.txt_Truong11);
            this.Controls.Add(this.txt_Truong08);
            this.Controls.Add(this.txt_Truong06);
            this.Controls.Add(this.txt_Truong05);
            this.Controls.Add(this.txt_Truong04);
            this.Controls.Add(this.txt_Truong03);
            this.Controls.Add(this.lb_stt);
            this.Name = "uc_DeJP_Row";
            this.Size = new System.Drawing.Size(388, 20);
            this.Load += new System.EventHandler(this.uc_DeJP_Row_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong03.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong05.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong06.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong04.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Truong08.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lb_stt;
        public DevExpress.XtraEditors.TextEdit txt_Truong03;
        public DevExpress.XtraEditors.TextEdit txt_Truong05;
        public DevExpress.XtraEditors.TextEdit txt_Truong06;
        public DevExpress.XtraEditors.TextEdit txt_Truong11;
        public DevExpress.XtraEditors.TextEdit txt_Truong04;
        public DevExpress.XtraEditors.TextEdit txt_Truong08;
        public System.Windows.Forms.TextBox txt_Truong10;
    }
}
