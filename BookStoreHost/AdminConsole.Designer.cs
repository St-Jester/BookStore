namespace BookStoreHost
{
    partial class AdminConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminConsole));
            this.journal = new System.Windows.Forms.TextBox();
            this.InstallGenresButton = new System.Windows.Forms.Button();
            this.InstallAuthorsButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // journal
            // 
            this.journal.Location = new System.Drawing.Point(12, 12);
            this.journal.Multiline = true;
            this.journal.Name = "journal";
            this.journal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.journal.Size = new System.Drawing.Size(541, 238);
            this.journal.TabIndex = 0;
            // 
            // InstallGenresButton
            // 
            this.InstallGenresButton.Location = new System.Drawing.Point(12, 265);
            this.InstallGenresButton.Name = "InstallGenresButton";
            this.InstallGenresButton.Size = new System.Drawing.Size(75, 23);
            this.InstallGenresButton.TabIndex = 1;
            this.InstallGenresButton.Text = "Genres";
            this.InstallGenresButton.UseVisualStyleBackColor = true;
            this.InstallGenresButton.Click += new System.EventHandler(this.InstallGenresButton_Click);
            // 
            // InstallAuthorsButton
            // 
            this.InstallAuthorsButton.Location = new System.Drawing.Point(102, 265);
            this.InstallAuthorsButton.Name = "InstallAuthorsButton";
            this.InstallAuthorsButton.Size = new System.Drawing.Size(75, 23);
            this.InstallAuthorsButton.TabIndex = 1;
            this.InstallAuthorsButton.Text = "Authors";
            this.InstallAuthorsButton.UseVisualStyleBackColor = true;
            this.InstallAuthorsButton.Click += new System.EventHandler(this.InstallAuthorsButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(279, 265);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(75, 23);
            this.BookButton.TabIndex = 2;
            this.BookButton.Text = "Books";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // AdminConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 331);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.InstallAuthorsButton);
            this.Controls.Add(this.InstallGenresButton);
            this.Controls.Add(this.journal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminConsole";
            this.Text = "BookStoreHost";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminConsole_FormClosed);
            this.Load += new System.EventHandler(this.AdminConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox journal;
        private System.Windows.Forms.Button InstallGenresButton;
        private System.Windows.Forms.Button InstallAuthorsButton;
        private System.Windows.Forms.Button BookButton;
    }
}

