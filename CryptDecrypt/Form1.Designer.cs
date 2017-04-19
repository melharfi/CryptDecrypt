namespace CryptDecrypt
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ext = new System.Windows.Forms.TextBox();
            this.crypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.indice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fichiers sources à Crypter :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Parcourir ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Black;
            this.info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.info.Location = new System.Drawing.Point(10, 90);
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(475, 163);
            this.info.TabIndex = 4;
            this.info.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nouvelle extension :";
            // 
            // ext
            // 
            this.ext.Location = new System.Drawing.Point(135, 33);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(38, 20);
            this.ext.TabIndex = 6;
            this.ext.Text = "dat";
            // 
            // crypt
            // 
            this.crypt.Location = new System.Drawing.Point(270, 32);
            this.crypt.Name = "crypt";
            this.crypt.Size = new System.Drawing.Size(102, 23);
            this.crypt.TabIndex = 7;
            this.crypt.Text = "Crypter";
            this.crypt.UseVisualStyleBackColor = true;
            this.crypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(380, 32);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(103, 23);
            this.decrypt.TabIndex = 8;
            this.decrypt.Text = "Decrypter";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.button3_Click);
            // 
            // copy
            // 
            this.copy.AutoSize = true;
            this.copy.Location = new System.Drawing.Point(186, 36);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(53, 17);
            this.copy.TabIndex = 9;
            this.copy.Text = "Copie";
            this.copy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "By Mohssine EL HARFI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Indice de décalage :";
            // 
            // indice
            // 
            this.indice.Location = new System.Drawing.Point(135, 59);
            this.indice.MaxLength = 3;
            this.indice.Name = "indice";
            this.indice.Size = new System.Drawing.Size(31, 20);
            this.indice.TabIndex = 12;
            this.indice.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(170, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Indice dois être supérrieur ou égale à 0 et inférrieur ou égale à 120";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(495, 277);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.indice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.crypt);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crypt Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ext;
        private System.Windows.Forms.Button crypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.CheckBox copy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox indice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

