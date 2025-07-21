namespace webbrwoser
{
    partial class Form1
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
            this.Adress = new System.Windows.Forms.Label();
            this.Gotoadresse = new System.Windows.Forms.TextBox();
            this.Goadress = new System.Windows.Forms.Button();
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView = new EO.WebBrowser.WebView();
            this.find = new System.Windows.Forms.Button();
            this.httpsadress = new System.Windows.Forms.TextBox();
            this.https = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adress.Location = new System.Drawing.Point(0, 26);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(50, 16);
            this.Adress.TabIndex = 1;
            this.Adress.Text = "Adress";
            // 
            // Gotoadresse
            // 
            this.Gotoadresse.Location = new System.Drawing.Point(56, 26);
            this.Gotoadresse.Name = "Gotoadresse";
            this.Gotoadresse.Size = new System.Drawing.Size(335, 20);
            this.Gotoadresse.TabIndex = 2;
            // 
            // Goadress
            // 
            this.Goadress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Goadress.Location = new System.Drawing.Point(397, 24);
            this.Goadress.Name = "Goadress";
            this.Goadress.Size = new System.Drawing.Size(78, 21);
            this.Goadress.TabIndex = 3;
            this.Goadress.Text = "GO";
            this.Goadress.UseVisualStyleBackColor = true;
            this.Goadress.Click += new System.EventHandler(this.Goadress_Click);
            // 
            // webControl1
            // 
            this.webControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Location = new System.Drawing.Point(3, 74);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(820, 375);
            this.webControl1.TabIndex = 6;
            this.webControl1.Text = "webControl1";
            this.webControl1.WebView = this.webView;
            // 
            // webView
            // 
            this.webView.DisableInputMsgRouting = false;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(481, 23);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(89, 22);
            this.find.TabIndex = 7;
            this.find.Text = "find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // httpsadress
            // 
            this.httpsadress.Location = new System.Drawing.Point(56, 48);
            this.httpsadress.Name = "httpsadress";
            this.httpsadress.Size = new System.Drawing.Size(335, 20);
            this.httpsadress.TabIndex = 8;
            // 
            // https
            // 
            this.https.AutoSize = true;
            this.https.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.https.Location = new System.Drawing.Point(0, 52);
            this.https.Name = "https";
            this.https.Size = new System.Drawing.Size(38, 16);
            this.https.TabIndex = 9;
            this.https.Text = "https:";
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Snow;
            this.closebutton.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.closebutton.ForeColor = System.Drawing.Color.Red;
            this.closebutton.Location = new System.Drawing.Point(765, 2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(67, 22);
            this.closebutton.TabIndex = 10;
            this.closebutton.Text = "X";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            this.closebutton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.closebutton_KeyDown);
            this.closebutton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.closebutton_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.https);
            this.Controls.Add(this.httpsadress);
            this.Controls.Add(this.find);
            this.Controls.Add(this.webControl1);
            this.Controls.Add(this.Goadress);
            this.Controls.Add(this.Gotoadresse);
            this.Controls.Add(this.Adress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.TextBox Gotoadresse;
        private System.Windows.Forms.Button Goadress;
        private EO.WinForm.WebControl webControl1;
        private EO.WebBrowser.WebView webView;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox httpsadress;
        private System.Windows.Forms.Label https;
        private System.Windows.Forms.Button closebutton;
    }
}

