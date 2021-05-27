namespace Pharmacy_FormsApp
{
    partial class MainForm
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
            System.Windows.Forms.Button addPharmacyButton;
            this.addMedicine = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            addPharmacyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPharmacyButton
            // 
            addPharmacyButton.Location = new System.Drawing.Point(267, 81);
            addPharmacyButton.Name = "addPharmacyButton";
            addPharmacyButton.Size = new System.Drawing.Size(130, 61);
            addPharmacyButton.TabIndex = 3;
            addPharmacyButton.Text = "AddPharmacy";
            addPharmacyButton.UseVisualStyleBackColor = true;
            addPharmacyButton.Click += new System.EventHandler(this.addPharmacyButton_Click);
            // 
            // addMedicine
            // 
            this.addMedicine.Location = new System.Drawing.Point(267, 12);
            this.addMedicine.Name = "addMedicine";
            this.addMedicine.Size = new System.Drawing.Size(130, 63);
            this.addMedicine.TabIndex = 0;
            this.addMedicine.Text = "Add Medicine";
            this.addMedicine.UseVisualStyleBackColor = true;
            this.addMedicine.Click += new System.EventHandler(this.addMedicine_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 238);
            this.listBox1.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(267, 258);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(125, 45);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(403, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(267, 238);
            this.listBox2.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(addPharmacyButton);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addMedicine);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMedicine;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ListBox listBox2;
    }
}

