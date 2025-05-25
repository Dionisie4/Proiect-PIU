namespace Proiect_PIU
{
    partial class ReviewForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.BtnBackcatreMeniu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 450);
            this.listView1.TabIndex = 0;
            this.listView1.Tag = "";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // BtnBackcatreMeniu
            // 
            this.BtnBackcatreMeniu.Location = new System.Drawing.Point(331, 339);
            this.BtnBackcatreMeniu.Name = "BtnBackcatreMeniu";
            this.BtnBackcatreMeniu.Size = new System.Drawing.Size(104, 32);
            this.BtnBackcatreMeniu.TabIndex = 1;
            this.BtnBackcatreMeniu.Text = "Inapoi catre meniu";
            this.BtnBackcatreMeniu.UseVisualStyleBackColor = true;
            this.BtnBackcatreMeniu.Click += new System.EventHandler(this.BtnBackcatreMeniu_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBackcatreMeniu);
            this.Controls.Add(this.listView1);
            this.Name = "ReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raspunsurile corecte sunt:";
            this.Load += new System.EventHandler(this.ReviewForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BtnBackcatreMeniu;
    }
}