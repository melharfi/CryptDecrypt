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

namespace CryptDecrypt
{
    public partial class Form1 : Form
    {
        List<string> files;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                files = openFileDialog1.FileNames.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // crypter le fichier
            button1.Enabled = false;
            crypt.Enabled = false;
            decrypt.Enabled = false;

            for (int cnt = 0; cnt < files.Count; cnt++)
            {
                if (files[cnt].Split('.').Count() == 2)
                {
                    if (ext.Text != "")
                    {
                        if (indice.Text == "")
                        {
                            MessageBox.Show("Veuillez remplire l'indice bouffon");
                            indice.Focus();
                            return;
                        }

                        byte _indice;
                        bool result = byte.TryParse(indice.Text, out _indice);
                        if (!result)
                        {
                            MessageBox.Show("Indice dois être numérique bouffon");
                            indice.Text = "";
                            indice.Focus();
                            return;
                        }
                        else if (result && (_indice < 0 || _indice > 120))
                        {
                            MessageBox.Show("L'indice dois être superrieur ou égale 0 et inférieur ou égale à 120,\nC'est pourtant écris dessus BOUFFON");
                            indice.Text = "";
                            indice.Focus();
                            return;
                        }

                        info.Text += "\rChemain complet : " + files[cnt];

                        byte[] b1 = File.ReadAllBytes(files[cnt]);
                        info.Text += "\nAnalyse de fichier en cours ...";

                        if (b1.Count() > 4 && b1[b1.Count() - 3] == 48 && b1[b1.Count() - 2] == 48 && b1[b1.Count() - 1] == 57)
                            MessageBox.Show("Ce fichier est déja crypté");
                        else
                        {
                            info.Text += "\nFichier non crypté";
                            if (b1.Count() > 0)
                            {
                                if (copy.Checked)
                                {
                                    try
                                    {
                                        File.Copy(files[cnt], files[cnt] + ".bak");
                                        info.Text += "\nBack up de fichier a été fait sous le nom :\n" + files[cnt] + ".bak";
                                    }
                                    catch
                                    {
                                        File.Delete(files[cnt] + ".bak");
                                        File.Copy(files[cnt], files[cnt] + ".bak");
                                        info.Text += "\nUn autre fichier de backup a été trouvé mais a été écrasé";
                                    }
                                }
                                else
                                    info.Text += "\nLe fichier source sera écrasé.";
                                info.Text += "\nLe fichier contiens " + b1.Count().ToString() + " Bytes";
                                for (int cnt2 = 0; cnt2 < b1.Length; cnt2++)
                                    b1[cnt2] += _indice;
                                byte[] b2 = new byte[b1.Count() + 4];
                                b1.CopyTo(b2, 0);
                                b2[b2.Count() - 4] = (byte)(48 + _indice);        // byte de 0 = 49 mais on ajoute +1 pour que ca egale 48 lors du decryptage qui soustrait -1
                                b2[b2.Count() - 3] = (byte)(48 + _indice);
                                b2[b2.Count() - 2] = (byte)(57 + _indice);
                                string oldExt = files[cnt].Substring(files[cnt].IndexOf('.') + 1, files[cnt].Length - files[cnt].IndexOf('.') - 1);
                                char firstCharExt = oldExt.ElementAt(0);
                                byte b4 = Convert.ToByte(firstCharExt);
                                byte b3 = Convert.ToByte(oldExt.ElementAt(0) + _indice);
                                b2[b2.Count() - 1] = Convert.ToByte(oldExt.ElementAt(0) + _indice);
                                File.WriteAllBytes(files[cnt], b2);
                                info.Text += "\nFichier Crypté avec succée";
                                string newPath = files[cnt].Substring(0, files[cnt].IndexOf('.')) + "." + ext.Text;
                                try
                                {
                                    File.Move(files[cnt], newPath);
                                }
                                catch (Exception ex)
                                {
                                    File.Delete(newPath);
                                    File.Move(files[cnt], newPath);
                                    info.Text += "\nUn autre fichier .Dat a été trouvé mais a été écrasé";
                                }

                                info.Text += "\nFichier rennomé en :" + newPath;
                                files[cnt] = "";
                            }
                            else
                                MessageBox.Show("Le fichier source est vide");

                            info.Text += System.Environment.NewLine;
                        }
                    }
                    else
                        MessageBox.Show("Vous n'avez pas precisé d'extension");
                }
                else
                    MessageBox.Show("Le fichier source ne dois pas contenir plus d'un point '.'");
            }
            MessageBox.Show(files.Count + " fichiers ont étés cryptés", "Succée", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            button1.Enabled = true;
            crypt.Enabled = true;
            decrypt.Enabled = true;

            info.SelectionStart = info.Text.Length - 1;
            info.SelectionLength = 0;
            info.ScrollToCaret();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // decrypter le fichier
            button1.Enabled = false;
            crypt.Enabled = false;
            decrypt.Enabled = false;

            for (int cnt = 0; cnt < files.Count; cnt++)
            {
                if (indice.Text == "")
                {
                    MessageBox.Show("Veuillez remplire l'indice bouffon");
                    indice.Focus();
                    return;
                }

                byte _indice;
                bool result = byte.TryParse(indice.Text, out _indice);
                if (!result)
                {
                    MessageBox.Show("Indice dois être numérique bouffon");
                    indice.Text = "";
                    indice.Focus();
                    return;
                }
                else if (result && (_indice < 0 || _indice > 120))
                {
                    MessageBox.Show("L'indice dois être superrieur ou égale 0 et inférieur ou égale à 120,\nC'est pourtant écris à coté BOUFFON");
                    indice.Text = "";
                    indice.Focus();
                    return;
                }

                info.Text += "\rChemain complet : " + files[cnt];

                byte[] b1 = File.ReadAllBytes(files[cnt]);
                if (b1.Count() > 0)
                {
                    if (b1.Count() > 4)
                    {
                        info.Text += "\nLe fichier contiens " + b1.Count().ToString() + " Bytes";
                        for (int cnt2 = 0; cnt2 < b1.Length; cnt2++)
                            b1[cnt2] -= _indice;

                        info.Text += "\nAnalyse du fichier";
                        if (b1.Count() > 4 && b1[b1.Count() - 4] == 48 && b1[b1.Count() - 3] == 48 && b1[b1.Count() - 2] == 57)
                        {
                            if (copy.Checked)
                            {
                                try
                                {
                                    File.Copy(files[cnt], files[cnt] + ".bak");
                                    info.Text += "\nBack up de fichier a été fait sous le nom :\n" + files[cnt] + ".bak";
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Impossible de faire un Backup, sois un autre fichier existe déja qui porte le nom :\n" + files[cnt] + ".bak\nOu espace disque insufisant.\n\n" + ex.ToString());
                                    Close();
                                }
                            }
                            else
                                info.Text += "\nLe fichier source sera écrasé.";

                            info.Text += "\nFichier Crypté.\nDécryptage en cours...";

                            byte[] b2 = new byte[b1.Count() - 4];
                            for (int cnt2 = 0; cnt2 < b2.Count(); cnt2++)
                                b2[cnt2] = b1[cnt2];
                            File.WriteAllBytes(files[cnt], b2);
                            string newPath;
                            if (b1.Last() == 116)
                                newPath = files[cnt].Substring(0, files[cnt].IndexOf('.')) + ".txt";
                            else if (b1.Last() == 109)
                                newPath = files[cnt].Substring(0, files[cnt].IndexOf('.')) + ".mp3";
                            else if (b1.Last() == 106)
                                newPath = files[cnt].Substring(0, files[cnt].IndexOf('.')) + ".jpg";
                            else if (b1.Last() == 112)
                                newPath = files[cnt].Substring(0, files[cnt].IndexOf('.')) + ".png";
                            else if (b1.Last() == 103)
                                newPath = files[cnt].Substring(0, files[cnt].IndexOf('.')) + ".gif";
                            else
                            {
                                newPath = files[cnt].Substring(0, files[cnt].IndexOf('.')) + ".dat";
                                info.Text += "\nExtension d'origine inconnue, Byte[" + b2.Last() + "] Ascii[" + Convert.ToChar(b1.Last()) + "]";
                            }

                            try
                            {
                                File.Move(files[cnt], newPath);
                                info.Text += "\nFichier rennomé en :" + newPath;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("\nImpossible de renommé le fichier :\n" + files[cnt] + "\nen:\n" + newPath + "\n\n" + ex.ToString(), "Error Writing file");
                                Close();
                            }

                            info.Text += "\nFichier Décrypté avec succée.";
                            files[cnt] = "";
                            if (b1.Count() == 4)
                                info.Text += "\nFichier décrypté mais vide,Code = 3 Bytes + 1 Byte extension";

                            info.Text += System.Environment.NewLine;
                        }
                        else
                            MessageBox.Show("Ce fichier n'est pas crypté, ou endommagé");
                    }
                    else
                        MessageBox.Show("Ce fichier n'est pas crypté, ou endommagé");
                }
                else
                    MessageBox.Show("Le fichier source est vide");    
            }

            MessageBox.Show(files.Count + " fichiers ont étés décryptés", "Succée", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            button1.Enabled = true;
            crypt.Enabled = true;
            decrypt.Enabled = true;

            info.SelectionStart = info.Text.Length - 1;
            info.SelectionLength = 0;
            info.ScrollToCaret();
        }
    }
}
