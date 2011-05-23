namespace WinUploader
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLocate = new System.Windows.Forms.Button();
            this.txbFileLocation = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txbEmailAddress = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelfLocate = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnLocate
            // 
            this.btnLocate.Location = new System.Drawing.Point(290, 12);
            this.btnLocate.Name = "btnLocate";
            this.btnLocate.Size = new System.Drawing.Size(175, 23);
            this.btnLocate.TabIndex = 0;
            this.btnLocate.Text = "Find Minecraft Stats";
            this.btnLocate.UseVisualStyleBackColor = true;
            this.btnLocate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbFileLocation
            // 
            this.txbFileLocation.Location = new System.Drawing.Point(12, 12);
            this.txbFileLocation.Name = "txbFileLocation";
            this.txbFileLocation.Size = new System.Drawing.Size(272, 20);
            this.txbFileLocation.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(290, 227);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(175, 23);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "UploadStats";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txbEmailAddress
            // 
            this.txbEmailAddress.Location = new System.Drawing.Point(12, 77);
            this.txbEmailAddress.Name = "txbEmailAddress";
            this.txbEmailAddress.Size = new System.Drawing.Size(272, 20);
            this.txbEmailAddress.TabIndex = 3;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(13, 113);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(271, 20);
            this.txbPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "StartStop.me Registered Email ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "StartStop.me Password";
            // 
            // btnSelfLocate
            // 
            this.btnSelfLocate.Location = new System.Drawing.Point(290, 42);
            this.btnSelfLocate.Name = "btnSelfLocate";
            this.btnSelfLocate.Size = new System.Drawing.Size(175, 23);
            this.btnSelfLocate.TabIndex = 7;
            this.btnSelfLocate.Text = "Locate Yourself";
            this.btnSelfLocate.UseVisualStyleBackColor = true;
            this.btnSelfLocate.Click += new System.EventHandler(this.btnSelfLocate_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 156);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(253, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "If you do not have a startstop.me account click here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(16, 189);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(199, 25);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Upload Complete!";
            this.lblMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 262);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSelfLocate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbEmailAddress);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txbFileLocation);
            this.Controls.Add(this.btnLocate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLocate;
        private System.Windows.Forms.TextBox txbFileLocation;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txbEmailAddress;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelfLocate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblMessage;
    }
}

