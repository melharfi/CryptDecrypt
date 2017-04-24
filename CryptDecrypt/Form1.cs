using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace CryptDecrypt
{
    public partial class Form1 : Form
    {
        //  Call this function to remove the key from memory after use for security
        [System.Runtime.InteropServices.DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        // Function to Generate a 64 bits Key.
        static string GenerateKey()
        {
            // Create an instance of Symetric Algorithm. Key and IV is generated automatically.
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();

            // Use the Automatically generated key for Encryption. 
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }

        List<string> files;
        public Form1()
        {
            InitializeComponent();
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                files = openFileDialog1.FileNames.ToList();
                info.AppendText((info.Text == "" ? "" : "\n") + files.Count + " file(s) selected");
                this.Height = 527;
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            // crypter le fichier
            EncryptingTab.Enabled = false;
            if(files == null || files.Count == 0)
            {
                MessageBox.Show("Please select at least 1 file to encrypt/decrypt");
                pathButton.Enabled = true;
                encryptButton.Enabled = true;
                decryptButton.Enabled = true;
                return;
            }

            // Must be 64 bits, 8 bytes.
            // Distribute this key to the user who will decrypt this file.
            string sSecretKey, sSecretIV;
            bool error = false;
            for (int cnt = 0; cnt < files.Count; cnt++)
            {
                if (selfKeyGeneration.Checked)
                {
                    if (sKey.Text == "")
                    {
                        MessageBox.Show("You must fill the 1st key");
                        sKey.Focus();
                        error = true;
                        break;
                    }
                    else if (sKey.TextLength != 8)
                    {
                        MessageBox.Show("Key must have exactly 8 characters");
                        sKey.Text = "";
                        sKey.Focus();
                        error = true;
                        break;
                    }
                    else if (sIV.Text == "")
                    {
                        MessageBox.Show("You must fill the second key");
                        sKey.Focus();
                        error = true;
                        break;
                    }
                    else if (sIV.TextLength != 8)
                    {
                        MessageBox.Show("IV must have exactly 8 characters");
                        sKey.Text = "";
                        sKey.Focus();
                        error = true;
                        break;
                    }

                    sSecretKey = sKey.Text;
                    sSecretIV = sIV.Text;
                }
                else
                {
                    if(autoKeyGenerationKeyTB.Text == string.Empty || autoKeyGeneratingIVTB.Text == string.Empty)
                    {
                        MessageBox.Show("Please generate a Key and IV first");
                        error = true;
                        break;
                    }

                    sSecretKey = autoKeyGenerationKeyTB.Text;
                    sSecretIV = autoKeyGeneratingIVTB.Text;
                }

                info.AppendText("\nFull path [original file] : " + files[cnt]);

                try
                {
                    UnicodeEncoding UE = new UnicodeEncoding();
                    byte[] key = UE.GetBytes(sSecretKey);
                    byte[] iv = UE.GetBytes(sSecretIV);

                    // Encrypt the file
                    string cryptFile = files[cnt].Substring(0, files[cnt].LastIndexOf(".")) + "_encrypted" + files[cnt].Substring(files[cnt].LastIndexOf("."), files[cnt].Length - files[cnt].LastIndexOf("."));
                    FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                    RijndaelManaged RMCrypto = new RijndaelManaged();

                    CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, iv), CryptoStreamMode.Write);

                    FileStream fsIn = new FileStream(files[cnt], FileMode.Open);

                    int data;
                    while ((data = fsIn.ReadByte()) != -1)
                        cs.WriteByte((byte)data);

                    fsIn.Close();
                    cs.Close();
                    fsCrypt.Close();
                    info.AppendText("\nFull path [encrypted file] : " + cryptFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Encryption failed!" + Environment.NewLine + ex, "Error");
                    error = true;
                }
            }
            if (!error)
                MessageBox.Show(files.Count + " file(s) has been encrypted successfuly", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            EncryptingTab.Enabled = true;

            info.SelectionStart = info.Text.Length - 1;
            info.SelectionLength = 0;
            info.ScrollToCaret();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            // crypter le fichier
            EncryptingTab.Enabled = false;
            if (files == null || files.Count == 0)
            {
                MessageBox.Show("Please select at least 1 file to encrypt/decrypt");
                pathButton.Enabled = true;
                encryptButton.Enabled = true;
                decryptButton.Enabled = true;
                return;
            }

            // Must be 64 bits, 8 bytes.
            // Distribute this key to the user who will decrypt this file.
            string sSecretKey, sSecretIV;
            bool error = false;
            for (int cnt = 0; cnt < files.Count; cnt++)
            {
                if (decryptingTabKeyTB.Text == "")
                {
                    MessageBox.Show("You must fill the 1st key");
                    decryptingTabKeyTB.Focus();
                    error = true;
                    break;
                }
                else if (decryptingTabKeyTB.TextLength != 8)
                {
                    MessageBox.Show("Key must have exactly 8 characters");
                    decryptingTabKeyTB.Text = "";
                    decryptingTabKeyTB.Focus();
                    error = true;
                    break;
                }
                else if (decryptingTabIVTB.Text == "")
                {
                    MessageBox.Show("You must fill the second key");
                    decryptingTabIVTB.Focus();
                    error = true;
                    break;
                }
                else if (decryptingTabIVTB.TextLength != 8)
                {
                    MessageBox.Show("IV must have exactly 8 characters");
                    decryptingTabIVTB.Text = "";
                    decryptingTabIVTB.Focus();
                    error = true;
                    break;
                }

                sSecretKey = decryptingTabKeyTB.Text;
                sSecretIV = decryptingTabIVTB.Text;

                info.AppendText("\nFull path : " + files[cnt]);

                // For additional security Pin the key.
                GCHandle gch = GCHandle.Alloc(sSecretKey, GCHandleType.Pinned);

                // Encrypt the file
                string newFile = files[cnt].Substring(0, files[cnt].LastIndexOf(".")) + "_decrypted" + files[cnt].Substring(files[cnt].LastIndexOf("."), files[cnt].Length - files[cnt].LastIndexOf("."));

                // Decrypt the file.
                DecryptFile(files[cnt], newFile, sSecretKey, sSecretIV);
                info.AppendText("\nFile decrypted, new file generated called\n\t'" + newFile + "'");

                // Remove the Key from memory. 
                ZeroMemory(gch.AddrOfPinnedObject(), sSecretKey.Length * 2);
                gch.Free();
            }
            if (!error)
                MessageBox.Show(files.Count + " file(s) has been decrypted successfuly", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            EncryptingTab.Enabled = true;

            info.SelectionStart = info.Text.Length - 1;
            info.SelectionLength = 0;
            info.ScrollToCaret();
        }

        private void selfKeyGeneration_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                SelfKeyGeneratingPanel.Enabled = true;
                AutoKeyGeneratingPanel.Enabled = false;
                AutoKeyGenerating.Checked = false;
            }
        }

        private void AutoKeyGenerating_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as RadioButton).Checked)
            {
                SelfKeyGeneratingPanel.Enabled = false;
                AutoKeyGenerating.Enabled = true;
                AutoKeyGeneratingPanel.Enabled = true;
            }
        }


        private void AutoGeneratingKey_Click(object sender, EventArgs e)
        {
            if(autoKeysGeneratingDifferentKey.Checked)
            {
                while(true)
                {
                    autoKeyGenerationKeyTB.Text = GenerateKey();
                    autoKeyGeneratingIVTB.Text = GenerateKey();
                    if (autoKeyGenerationKeyTB.Text.Length == 8 && autoKeyGeneratingIVTB.Text.Length == 8)
                        break;
                }
                
            }
            else
            {
                autoKeyGenerationKeyTB.Text = GenerateKey();
                autoKeyGeneratingIVTB.Text = autoKeyGenerationKeyTB.Text;
            }
        }


        ///<summary>
        ///
        /// Encrypts a file using Rijndael algorithm.
        ///</summary>
        ///<param name="inputFile"></param>
        ///<param name="outputFile"></param>
        private void EncryptFile(string inputFile, string outputFile, string Key, string Iv)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(Key);
                byte[] iv = UE.GetBytes(Iv);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, iv), CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);

                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                MessageBox.Show("Encryption failed!", "Error");
            }
        }
        ///<summary>
        ///
        /// Decrypts a file using Rijndael algorithm.
        ///</summary>
        ///<param name="inputFile"></param>
        ///<param name="outputFile"></param>
        private void DecryptFile(string inputFile, string outputFile, string Key, string Iv)
        {
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(Key);
                byte[] iv = UE.GetBytes(Iv);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(key, iv), CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("http://github.com/melharfi/cryptdecrypt");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Enabled = false;
            about.FormClosed += About_FormClosed;
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
