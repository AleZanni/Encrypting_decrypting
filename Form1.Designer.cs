namespace Encrypting_Machine
{
    partial class Fomr1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fomr1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EnterPass = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.encryptedPass = new System.Windows.Forms.TextBox();
            this.labelOut = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.tryAgain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DecryptLable = new System.Windows.Forms.Label();
            this.DecrypText = new System.Windows.Forms.TextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.Decryptresoultbox = new System.Windows.Forms.TextBox();
            this.Decrypttextbox = new System.Windows.Forms.Label();
            this.Decryptnew = new System.Windows.Forms.Button();
            this.DecryptKey = new System.Windows.Forms.TextBox();
            this.DecryptLablekey = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.textBox1.Location = new System.Drawing.Point(502, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // EnterPass
            // 
            this.EnterPass.AutoSize = true;
            this.EnterPass.Location = new System.Drawing.Point(499, 36);
            this.EnterPass.Name = "EnterPass";
            this.EnterPass.Size = new System.Drawing.Size(249, 23);
            this.EnterPass.TabIndex = 2;
            this.EnterPass.Text = "Enter password to encrypt:";
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(537, 149);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(151, 23);
            this.Key.TabIndex = 3;
            this.Key.Text = "Enter key value:";
            // 
            // keyBox
            // 
            this.keyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.keyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.keyBox.Location = new System.Drawing.Point(541, 190);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(100, 30);
            this.keyBox.TabIndex = 4;
            this.keyBox.TextChanged += new System.EventHandler(this.KeyBox_TextChanged);
            // 
            // encryptedPass
            // 
            this.encryptedPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.encryptedPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.encryptedPass.Location = new System.Drawing.Point(502, 457);
            this.encryptedPass.Name = "encryptedPass";
            this.encryptedPass.ReadOnly = true;
            this.encryptedPass.Size = new System.Drawing.Size(237, 30);
            this.encryptedPass.TabIndex = 5;
            this.encryptedPass.TextChanged += new System.EventHandler(this.EncryptedPass_TextChanged);
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(499, 412);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(241, 23);
            this.labelOut.TabIndex = 6;
            this.labelOut.Text = "Your encrypted password:";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
            this.Start.Location = new System.Drawing.Point(541, 241);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(157, 148);
            this.Start.TabIndex = 7;
            this.Start.TabStop = false;
            this.Start.UseMnemonic = false;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // tryAgain
            // 
            this.tryAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tryAgain.Location = new System.Drawing.Point(529, 514);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(180, 31);
            this.tryAgain.TabIndex = 8;
            this.tryAgain.Text = "Create New";
            this.tryAgain.UseVisualStyleBackColor = false;
            this.tryAgain.Click += new System.EventHandler(this.TryAgain_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 573);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "CRYPTO";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 89);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 89);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DecryptLable
            // 
            this.DecryptLable.AutoSize = true;
            this.DecryptLable.Location = new System.Drawing.Point(498, 36);
            this.DecryptLable.Name = "DecryptLable";
            this.DecryptLable.Size = new System.Drawing.Size(250, 23);
            this.DecryptLable.TabIndex = 10;
            this.DecryptLable.Text = "Enter password to decrypt:";
            // 
            // DecrypText
            // 
            this.DecrypText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.DecrypText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecrypText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.DecrypText.Location = new System.Drawing.Point(503, 76);
            this.DecrypText.Name = "DecrypText";
            this.DecrypText.Size = new System.Drawing.Size(245, 30);
            this.DecrypText.TabIndex = 11;
            this.DecrypText.TextChanged += new System.EventHandler(this.DecrypText_TextChanged);
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.DecryptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DecryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptButton.FlatAppearance.BorderSize = 0;
            this.DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptButton.Image = ((System.Drawing.Image)(resources.GetObject("DecryptButton.Image")));
            this.DecryptButton.Location = new System.Drawing.Point(541, 131);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(157, 148);
            this.DecryptButton.TabIndex = 12;
            this.DecryptButton.TabStop = false;
            this.DecryptButton.UseMnemonic = false;
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // Decryptresoultbox
            // 
            this.Decryptresoultbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Decryptresoultbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Decryptresoultbox.Location = new System.Drawing.Point(503, 341);
            this.Decryptresoultbox.Name = "Decryptresoultbox";
            this.Decryptresoultbox.ReadOnly = true;
            this.Decryptresoultbox.Size = new System.Drawing.Size(236, 30);
            this.Decryptresoultbox.TabIndex = 13;
            this.Decryptresoultbox.TextChanged += new System.EventHandler(this.Decryptresoultbox_TextChanged);
            // 
            // Decrypttextbox
            // 
            this.Decrypttextbox.AutoSize = true;
            this.Decrypttextbox.Location = new System.Drawing.Point(499, 304);
            this.Decrypttextbox.Name = "Decrypttextbox";
            this.Decrypttextbox.Size = new System.Drawing.Size(242, 23);
            this.Decrypttextbox.TabIndex = 14;
            this.Decrypttextbox.Text = "Your decrypted password:";
            // 
            // Decryptnew
            // 
            this.Decryptnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Decryptnew.Location = new System.Drawing.Point(529, 514);
            this.Decryptnew.Name = "Decryptnew";
            this.Decryptnew.Size = new System.Drawing.Size(180, 31);
            this.Decryptnew.TabIndex = 15;
            this.Decryptnew.Text = "Decrypt New";
            this.Decryptnew.UseVisualStyleBackColor = false;
            this.Decryptnew.Click += new System.EventHandler(this.Decryptnew_Click);
            // 
            // DecryptKey
            // 
            this.DecryptKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.DecryptKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecryptKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.DecryptKey.Location = new System.Drawing.Point(558, 438);
            this.DecryptKey.Name = "DecryptKey";
            this.DecryptKey.ReadOnly = true;
            this.DecryptKey.Size = new System.Drawing.Size(100, 30);
            this.DecryptKey.TabIndex = 16;
            this.DecryptKey.TextChanged += new System.EventHandler(this.DecryptKey_TextChanged);
            // 
            // DecryptLablekey
            // 
            this.DecryptLablekey.AutoSize = true;
            this.DecryptLablekey.Location = new System.Drawing.Point(554, 392);
            this.DecryptLablekey.Name = "DecryptLablekey";
            this.DecryptLablekey.Size = new System.Drawing.Size(143, 23);
            this.DecryptLablekey.TabIndex = 17;
            this.DecryptLablekey.Text = "Key value used";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1139, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 36);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1082, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 36);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(1082, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 36);
            this.button5.TabIndex = 20;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Fomr1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1190, 573);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DecryptLablekey);
            this.Controls.Add(this.DecryptKey);
            this.Controls.Add(this.Decryptnew);
            this.Controls.Add(this.Decrypttextbox);
            this.Controls.Add(this.Decryptresoultbox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.DecrypText);
            this.Controls.Add(this.DecryptLable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.encryptedPass);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.EnterPass);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fomr1";
            this.Text = "Crypto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label EnterPass;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.TextBox encryptedPass;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button tryAgain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label DecryptLable;
        private System.Windows.Forms.TextBox DecrypText;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox Decryptresoultbox;
        private System.Windows.Forms.Label Decrypttextbox;
        private System.Windows.Forms.Button Decryptnew;
        private System.Windows.Forms.TextBox DecryptKey;
        private System.Windows.Forms.Label DecryptLablekey;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

