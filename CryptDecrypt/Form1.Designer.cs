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
            this.pathButton = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.RichTextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sKey = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sIV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SelfKeyGeneratingPanel = new System.Windows.Forms.Panel();
            this.selfKeyGeneration = new System.Windows.Forms.RadioButton();
            this.AutoKeyGenerating = new System.Windows.Forms.RadioButton();
            this.AutoKeyGeneratingPanel = new System.Windows.Forms.Panel();
            this.autoKeysGeneratingDifferentKey = new System.Windows.Forms.RadioButton();
            this.autoKeyGeneratingSameKey = new System.Windows.Forms.RadioButton();
            this.autoKeyGeneratingIVTB = new System.Windows.Forms.TextBox();
            this.autoKeyGenerationKeyTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoGeneratingKey = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.EncryptingTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.decryptingTabKeyTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.decryptingTabIVTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SelfKeyGeneratingPanel.SuspendLayout();
            this.AutoKeyGeneratingPanel.SuspendLayout();
            this.EncryptingTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source file / files:";
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(135, 5);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(348, 31);
            this.pathButton.TabIndex = 2;
            this.pathButton.Text = "Parcourir ...";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Black;
            this.info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.info.Location = new System.Drawing.Point(21, 380);
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(515, 86);
            this.info.TabIndex = 4;
            this.info.Text = "";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(89, 237);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(382, 43);
            this.encryptButton.TabIndex = 7;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(48, 96);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(410, 50);
            this.decryptButton.TabIndex = 8;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(20, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Source code [Github] 24/04/2017";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Key :";
            // 
            // sKey
            // 
            this.sKey.Location = new System.Drawing.Point(137, 3);
            this.sKey.MaxLength = 8;
            this.sKey.Name = "sKey";
            this.sKey.Size = new System.Drawing.Size(75, 20);
            this.sKey.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(218, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "1st key for encripting (8 characters)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Initialization Vector (IV)";
            // 
            // sIV
            // 
            this.sIV.Location = new System.Drawing.Point(137, 32);
            this.sIV.MaxLength = 8;
            this.sIV.Name = "sIV";
            this.sIV.Size = new System.Drawing.Size(75, 20);
            this.sIV.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(218, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "2nd key (IV) for encripting (8 characters)";
            // 
            // SelfKeyGeneratingPanel
            // 
            this.SelfKeyGeneratingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelfKeyGeneratingPanel.Controls.Add(this.sKey);
            this.SelfKeyGeneratingPanel.Controls.Add(this.label7);
            this.SelfKeyGeneratingPanel.Controls.Add(this.label4);
            this.SelfKeyGeneratingPanel.Controls.Add(this.sIV);
            this.SelfKeyGeneratingPanel.Controls.Add(this.label5);
            this.SelfKeyGeneratingPanel.Controls.Add(this.label6);
            this.SelfKeyGeneratingPanel.Location = new System.Drawing.Point(14, 29);
            this.SelfKeyGeneratingPanel.Name = "SelfKeyGeneratingPanel";
            this.SelfKeyGeneratingPanel.Size = new System.Drawing.Size(474, 60);
            this.SelfKeyGeneratingPanel.TabIndex = 17;
            // 
            // selfKeyGeneration
            // 
            this.selfKeyGeneration.AutoSize = true;
            this.selfKeyGeneration.Checked = true;
            this.selfKeyGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selfKeyGeneration.Location = new System.Drawing.Point(15, 6);
            this.selfKeyGeneration.Name = "selfKeyGeneration";
            this.selfKeyGeneration.Size = new System.Drawing.Size(151, 20);
            this.selfKeyGeneration.TabIndex = 18;
            this.selfKeyGeneration.TabStop = true;
            this.selfKeyGeneration.Text = "Self Keys Generating";
            this.selfKeyGeneration.UseVisualStyleBackColor = true;
            this.selfKeyGeneration.CheckedChanged += new System.EventHandler(this.selfKeyGeneration_CheckedChanged);
            // 
            // AutoKeyGenerating
            // 
            this.AutoKeyGenerating.AutoSize = true;
            this.AutoKeyGenerating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoKeyGenerating.Location = new System.Drawing.Point(14, 95);
            this.AutoKeyGenerating.Name = "AutoKeyGenerating";
            this.AutoKeyGenerating.Size = new System.Drawing.Size(155, 20);
            this.AutoKeyGenerating.TabIndex = 19;
            this.AutoKeyGenerating.Text = "Auto Keys Generating";
            this.AutoKeyGenerating.UseVisualStyleBackColor = true;
            this.AutoKeyGenerating.CheckedChanged += new System.EventHandler(this.AutoKeyGenerating_CheckedChanged);
            // 
            // AutoKeyGeneratingPanel
            // 
            this.AutoKeyGeneratingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AutoKeyGeneratingPanel.Controls.Add(this.autoKeysGeneratingDifferentKey);
            this.AutoKeyGeneratingPanel.Controls.Add(this.autoKeyGeneratingSameKey);
            this.AutoKeyGeneratingPanel.Controls.Add(this.autoKeyGeneratingIVTB);
            this.AutoKeyGeneratingPanel.Controls.Add(this.autoKeyGenerationKeyTB);
            this.AutoKeyGeneratingPanel.Controls.Add(this.label9);
            this.AutoKeyGeneratingPanel.Controls.Add(this.label2);
            this.AutoKeyGeneratingPanel.Controls.Add(this.AutoGeneratingKey);
            this.AutoKeyGeneratingPanel.Enabled = false;
            this.AutoKeyGeneratingPanel.Location = new System.Drawing.Point(15, 118);
            this.AutoKeyGeneratingPanel.Name = "AutoKeyGeneratingPanel";
            this.AutoKeyGeneratingPanel.Size = new System.Drawing.Size(473, 113);
            this.AutoKeyGeneratingPanel.TabIndex = 17;
            // 
            // autoKeysGeneratingDifferentKey
            // 
            this.autoKeysGeneratingDifferentKey.AutoSize = true;
            this.autoKeysGeneratingDifferentKey.Checked = true;
            this.autoKeysGeneratingDifferentKey.Location = new System.Drawing.Point(137, 13);
            this.autoKeysGeneratingDifferentKey.Name = "autoKeysGeneratingDifferentKey";
            this.autoKeysGeneratingDifferentKey.Size = new System.Drawing.Size(85, 17);
            this.autoKeysGeneratingDifferentKey.TabIndex = 28;
            this.autoKeysGeneratingDifferentKey.TabStop = true;
            this.autoKeysGeneratingDifferentKey.Text = "Different key";
            this.autoKeysGeneratingDifferentKey.UseVisualStyleBackColor = true;
            // 
            // autoKeyGeneratingSameKey
            // 
            this.autoKeyGeneratingSameKey.AutoSize = true;
            this.autoKeyGeneratingSameKey.Location = new System.Drawing.Point(255, 13);
            this.autoKeyGeneratingSameKey.Name = "autoKeyGeneratingSameKey";
            this.autoKeyGeneratingSameKey.Size = new System.Drawing.Size(73, 17);
            this.autoKeyGeneratingSameKey.TabIndex = 27;
            this.autoKeyGeneratingSameKey.Text = "Same Key";
            this.autoKeyGeneratingSameKey.UseVisualStyleBackColor = true;
            // 
            // autoKeyGeneratingIVTB
            // 
            this.autoKeyGeneratingIVTB.Location = new System.Drawing.Point(314, 84);
            this.autoKeyGeneratingIVTB.MaxLength = 8;
            this.autoKeyGeneratingIVTB.Name = "autoKeyGeneratingIVTB";
            this.autoKeyGeneratingIVTB.ReadOnly = true;
            this.autoKeyGeneratingIVTB.Size = new System.Drawing.Size(72, 20);
            this.autoKeyGeneratingIVTB.TabIndex = 26;
            // 
            // autoKeyGenerationKeyTB
            // 
            this.autoKeyGenerationKeyTB.Location = new System.Drawing.Point(110, 83);
            this.autoKeyGenerationKeyTB.MaxLength = 8;
            this.autoKeyGenerationKeyTB.Name = "autoKeyGenerationKeyTB";
            this.autoKeyGenerationKeyTB.ReadOnly = true;
            this.autoKeyGenerationKeyTB.Size = new System.Drawing.Size(72, 20);
            this.autoKeyGenerationKeyTB.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "IV :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Key :";
            // 
            // AutoGeneratingKey
            // 
            this.AutoGeneratingKey.Location = new System.Drawing.Point(85, 45);
            this.AutoGeneratingKey.Name = "AutoGeneratingKey";
            this.AutoGeneratingKey.Size = new System.Drawing.Size(333, 32);
            this.AutoGeneratingKey.TabIndex = 20;
            this.AutoGeneratingKey.Text = "Generating Key and IV";
            this.AutoGeneratingKey.UseVisualStyleBackColor = true;
            this.AutoGeneratingKey.Click += new System.EventHandler(this.AutoGeneratingKey_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Output";
            // 
            // EncryptingTab
            // 
            this.EncryptingTab.Controls.Add(this.tabPage1);
            this.EncryptingTab.Controls.Add(this.tabPage2);
            this.EncryptingTab.Location = new System.Drawing.Point(21, 36);
            this.EncryptingTab.Name = "EncryptingTab";
            this.EncryptingTab.SelectedIndex = 0;
            this.EncryptingTab.Size = new System.Drawing.Size(515, 320);
            this.EncryptingTab.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.selfKeyGeneration);
            this.tabPage1.Controls.Add(this.AutoKeyGeneratingPanel);
            this.tabPage1.Controls.Add(this.encryptButton);
            this.tabPage1.Controls.Add(this.AutoKeyGenerating);
            this.tabPage1.Controls.Add(this.SelfKeyGeneratingPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(507, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.decryptingTabKeyTB);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.decryptingTabIVTB);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.decryptButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(507, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // decryptingTabKeyTB
            // 
            this.decryptingTabKeyTB.Location = new System.Drawing.Point(136, 16);
            this.decryptingTabKeyTB.MaxLength = 8;
            this.decryptingTabKeyTB.Name = "decryptingTabKeyTB";
            this.decryptingTabKeyTB.Size = new System.Drawing.Size(75, 20);
            this.decryptingTabKeyTB.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(217, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "2nd key (IV) for encripting (8 characters)";
            // 
            // decryptingTabIVTB
            // 
            this.decryptingTabIVTB.Location = new System.Drawing.Point(136, 51);
            this.decryptingTabIVTB.MaxLength = 8;
            this.decryptingTabIVTB.Name = "decryptingTabIVTB";
            this.decryptingTabIVTB.Size = new System.Drawing.Size(75, 20);
            this.decryptingTabIVTB.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Location = new System.Drawing.Point(217, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "1st key for encripting (8 characters)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Goldenrod;
            this.label12.Location = new System.Drawing.Point(278, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "About";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Goldenrod;
            this.label13.Location = new System.Drawing.Point(399, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "By Mohssine EL HARFI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(558, 506);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.EncryptingTab);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Crypt Decrypt";
            this.SelfKeyGeneratingPanel.ResumeLayout(false);
            this.SelfKeyGeneratingPanel.PerformLayout();
            this.AutoKeyGeneratingPanel.ResumeLayout(false);
            this.AutoKeyGeneratingPanel.PerformLayout();
            this.EncryptingTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sKey;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sIV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel SelfKeyGeneratingPanel;
        private System.Windows.Forms.RadioButton selfKeyGeneration;
        private System.Windows.Forms.RadioButton AutoKeyGenerating;
        private System.Windows.Forms.Panel AutoKeyGeneratingPanel;
        private System.Windows.Forms.TextBox autoKeyGeneratingIVTB;
        private System.Windows.Forms.TextBox autoKeyGenerationKeyTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AutoGeneratingKey;
        private System.Windows.Forms.RadioButton autoKeysGeneratingDifferentKey;
        private System.Windows.Forms.RadioButton autoKeyGeneratingSameKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl EncryptingTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox decryptingTabKeyTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox decryptingTabIVTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

