namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessProgressBar = new System.Windows.Forms.ProgressBar();
            this.SavePathTextInput = new System.Windows.Forms.TextBox();
            this.YoutubeLinkTextInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileNameTextInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OpenFolderDialogueButton = new System.Windows.Forms.Button();
            this.DowloadMp3Button = new System.Windows.Forms.Button();
            this.DownloadVideoButton = new System.Windows.Forms.Button();
            this.ProcessLabel = new System.Windows.Forms.Label();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path To Save";
            // 
            // ProcessProgressBar
            // 
            this.ProcessProgressBar.Location = new System.Drawing.Point(12, 195);
            this.ProcessProgressBar.Name = "ProcessProgressBar";
            this.ProcessProgressBar.Size = new System.Drawing.Size(294, 23);
            this.ProcessProgressBar.TabIndex = 1;
            this.ProcessProgressBar.Visible = false;
            // 
            // SavePathTextInput
            // 
            this.SavePathTextInput.Location = new System.Drawing.Point(12, 25);
            this.SavePathTextInput.Name = "SavePathTextInput";
            this.SavePathTextInput.Size = new System.Drawing.Size(229, 20);
            this.SavePathTextInput.TabIndex = 2;
            // 
            // YoutubeLinkTextInput
            // 
            this.YoutubeLinkTextInput.Location = new System.Drawing.Point(12, 70);
            this.YoutubeLinkTextInput.Name = "YoutubeLinkTextInput";
            this.YoutubeLinkTextInput.Size = new System.Drawing.Size(294, 20);
            this.YoutubeLinkTextInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Youtube Link";
            // 
            // FileNameTextInput
            // 
            this.FileNameTextInput.Location = new System.Drawing.Point(12, 114);
            this.FileNameTextInput.Name = "FileNameTextInput";
            this.FileNameTextInput.Size = new System.Drawing.Size(294, 20);
            this.FileNameTextInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result File Name";
            // 
            // OpenFolderDialogueButton
            // 
            this.OpenFolderDialogueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFolderDialogueButton.Location = new System.Drawing.Point(247, 24);
            this.OpenFolderDialogueButton.Name = "OpenFolderDialogueButton";
            this.OpenFolderDialogueButton.Size = new System.Drawing.Size(59, 20);
            this.OpenFolderDialogueButton.TabIndex = 7;
            this.OpenFolderDialogueButton.Text = "...";
            this.OpenFolderDialogueButton.UseVisualStyleBackColor = true;
            this.OpenFolderDialogueButton.Click += new System.EventHandler(this.OpenFolderDialogueButton_Click);
            // 
            // DowloadMp3Button
            // 
            this.DowloadMp3Button.Location = new System.Drawing.Point(12, 144);
            this.DowloadMp3Button.Name = "DowloadMp3Button";
            this.DowloadMp3Button.Size = new System.Drawing.Size(134, 23);
            this.DowloadMp3Button.TabIndex = 8;
            this.DowloadMp3Button.Text = "DOWNLOAD MP3";
            this.DowloadMp3Button.UseVisualStyleBackColor = true;
            this.DowloadMp3Button.Click += new System.EventHandler(this.DowloadMp3Button_Click);
            // 
            // DownloadVideoButton
            // 
            this.DownloadVideoButton.Location = new System.Drawing.Point(172, 144);
            this.DownloadVideoButton.Name = "DownloadVideoButton";
            this.DownloadVideoButton.Size = new System.Drawing.Size(134, 23);
            this.DownloadVideoButton.TabIndex = 9;
            this.DownloadVideoButton.Text = "DOWNLOAD VIDEO";
            this.DownloadVideoButton.UseVisualStyleBackColor = true;
            this.DownloadVideoButton.Click += new System.EventHandler(this.DownloadVideoButton_Click);
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.AutoSize = true;
            this.ProcessLabel.Location = new System.Drawing.Point(12, 179);
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(73, 13);
            this.ProcessLabel.TabIndex = 10;
            this.ProcessLabel.Text = "Path To Save";
            this.ProcessLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 230);
            this.Controls.Add(this.ProcessLabel);
            this.Controls.Add(this.DownloadVideoButton);
            this.Controls.Add(this.DowloadMp3Button);
            this.Controls.Add(this.OpenFolderDialogueButton);
            this.Controls.Add(this.FileNameTextInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YoutubeLinkTextInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SavePathTextInput);
            this.Controls.Add(this.ProcessProgressBar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Youtube Downloader v1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ProcessProgressBar;
        private System.Windows.Forms.TextBox SavePathTextInput;
        private System.Windows.Forms.TextBox YoutubeLinkTextInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileNameTextInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OpenFolderDialogueButton;
        private System.Windows.Forms.Button DowloadMp3Button;
        private System.Windows.Forms.Button DownloadVideoButton;
        private System.Windows.Forms.Label ProcessLabel;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
    }
}

