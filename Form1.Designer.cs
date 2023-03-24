namespace ConvertImage
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectDes = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(205, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(12, 53);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(187, 29);
            this.SelectFolder.TabIndex = 2;
            this.SelectFolder.Text = "Select Images Folder";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Count";
            // 
            // SelectDes
            // 
            this.SelectDes.Location = new System.Drawing.Point(12, 88);
            this.SelectDes.Name = "SelectDes";
            this.SelectDes.Size = new System.Drawing.Size(187, 29);
            this.SelectDes.TabIndex = 4;
            this.SelectDes.Text = "Select Folder Destination";
            this.SelectDes.UseVisualStyleBackColor = true;
            this.SelectDes.Click += new System.EventHandler(this.SelectDes_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(422, 21);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 52);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 126);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(389, 87);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 236);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(389, 87);
            this.textBox4.TabIndex = 7;
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 223);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SelectDes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ConvertImageApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button SelectFolder;
        private Label label1;
        private Button SelectDes;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}