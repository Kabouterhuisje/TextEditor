﻿namespace OpdrachtW3
{
    partial class Vervangen
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
            this.btnVervangAlles = new System.Windows.Forms.Button();
            this.btnVervang = new System.Windows.Forms.Button();
            this.ckbIdent = new System.Windows.Forms.CheckBox();
            this.ckbHeelWoord = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.btnVolgend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVervangAlles
            // 
            this.btnVervangAlles.Location = new System.Drawing.Point(280, 65);
            this.btnVervangAlles.Name = "btnVervangAlles";
            this.btnVervangAlles.Size = new System.Drawing.Size(101, 25);
            this.btnVervangAlles.TabIndex = 13;
            this.btnVervangAlles.Text = "Vervang Alles";
            this.btnVervangAlles.UseVisualStyleBackColor = true;
            this.btnVervangAlles.Click += new System.EventHandler(this.btnVervangAlles_Click);
            // 
            // btnVervang
            // 
            this.btnVervang.Location = new System.Drawing.Point(280, 40);
            this.btnVervang.Name = "btnVervang";
            this.btnVervang.Size = new System.Drawing.Size(101, 25);
            this.btnVervang.TabIndex = 14;
            this.btnVervang.Text = "Vervangen";
            this.btnVervang.UseVisualStyleBackColor = true;
            this.btnVervang.Click += new System.EventHandler(this.btnVervang_Click);
            // 
            // ckbIdent
            // 
            this.ckbIdent.AutoSize = true;
            this.ckbIdent.Location = new System.Drawing.Point(26, 115);
            this.ckbIdent.Name = "ckbIdent";
            this.ckbIdent.Size = new System.Drawing.Size(192, 17);
            this.ckbIdent.TabIndex = 11;
            this.ckbIdent.Text = "Identieke hoofdletters/kleine letters";
            this.ckbIdent.UseVisualStyleBackColor = true;
            // 
            // ckbHeelWoord
            // 
            this.ckbHeelWoord.AutoSize = true;
            this.ckbHeelWoord.Location = new System.Drawing.Point(26, 99);
            this.ckbHeelWoord.Name = "ckbHeelWoord";
            this.ckbHeelWoord.Size = new System.Drawing.Size(80, 17);
            this.ckbHeelWoord.TabIndex = 12;
            this.ckbHeelWoord.Text = "Heel woord";
            this.ckbHeelWoord.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vervangen door:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Zoeken naar:";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(115, 44);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(159, 20);
            this.txtReplace.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(115, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.Location = new System.Drawing.Point(280, 90);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(101, 25);
            this.btnAnnuleer.TabIndex = 5;
            this.btnAnnuleer.Text = "Annuleren";
            this.btnAnnuleer.UseVisualStyleBackColor = true;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // btnVolgend
            // 
            this.btnVolgend.Location = new System.Drawing.Point(280, 15);
            this.btnVolgend.Name = "btnVolgend";
            this.btnVolgend.Size = new System.Drawing.Size(101, 25);
            this.btnVolgend.TabIndex = 6;
            this.btnVolgend.Text = "Volgende zoeken";
            this.btnVolgend.UseVisualStyleBackColor = true;
            this.btnVolgend.Click += new System.EventHandler(this.btnVolgend_Click);
            // 
            // Vervangen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 146);
            this.Controls.Add(this.btnVervangAlles);
            this.Controls.Add(this.btnVervang);
            this.Controls.Add(this.ckbIdent);
            this.Controls.Add(this.ckbHeelWoord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.btnVolgend);
            this.Name = "Vervangen";
            this.Text = "Vervangen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVervangAlles;
        private System.Windows.Forms.Button btnVervang;
        private System.Windows.Forms.CheckBox ckbIdent;
        private System.Windows.Forms.CheckBox ckbHeelWoord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.Button btnVolgend;
    }
}