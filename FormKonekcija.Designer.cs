namespace Narudžba
{
    partial class FormKonekcija
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
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(177, 151);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(45, 36);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Id";
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(45, 102);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(24, 13);
            this.labelIme.TabIndex = 2;
            this.labelIme.Text = "Ime";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(131, 20);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(150, 95);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(131, 20);
            this.txtIme.TabIndex = 4;
            // 
            // FormKonekcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 243);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonTest);
            this.Name = "FormKonekcija";
            this.Text = "FormKonekcija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIme;
    }
}