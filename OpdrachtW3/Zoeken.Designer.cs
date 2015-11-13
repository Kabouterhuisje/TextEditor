namespace OpdrachtW3
{
    partial class Zoeken
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
            this.ckbIdent = new System.Windows.Forms.CheckBox();
            this.ckbHeelWoord = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.btnVolgend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ckbIdent
            // 
            this.ckbIdent.AutoSize = true;
            this.ckbIdent.Location = new System.Drawing.Point(10, 70);
            this.ckbIdent.Name = "ckbIdent";
            this.ckbIdent.Size = new System.Drawing.Size(192, 17);
            this.ckbIdent.TabIndex = 8;
            this.ckbIdent.Text = "Identieke hoofdletters/kleine letters";
            this.ckbIdent.UseVisualStyleBackColor = true;
            // 
            // ckbHeelWoord
            // 
            this.ckbHeelWoord.AutoSize = true;
            this.ckbHeelWoord.Location = new System.Drawing.Point(10, 54);
            this.ckbHeelWoord.Name = "ckbHeelWoord";
            this.ckbHeelWoord.Size = new System.Drawing.Size(80, 17);
            this.ckbHeelWoord.TabIndex = 9;
            this.ckbHeelWoord.Text = "Heel woord";
            this.ckbHeelWoord.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zoeken naar:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(87, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.Location = new System.Drawing.Point(267, 43);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(101, 25);
            this.btnAnnuleer.TabIndex = 4;
            this.btnAnnuleer.Text = "Annuleren";
            this.btnAnnuleer.UseVisualStyleBackColor = true;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // btnVolgend
            // 
            this.btnVolgend.Location = new System.Drawing.Point(267, 12);
            this.btnVolgend.Name = "btnVolgend";
            this.btnVolgend.Size = new System.Drawing.Size(101, 25);
            this.btnVolgend.TabIndex = 5;
            this.btnVolgend.Text = "Volgende zoeken";
            this.btnVolgend.UseVisualStyleBackColor = true;
            this.btnVolgend.Click += new System.EventHandler(this.btnVolgend_Click);
            // 
            // Zoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 97);
            this.Controls.Add(this.ckbIdent);
            this.Controls.Add(this.ckbHeelWoord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.btnVolgend);
            this.Name = "Zoeken";
            this.Text = "Zoeken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbIdent;
        private System.Windows.Forms.CheckBox ckbHeelWoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.Button btnVolgend;
    }
}