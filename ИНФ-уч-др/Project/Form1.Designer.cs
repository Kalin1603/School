namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Character = new System.Windows.Forms.Label();
            this.Champion = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.CharacterTextBox = new System.Windows.Forms.TextBox();
            this.ChampionTextBox = new System.Windows.Forms.TextBox();
            this.LevelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListResult = new System.Windows.Forms.ListBox();
            this.Fight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Character
            // 
            this.Character.AutoSize = true;
            this.Character.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Character.Location = new System.Drawing.Point(48, 58);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(130, 37);
            this.Character.TabIndex = 1;
            this.Character.Text = "Character";
            // 
            // Champion
            // 
            this.Champion.AutoSize = true;
            this.Champion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Champion.Location = new System.Drawing.Point(48, 129);
            this.Champion.Name = "Champion";
            this.Champion.Size = new System.Drawing.Size(140, 37);
            this.Champion.TabIndex = 1;
            this.Champion.Text = "Champion";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Level.Location = new System.Drawing.Point(96, 197);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(82, 40);
            this.Level.TabIndex = 2;
            this.Level.Text = "Level";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(8, 320);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(170, 85);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add to Gulag";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // CharacterTextBox
            // 
            this.CharacterTextBox.Location = new System.Drawing.Point(184, 72);
            this.CharacterTextBox.Name = "CharacterTextBox";
            this.CharacterTextBox.Size = new System.Drawing.Size(147, 23);
            this.CharacterTextBox.TabIndex = 4;
            // 
            // ChampionTextBox
            // 
            this.ChampionTextBox.Location = new System.Drawing.Point(184, 144);
            this.ChampionTextBox.Name = "ChampionTextBox";
            this.ChampionTextBox.Size = new System.Drawing.Size(147, 23);
            this.ChampionTextBox.TabIndex = 4;
            // 
            // LevelTextBox
            // 
            this.LevelTextBox.Location = new System.Drawing.Point(184, 214);
            this.LevelTextBox.Name = "LevelTextBox";
            this.LevelTextBox.Size = new System.Drawing.Size(147, 23);
            this.LevelTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(518, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "GULAG";
            // 
            // ListResult
            // 
            this.ListResult.AccessibleName = "";
            this.ListResult.FormattingEnabled = true;
            this.ListResult.ItemHeight = 15;
            this.ListResult.Location = new System.Drawing.Point(372, 111);
            this.ListResult.Name = "ListResult";
            this.ListResult.Size = new System.Drawing.Size(426, 334);
            this.ListResult.TabIndex = 6;
            // 
            // Fight
            // 
            this.Fight.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fight.Location = new System.Drawing.Point(202, 320);
            this.Fight.Name = "Fight";
            this.Fight.Size = new System.Drawing.Size(164, 85);
            this.Fight.TabIndex = 7;
            this.Fight.Text = "Fight";
            this.Fight.UseVisualStyleBackColor = true;
            this.Fight.Click += new System.EventHandler(this.Fight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fight);
            this.Controls.Add(this.ListResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LevelTextBox);
            this.Controls.Add(this.ChampionTextBox);
            this.Controls.Add(this.CharacterTextBox);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.Champion);
            this.Controls.Add(this.Character);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Character;
        private System.Windows.Forms.Label Champion;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox CharacterTextBox;
        private System.Windows.Forms.TextBox ChampionTextBox;
        private System.Windows.Forms.TextBox LevelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListResult;
        private System.Windows.Forms.Button Fight;
    }
}

