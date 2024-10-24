namespace Bro_Hot_Food_And_Beverage
{
    partial class msg
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_msg_cont = new System.Windows.Forms.Label();
            this.lbl_msg_header = new System.Windows.Forms.Label();
            this.btn_ys = new Guna.UI2.WinForms.Guna2Button();
            this.btn_no = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Panel1.Controls.Add(this.lbl_msg_header);
            this.guna2Panel1.Location = new System.Drawing.Point(-6, -5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(608, 117);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lbl_msg_cont
            // 
            this.lbl_msg_cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg_cont.ForeColor = System.Drawing.Color.Gold;
            this.lbl_msg_cont.Location = new System.Drawing.Point(0, 168);
            this.lbl_msg_cont.Name = "lbl_msg_cont";
            this.lbl_msg_cont.Size = new System.Drawing.Size(602, 119);
            this.lbl_msg_cont.TabIndex = 36;
            this.lbl_msg_cont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_msg_cont.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_msg_header
            // 
            this.lbl_msg_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg_header.ForeColor = System.Drawing.Color.Gold;
            this.lbl_msg_header.Location = new System.Drawing.Point(6, 29);
            this.lbl_msg_header.Name = "lbl_msg_header";
            this.lbl_msg_header.Size = new System.Drawing.Size(602, 68);
            this.lbl_msg_header.TabIndex = 37;
            this.lbl_msg_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ys
            // 
            this.btn_ys.BorderColor = System.Drawing.Color.BurlyWood;
            this.btn_ys.BorderRadius = 10;
            this.btn_ys.BorderThickness = 2;
            this.btn_ys.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ys.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ys.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ys.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ys.FillColor = System.Drawing.Color.Black;
            this.btn_ys.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ys.ForeColor = System.Drawing.Color.White;
            this.btn_ys.Location = new System.Drawing.Point(59, 324);
            this.btn_ys.Name = "btn_ys";
            this.btn_ys.Size = new System.Drawing.Size(194, 68);
            this.btn_ys.TabIndex = 37;
            // 
            // btn_no
            // 
            this.btn_no.BorderColor = System.Drawing.Color.BurlyWood;
            this.btn_no.BorderRadius = 10;
            this.btn_no.BorderThickness = 2;
            this.btn_no.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_no.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_no.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_no.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_no.FillColor = System.Drawing.Color.Black;
            this.btn_no.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.ForeColor = System.Drawing.Color.White;
            this.btn_no.Location = new System.Drawing.Point(357, 324);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(194, 68);
            this.btn_no.TabIndex = 38;
            // 
            // msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 404);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_ys);
            this.Controls.Add(this.lbl_msg_cont);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "msg";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label lbl_msg_cont;
        public System.Windows.Forms.Label lbl_msg_header;
        public Guna.UI2.WinForms.Guna2Button btn_no;
        public Guna.UI2.WinForms.Guna2Button btn_ys;
    }
}