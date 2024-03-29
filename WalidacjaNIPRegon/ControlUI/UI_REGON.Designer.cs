﻿namespace WalidacjaNIPRegon.ControlUI
{
    partial class UI_REGON
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
            this.lbStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textREGON = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.lbTitle.Text = "Walidacja REGON ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textREGON);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 266);
            this.panel1.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(47, 101);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(256, 34);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(47, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "W przypadku posiadania numeru 7-mio cyfrowego dopisz na począktu 00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textREGON
            // 
            this.textREGON.Location = new System.Drawing.Point(163, 33);
            this.textREGON.MaxLength = 11;
            this.textREGON.Name = "textREGON";
            this.textREGON.Size = new System.Drawing.Size(140, 20);
            this.textREGON.TabIndex = 5;
            this.textREGON.WordWrap = false;
            this.textREGON.TextChanged += new System.EventHandler(this.textREGON_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wprowadź nr. REGON";
            // 
            // UI_REGON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitle);
            this.Name = "UI_REGON";
            this.Size = new System.Drawing.Size(346, 306);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textREGON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label2;
    }
}
