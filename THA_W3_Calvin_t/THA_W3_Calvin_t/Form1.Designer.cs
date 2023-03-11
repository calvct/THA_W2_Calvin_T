namespace THA_W3_Calvin_t
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.tBox_Age = new System.Windows.Forms.TextBox();
            this.tBox_Email = new System.Windows.Forms.TextBox();
            this.tBox_Phone = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(251, 230);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tBox_Name
            // 
            this.tBox_Name.Location = new System.Drawing.Point(127, 31);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(199, 20);
            this.tBox_Name.TabIndex = 5;
            // 
            // tBox_Age
            // 
            this.tBox_Age.Location = new System.Drawing.Point(127, 83);
            this.tBox_Age.Name = "tBox_Age";
            this.tBox_Age.Size = new System.Drawing.Size(199, 20);
            this.tBox_Age.TabIndex = 6;
            // 
            // tBox_Email
            // 
            this.tBox_Email.Location = new System.Drawing.Point(127, 135);
            this.tBox_Email.Name = "tBox_Email";
            this.tBox_Email.Size = new System.Drawing.Size(199, 20);
            this.tBox_Email.TabIndex = 7;
            // 
            // tBox_Phone
            // 
            this.tBox_Phone.Location = new System.Drawing.Point(127, 182);
            this.tBox_Phone.Name = "tBox_Phone";
            this.tBox_Phone.Size = new System.Drawing.Size(199, 20);
            this.tBox_Phone.TabIndex = 8;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(36, 230);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 451);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.tBox_Phone);
            this.Controls.Add(this.tBox_Email);
            this.Controls.Add(this.tBox_Age);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tBox_Name;
        private System.Windows.Forms.TextBox tBox_Age;
        private System.Windows.Forms.TextBox tBox_Email;
        private System.Windows.Forms.TextBox tBox_Phone;
        private System.Windows.Forms.Button btn_Clear;
    }
}

