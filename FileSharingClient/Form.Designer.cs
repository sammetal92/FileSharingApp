namespace WindowsFormsApplication1
{
    partial class Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.file = new System.Windows.Forms.TextBox();
            this.browse_button = new System.Windows.Forms.Button();
            this.upload_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "File";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(125, 66);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(154, 20);
            this.ip.TabIndex = 3;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(125, 109);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(154, 20);
            this.port.TabIndex = 4;
            // 
            // file
            // 
            this.file.Enabled = false;
            this.file.Location = new System.Drawing.Point(125, 155);
            this.file.Name = "file";
            this.file.ReadOnly = true;
            this.file.Size = new System.Drawing.Size(154, 20);
            this.file.TabIndex = 5;
            this.file.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(294, 153);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(75, 23);
            this.browse_button.TabIndex = 6;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(125, 208);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(75, 23);
            this.upload_button.TabIndex = 7;
            this.upload_button.Text = "Upload";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 320);
            this.Controls.Add(this.upload_button);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.file);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox file;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.Button upload_button;
    }
}

