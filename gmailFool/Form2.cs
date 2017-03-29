using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Collections;

namespace gmailFool
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        //Decrypt Button
        private void button2_Click(object sender, EventArgs e)
        {
            //string pass = GetMd5Hash(hvad.Text);
            string pass = hvad.Text;
            int keych = pass.Length;
            if (keych < 8)
            {
                MessageBox.Show("You must enter a minimum of 8 characters.");
                Application.Restart();
            }
            string user = Environment.UserName;
            string desk = @"C:\Users\" + user + "\\Desktop\\";
            string targPath = null;
            string targName = null;
            string curDir = Application.StartupPath + "\\";
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.Filter = "FOOL (.fool) | *.fool";
            opnFile.InitialDirectory = curDir;
            if (opnFile.ShowDialog() == DialogResult.OK)
            {
                targPath = opnFile.FileName;
                targName = opnFile.SafeFileName;
                string tarCh = File.ReadAllText(targPath);
                if (targName.Contains(".fool") == true)
                {
                    DecryptFile(targPath, pass);
                    if (tarCh.Contains(pass))
                    {
                        if (File.Exists(curDir + "fileDecrypt.rar"))
                        {
                            File.Delete(curDir + "fileDecrypt.rar");
                        }
                        tarCh.Replace(pass, ".");
                        File.Move(targPath, curDir + "fileDecrypt.rar");
                        MessageBox.Show("Decryption succeeded!\n Never share the unlock key with people you don't trust.");
                        Application.Exit();
                    }
                    else if (tarCh.Contains(pass) == false)
                    {
                        MessageBox.Show("Password invalid.\n Please try again.");
                        Application.Exit();
                    }
                }
            }
        }
        //Encrypt Button
        public void button1_Click(object sender, EventArgs e)
        {
            //string pass = GetMd5Hash(hvad.Text);
            string pass = hvad.Text;
            int keych = pass.Length;
            if (keych < 8)
            {
                MessageBox.Show("You must enter a minimum of 8 characters.");
                Application.Restart();
            }
            string user = Environment.UserName;
            string desk = @"C:\Users\" + user + "\\Desktop\\";
            string targPath = null;
            string targName = null;
            string curDir = Application.StartupPath + "\\";
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.Filter = "RAR (.rar) | *.rar";
            opnFile.InitialDirectory = curDir;
            if (opnFile.ShowDialog() == DialogResult.OK)
            {
                UTF32Encoding utf = new UTF32Encoding();
                targPath = opnFile.FileName;
                targName = opnFile.SafeFileName;
                string tarCh = File.ReadAllText(targPath);
                string fileDecrypt = tarCh;
                if (targName.Contains(".rar") == true)
                {
                    if (File.Exists(curDir + "fileEncrypt.fool"))
                    {
                        File.Delete(curDir + "fileEncrypt.fool");
                    }
                    File.Move(targPath, curDir + "fileEncrypt.fool");
                    EncryptFile(curDir + "fileEncrypt.fool", pass);
                    
                        File.AppendAllText(curDir + "fileEncrypt.fool", Environment.NewLine + pass);
                        MessageBox.Show("Encryption succeeded!\n Never share the unlock key with people you don't trust.");
                        //save key
                        DialogResult saveconfirm = MessageBox.Show("Do you wish to save your key?", "Save key?", MessageBoxButtons.YesNoCancel);
                        if (saveconfirm == DialogResult.Yes)
                        {
                        if (File.Exists(curDir + "foolbackup.key"))
                        {
                            DialogResult saveerror = MessageBox.Show("There is already a key in the application directory. Do you wish to overwrite?\nIf you move the file somewhere else while this window is open\n you can simply click yes and it wont be removed.", "Error!", MessageBoxButtons.YesNo);
                            if (saveerror == DialogResult.Yes)
                            {

                            }
                            else
                            {
                                MessageBox.Show("You chose no.\nApplication will exit now.");
                            }
                        }
                            File.WriteAllText(curDir + "foolbackup.key", pass);
                            EncryptFile(curDir + "foolbackup.key", pass);
                            MessageBox.Show("Key saved in application directory.");
                            Application.Exit();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    
                   
                }
            }
        }
        static void EncryptFile(string curDir, string pass)
        {
            byte[] plainContent = File.ReadAllBytes(curDir);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(pass);
                DES.Key = Encoding.UTF8.GetBytes(pass);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryp = new CryptoStream(memStream, DES.CreateEncryptor(),
                        CryptoStreamMode.Write);

                    cryp.Write(plainContent, 0, plainContent.Length);
                    cryp.FlushFinalBlock();
                    File.WriteAllBytes(curDir, memStream.ToArray());

                }
            }
        }
        static void DecryptFile(string curDir, string pass)
        {
            byte[] ciphContent = File.ReadAllBytes(curDir);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(pass);
                DES.Key = Encoding.UTF8.GetBytes(pass);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryp = new CryptoStream(memStream, DES.CreateDecryptor(),
                        CryptoStreamMode.Write);

                    cryp.Write(ciphContent, 0, ciphContent.Length);
                    File.WriteAllBytes(curDir, memStream.ToArray());
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Never share your key with someone you don't trust!\nIt may increase the risk of the file being compromised.\nEnter a combination of characters and numbers (make these random and not something like 'John1992') and click encrypt/decrypt.\nI would advise you to write your key down on a note/piece of paper and store it somewhere safe.\nThis encrypter is only for use with .rar files.\n I advise you to password protect your .rar files for max security.\n\nThanks for using my program.\nPeace out.");
        }

        public void generatekeyBtn_Click(object sender, EventArgs e)
        {
            hvad.Text = GenerateCoupon();
        }
        public static string GenerateCoupon(int length = 8)
        {
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }

        private void savekey_button_Click(object sender, EventArgs e)
        {
        }

        private void getMD5hash(string enPass)
        {

        }
    }
}
