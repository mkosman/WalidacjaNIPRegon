namespace WalidacjaNIPRegon.ControlUI
{
    partial class UI_PESEL
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPlec = new System.Windows.Forms.TextBox();
            this.tbNrDok = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPESEL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(346, 40);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Walidacja PESEL ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textPESEL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 266);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPlec);
            this.groupBox1.Controls.Add(this.tbNrDok);
            this.groupBox1.Controls.Add(this.tbData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Informacje szczegółowe ";
            // 
            // tbPlec
            // 
            this.tbPlec.BackColor = System.Drawing.Color.White;
            this.tbPlec.Location = new System.Drawing.Point(120, 106);
            this.tbPlec.Name = "tbPlec";
            this.tbPlec.ReadOnly = true;
            this.tbPlec.Size = new System.Drawing.Size(163, 20);
            this.tbPlec.TabIndex = 8;
            this.tbPlec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNrDok
            // 
            this.tbNrDok.BackColor = System.Drawing.Color.White;
            this.tbNrDok.Location = new System.Drawing.Point(120, 70);
            this.tbNrDok.Name = "tbNrDok";
            this.tbNrDok.ReadOnly = true;
            this.tbNrDok.Size = new System.Drawing.Size(163, 20);
            this.tbNrDok.TabIndex = 9;
            this.tbNrDok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbData
            // 
            this.tbData.BackColor = System.Drawing.Color.White;
            this.tbData.Location = new System.Drawing.Point(120, 34);
            this.tbData.Name = "tbData";
            this.tbData.ReadOnly = true;
            this.tbData.Size = new System.Drawing.Size(163, 20);
            this.tbData.TabIndex = 10;
            this.tbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Płeć: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numer dokumentu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data urodzenia: ";
            // 
            // textPESEL
            // 
            this.textPESEL.Location = new System.Drawing.Point(168, 12);
            this.textPESEL.MaxLength = 11;
            this.textPESEL.Name = "textPESEL";
            this.textPESEL.Size = new System.Drawing.Size(140, 20);
            this.textPESEL.TabIndex = 5;
            this.textPESEL.WordWrap = false;
            this.textPESEL.TextChanged += new System.EventHandler(this.textPESEL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wprowadź nr. PESEL";
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(23, 35);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(301, 35);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_PESEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.Name = "UI_PESEL";
            this.Size = new System.Drawing.Size(346, 306);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPlec;
        private System.Windows.Forms.TextBox tbNrDok;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPESEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStatus;
    }
}
