namespace Personal_Music_Collection
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
            this.albumListBox = new System.Windows.Forms.ListBox();
            this.songsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.albumNameTextBox = new System.Windows.Forms.TextBox();
            this.albumArtistTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.songTitleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.songLengthTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.songArtistTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.onEditRadioButton = new System.Windows.Forms.RadioButton();
            this.offEditRadioButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.deleteSongButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.addOffRadioButton = new System.Windows.Forms.RadioButton();
            this.addOnRadioButton = new System.Windows.Forms.RadioButton();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.addSongButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.deleteAlbumButton = new System.Windows.Forms.Button();
            this.songAlbumTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // albumListBox
            // 
            this.albumListBox.FormattingEnabled = true;
            this.albumListBox.ItemHeight = 16;
            this.albumListBox.Location = new System.Drawing.Point(12, 43);
            this.albumListBox.Name = "albumListBox";
            this.albumListBox.Size = new System.Drawing.Size(201, 276);
            this.albumListBox.TabIndex = 0;
            this.albumListBox.SelectedIndexChanged += new System.EventHandler(this.AlbumListBox_SelectedIndexChanged);
            // 
            // songsListBox
            // 
            this.songsListBox.FormattingEnabled = true;
            this.songsListBox.ItemHeight = 16;
            this.songsListBox.Location = new System.Drawing.Point(244, 43);
            this.songsListBox.Name = "songsListBox";
            this.songsListBox.Size = new System.Drawing.Size(209, 276);
            this.songsListBox.TabIndex = 1;
            this.songsListBox.SelectedIndexChanged += new System.EventHandler(this.SongsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Albums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Songs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // albumNameTextBox
            // 
            this.albumNameTextBox.Location = new System.Drawing.Point(514, 43);
            this.albumNameTextBox.Name = "albumNameTextBox";
            this.albumNameTextBox.ReadOnly = true;
            this.albumNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.albumNameTextBox.TabIndex = 5;
            // 
            // albumArtistTextBox
            // 
            this.albumArtistTextBox.Location = new System.Drawing.Point(514, 99);
            this.albumArtistTextBox.Name = "albumArtistTextBox";
            this.albumArtistTextBox.ReadOnly = true;
            this.albumArtistTextBox.Size = new System.Drawing.Size(160, 22);
            this.albumArtistTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year:";
            // 
            // songTitleTextBox
            // 
            this.songTitleTextBox.Location = new System.Drawing.Point(514, 231);
            this.songTitleTextBox.Name = "songTitleTextBox";
            this.songTitleTextBox.ReadOnly = true;
            this.songTitleTextBox.Size = new System.Drawing.Size(160, 22);
            this.songTitleTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Title:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(514, 71);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(160, 22);
            this.yearTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Artist:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(459, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Song";
            // 
            // songLengthTextBox
            // 
            this.songLengthTextBox.Location = new System.Drawing.Point(514, 259);
            this.songLengthTextBox.Name = "songLengthTextBox";
            this.songLengthTextBox.ReadOnly = true;
            this.songLengthTextBox.Size = new System.Drawing.Size(160, 22);
            this.songLengthTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Length:";
            // 
            // songArtistTextBox
            // 
            this.songArtistTextBox.Location = new System.Drawing.Point(514, 287);
            this.songArtistTextBox.Name = "songArtistTextBox";
            this.songArtistTextBox.ReadOnly = true;
            this.songArtistTextBox.Size = new System.Drawing.Size(160, 22);
            this.songArtistTextBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Artist:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(456, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Album";
            // 
            // onEditRadioButton
            // 
            this.onEditRadioButton.AutoSize = true;
            this.onEditRadioButton.Location = new System.Drawing.Point(713, 166);
            this.onEditRadioButton.Name = "onEditRadioButton";
            this.onEditRadioButton.Size = new System.Drawing.Size(50, 21);
            this.onEditRadioButton.TabIndex = 18;
            this.onEditRadioButton.TabStop = true;
            this.onEditRadioButton.Text = "ON";
            this.onEditRadioButton.UseVisualStyleBackColor = true;
            this.onEditRadioButton.CheckedChanged += new System.EventHandler(this.OnEditRadioButton_CheckedChanged);
            // 
            // offEditRadioButton
            // 
            this.offEditRadioButton.AutoSize = true;
            this.offEditRadioButton.Location = new System.Drawing.Point(713, 193);
            this.offEditRadioButton.Name = "offEditRadioButton";
            this.offEditRadioButton.Size = new System.Drawing.Size(56, 21);
            this.offEditRadioButton.TabIndex = 19;
            this.offEditRadioButton.TabStop = true;
            this.offEditRadioButton.Text = "OFF";
            this.offEditRadioButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(710, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Edit Mode";
            // 
            // deleteSongButton
            // 
            this.deleteSongButton.Location = new System.Drawing.Point(244, 330);
            this.deleteSongButton.Name = "deleteSongButton";
            this.deleteSongButton.Size = new System.Drawing.Size(75, 36);
            this.deleteSongButton.TabIndex = 21;
            this.deleteSongButton.Text = "Delete";
            this.deleteSongButton.UseVisualStyleBackColor = true;
            this.deleteSongButton.Visible = false;
            this.deleteSongButton.Click += new System.EventHandler(this.DeleteSongButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(713, 283);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 36);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(710, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "Add Mode";
            // 
            // addOffRadioButton
            // 
            this.addOffRadioButton.AutoSize = true;
            this.addOffRadioButton.Location = new System.Drawing.Point(713, 86);
            this.addOffRadioButton.Name = "addOffRadioButton";
            this.addOffRadioButton.Size = new System.Drawing.Size(56, 21);
            this.addOffRadioButton.TabIndex = 24;
            this.addOffRadioButton.TabStop = true;
            this.addOffRadioButton.Text = "OFF";
            this.addOffRadioButton.UseVisualStyleBackColor = true;
            // 
            // addOnRadioButton
            // 
            this.addOnRadioButton.AutoSize = true;
            this.addOnRadioButton.Location = new System.Drawing.Point(713, 59);
            this.addOnRadioButton.Name = "addOnRadioButton";
            this.addOnRadioButton.Size = new System.Drawing.Size(50, 21);
            this.addOnRadioButton.TabIndex = 23;
            this.addOnRadioButton.TabStop = true;
            this.addOnRadioButton.Text = "ON";
            this.addOnRadioButton.UseVisualStyleBackColor = true;
            this.addOnRadioButton.CheckedChanged += new System.EventHandler(this.AddOnRadioButton_CheckedChanged);
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.Location = new System.Drawing.Point(514, 132);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(160, 48);
            this.addAlbumButton.TabIndex = 26;
            this.addAlbumButton.Text = "Add Album";
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Visible = false;
            this.addAlbumButton.Click += new System.EventHandler(this.AddAlbumButton_Click);
            // 
            // addSongButton
            // 
            this.addSongButton.Location = new System.Drawing.Point(514, 318);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(160, 48);
            this.addSongButton.TabIndex = 27;
            this.addSongButton.Text = "Add Song";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Visible = false;
            this.addSongButton.Click += new System.EventHandler(this.AddSongButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(401, 359);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 29);
            this.closeButton.TabIndex = 28;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // deleteAlbumButton
            // 
            this.deleteAlbumButton.Location = new System.Drawing.Point(12, 330);
            this.deleteAlbumButton.Name = "deleteAlbumButton";
            this.deleteAlbumButton.Size = new System.Drawing.Size(75, 36);
            this.deleteAlbumButton.TabIndex = 29;
            this.deleteAlbumButton.Text = "Delete";
            this.deleteAlbumButton.UseVisualStyleBackColor = true;
            this.deleteAlbumButton.Visible = false;
            this.deleteAlbumButton.Click += new System.EventHandler(this.DeleteAlbumButton_Click);
            // 
            // songAlbumTextBox
            // 
            this.songAlbumTextBox.Location = new System.Drawing.Point(514, 318);
            this.songAlbumTextBox.Name = "songAlbumTextBox";
            this.songAlbumTextBox.Size = new System.Drawing.Size(160, 22);
            this.songAlbumTextBox.TabIndex = 30;
            this.songAlbumTextBox.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(457, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Album:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.songAlbumTextBox);
            this.Controls.Add(this.deleteAlbumButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addSongButton);
            this.Controls.Add(this.addAlbumButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.addOffRadioButton);
            this.Controls.Add(this.addOnRadioButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteSongButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.offEditRadioButton);
            this.Controls.Add(this.onEditRadioButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.songArtistTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.songLengthTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.songTitleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.albumArtistTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.albumNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songsListBox);
            this.Controls.Add(this.albumListBox);
            this.Name = "Form1";
            this.Text = "Personal Music Collection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox albumListBox;
        private System.Windows.Forms.ListBox songsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox albumNameTextBox;
        private System.Windows.Forms.TextBox albumArtistTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox songTitleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox songLengthTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox songArtistTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton onEditRadioButton;
        private System.Windows.Forms.RadioButton offEditRadioButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button deleteSongButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton addOffRadioButton;
        private System.Windows.Forms.RadioButton addOnRadioButton;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button deleteAlbumButton;
        private System.Windows.Forms.TextBox songAlbumTextBox;
        private System.Windows.Forms.Label label13;
    }
}

