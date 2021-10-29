
namespace AU_AudioPlayer
{
    partial class MainWindow
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
            this.currentlyPlaying1 = new System.Windows.Forms.Label();
            this.trackNameDisplay = new System.Windows.Forms.Label();
            this.queueList = new System.Windows.Forms.ListBox();
            this.artistNameDisplay = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.loginMode = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.loginMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentlyPlaying1
            // 
            this.currentlyPlaying1.AutoSize = true;
            this.currentlyPlaying1.BackColor = System.Drawing.Color.Transparent;
            this.currentlyPlaying1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.currentlyPlaying1.Location = new System.Drawing.Point(12, 54);
            this.currentlyPlaying1.Name = "currentlyPlaying1";
            this.currentlyPlaying1.Size = new System.Drawing.Size(194, 32);
            this.currentlyPlaying1.TabIndex = 4;
            this.currentlyPlaying1.Text = "Currently playing:";
            // 
            // trackNameDisplay
            // 
            this.trackNameDisplay.AutoSize = true;
            this.trackNameDisplay.BackColor = System.Drawing.Color.Transparent;
            this.trackNameDisplay.Location = new System.Drawing.Point(15, 86);
            this.trackNameDisplay.Name = "trackNameDisplay";
            this.trackNameDisplay.Size = new System.Drawing.Size(149, 21);
            this.trackNameDisplay.TabIndex = 5;
            this.trackNameDisplay.Text = "Nothing is playing :(";
            // 
            // queueList
            // 
            this.queueList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.queueList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queueList.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.queueList.ForeColor = System.Drawing.Color.White;
            this.queueList.FormattingEnabled = true;
            this.queueList.ItemHeight = 17;
            this.queueList.Location = new System.Drawing.Point(540, 12);
            this.queueList.Name = "queueList";
            this.queueList.Size = new System.Drawing.Size(180, 238);
            this.queueList.TabIndex = 6;
            this.queueList.SelectedIndexChanged += new System.EventHandler(this.queueList_SelectedIndexChanged);
            // 
            // artistNameDisplay
            // 
            this.artistNameDisplay.AutoSize = true;
            this.artistNameDisplay.BackColor = System.Drawing.Color.Transparent;
            this.artistNameDisplay.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.artistNameDisplay.Location = new System.Drawing.Point(15, 107);
            this.artistNameDisplay.Name = "artistNameDisplay";
            this.artistNameDisplay.Size = new System.Drawing.Size(197, 42);
            this.artistNameDisplay.TabIndex = 7;
            this.artistNameDisplay.Text = "Spin some tracks by adding\r\nfiles to the queue!";
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.Transparent;
            this.previousButton.FlatAppearance.BorderSize = 0;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Location = new System.Drawing.Point(12, 180);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 8;
            this.previousButton.Text = "";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(93, 180);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 9;
            this.playButton.Text = "";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(174, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundButton
            // 
            this.backgroundButton.BackColor = System.Drawing.Color.Transparent;
            this.backgroundButton.FlatAppearance.BorderSize = 0;
            this.backgroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroundButton.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundButton.Location = new System.Drawing.Point(12, 12);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(200, 23);
            this.backgroundButton.TabIndex = 11;
            this.backgroundButton.Text = "Change Background";
            this.backgroundButton.UseVisualStyleBackColor = false;
            this.backgroundButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // loginMode
            // 
            this.loginMode.Controls.Add(this.button2);
            this.loginMode.Controls.Add(this.label2);
            this.loginMode.Controls.Add(this.passwordBox);
            this.loginMode.Controls.Add(this.userBox);
            this.loginMode.Controls.Add(this.textBox1);
            this.loginMode.Controls.Add(this.label1);
            this.loginMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginMode.Location = new System.Drawing.Point(0, 0);
            this.loginMode.Name = "loginMode";
            this.loginMode.Size = new System.Drawing.Size(732, 268);
            this.loginMode.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log in";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 1;
            // 
            // userBox
            // 
            this.userBox.AutoSize = true;
            this.userBox.Location = new System.Drawing.Point(8, 65);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(79, 21);
            this.userBox.TabIndex = 2;
            this.userBox.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.ForeColor = System.Drawing.Color.White;
            this.passwordBox.Location = new System.Drawing.Point(12, 152);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(155, 22);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(9, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 268);
            this.Controls.Add(this.loginMode);
            this.Controls.Add(this.backgroundButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.artistNameDisplay);
            this.Controls.Add(this.queueList);
            this.Controls.Add(this.trackNameDisplay);
            this.Controls.Add(this.currentlyPlaying1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "AU AudioPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginMode.ResumeLayout(false);
            this.loginMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentlyPlaying1;
        private System.Windows.Forms.Label trackNameDisplay;
        private System.Windows.Forms.ListBox queueList;
        private System.Windows.Forms.Label artistNameDisplay;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backgroundButton;
        private System.Windows.Forms.Panel loginMode;
        private System.Windows.Forms.Label userBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button button2;
    }
}

