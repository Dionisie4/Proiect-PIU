namespace Proiect_PIU
{
    partial class MenuForm
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
            this.btnAfisareNote = new System.Windows.Forms.Button();
            this.btnIncepereTest = new System.Windows.Forms.Button();
            this.txtCautareUtilizator = new System.Windows.Forms.TextBox();
            this.btnCautaUtilizator = new System.Windows.Forms.Button();
            this.cmbTeste = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAfisareNote
            // 
            this.btnAfisareNote.BackColor = System.Drawing.Color.IndianRed;
            this.btnAfisareNote.Location = new System.Drawing.Point(59, 12);
            this.btnAfisareNote.Name = "btnAfisareNote";
            this.btnAfisareNote.Size = new System.Drawing.Size(167, 68);
            this.btnAfisareNote.TabIndex = 0;
            this.btnAfisareNote.Text = "Afiseaza Notele";
            this.btnAfisareNote.UseVisualStyleBackColor = false;
            this.btnAfisareNote.Click += new System.EventHandler(this.btnAfisareNote_Click);
            // 
            // btnIncepereTest
            // 
            this.btnIncepereTest.BackColor = System.Drawing.Color.Orange;
            this.btnIncepereTest.Location = new System.Drawing.Point(59, 201);
            this.btnIncepereTest.Name = "btnIncepereTest";
            this.btnIncepereTest.Size = new System.Drawing.Size(167, 60);
            this.btnIncepereTest.TabIndex = 1;
            this.btnIncepereTest.Text = "Incepe Testul";
            this.btnIncepereTest.UseVisualStyleBackColor = false;
            this.btnIncepereTest.Click += new System.EventHandler(this.btnIncepereTest_Click);
            // 
            // txtCautareUtilizator
            // 
            this.txtCautareUtilizator.Location = new System.Drawing.Point(253, 134);
            this.txtCautareUtilizator.Name = "txtCautareUtilizator";
            this.txtCautareUtilizator.Size = new System.Drawing.Size(167, 20);
            this.txtCautareUtilizator.TabIndex = 2;
            // 
            // btnCautaUtilizator
            // 
            this.btnCautaUtilizator.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCautaUtilizator.Location = new System.Drawing.Point(59, 113);
            this.btnCautaUtilizator.Name = "btnCautaUtilizator";
            this.btnCautaUtilizator.Size = new System.Drawing.Size(167, 60);
            this.btnCautaUtilizator.TabIndex = 3;
            this.btnCautaUtilizator.Text = "Cauta Utilizator";
            this.btnCautaUtilizator.UseVisualStyleBackColor = false;
            this.btnCautaUtilizator.Click += new System.EventHandler(this.btnCautaUtilizator_Click);
            // 
            // cmbTeste
            // 
            this.cmbTeste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeste.FormattingEnabled = true;
            this.cmbTeste.Location = new System.Drawing.Point(253, 222);
            this.cmbTeste.Name = "cmbTeste";
            this.cmbTeste.Size = new System.Drawing.Size(167, 21);
            this.cmbTeste.TabIndex = 4;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 323);
            this.Controls.Add(this.cmbTeste);
            this.Controls.Add(this.btnCautaUtilizator);
            this.Controls.Add(this.txtCautareUtilizator);
            this.Controls.Add(this.btnIncepereTest);
            this.Controls.Add(this.btnAfisareNote);
            this.Name = "MenuForm";
            this.Text = "Meniu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfisareNote;
        private System.Windows.Forms.Button btnIncepereTest;
        private System.Windows.Forms.TextBox txtCautareUtilizator;
        private System.Windows.Forms.Button btnCautaUtilizator;
        private System.Windows.Forms.ComboBox cmbTeste;
    }
}