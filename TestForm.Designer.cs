﻿using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Proiect_PIU
{
    partial class TestForm
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
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.grpRaspunsuri = new System.Windows.Forms.GroupBox();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBackcatreMeniu = new System.Windows.Forms.Button();
            this.grpRaspunsuri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntrebare
            // 
            this.lblIntrebare.AutoSize = true;
            this.lblIntrebare.Location = new System.Drawing.Point(59, 37);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Size = new System.Drawing.Size(0, 13);
            this.lblIntrebare.TabIndex = 0;
            // 
            // grpRaspunsuri
            // 
            this.grpRaspunsuri.Controls.Add(this.rdbD);
            this.grpRaspunsuri.Controls.Add(this.rdbA);
            this.grpRaspunsuri.Controls.Add(this.rdbC);
            this.grpRaspunsuri.Controls.Add(this.rdbB);
            this.grpRaspunsuri.Location = new System.Drawing.Point(62, 64);
            this.grpRaspunsuri.Name = "grpRaspunsuri";
            this.grpRaspunsuri.Size = new System.Drawing.Size(379, 101);
            this.grpRaspunsuri.TabIndex = 1;
            this.grpRaspunsuri.TabStop = false;
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(6, 73);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(14, 13);
            this.rdbD.TabIndex = 5;
            this.rdbD.TabStop = true;
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(6, 16);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(14, 13);
            this.rdbA.TabIndex = 2;
            this.rdbA.TabStop = true;
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Location = new System.Drawing.Point(6, 54);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(14, 13);
            this.rdbC.TabIndex = 4;
            this.rdbC.TabStop = true;
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(6, 35);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(14, 13);
            this.rdbB.TabIndex = 3;
            this.rdbB.TabStop = true;
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(260, 194);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(181, 42);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Intrebarea urmatoare";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBack.Location = new System.Drawing.Point(62, 194);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(173, 42);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Intrebarea anterioara";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Turquoise;
            this.btnSubmit.Location = new System.Drawing.Point(211, 285);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBackcatreMeniu
            // 
            this.btnBackcatreMeniu.Location = new System.Drawing.Point(326, 285);
            this.btnBackcatreMeniu.Name = "btnBackcatreMeniu";
            this.btnBackcatreMeniu.Size = new System.Drawing.Size(115, 23);
            this.btnBackcatreMeniu.TabIndex = 5;
            this.btnBackcatreMeniu.Text = "Inapoi catre meniu";
            this.btnBackcatreMeniu.UseVisualStyleBackColor = true;
            this.btnBackcatreMeniu.Click += new System.EventHandler(this.btnBackcatreMeniu_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 368);
            this.Controls.Add(this.btnBackcatreMeniu);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpRaspunsuri);
            this.Controls.Add(this.lblIntrebare);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acum esti in test, mult succes!";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.grpRaspunsuri.ResumeLayout(false);
            this.grpRaspunsuri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntrebare;
        private System.Windows.Forms.GroupBox grpRaspunsuri;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.Button btnNext;
        private Button btnBack;
        private Button btnSubmit;
        private Button btnBackcatreMeniu;
    }
}