namespace _5_2_CalculateChange
{
    partial class frmCalculateChange
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
            this.tbChange = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbQuarters = new System.Windows.Forms.TextBox();
            this.tbDimes = new System.Windows.Forms.TextBox();
            this.tbNickels = new System.Windows.Forms.TextBox();
            this.tbPennies = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount of change due (0-99):";
            // 
            // tbChange
            // 
            this.tbChange.Location = new System.Drawing.Point(199, 17);
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(51, 20);
            this.tbChange.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(48, 156);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(175, 156);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbQuarters
            // 
            this.tbQuarters.Location = new System.Drawing.Point(199, 52);
            this.tbQuarters.Name = "tbQuarters";
            this.tbQuarters.ReadOnly = true;
            this.tbQuarters.Size = new System.Drawing.Size(51, 20);
            this.tbQuarters.TabIndex = 4;
            this.tbQuarters.TabStop = false;
            // 
            // tbDimes
            // 
            this.tbDimes.Location = new System.Drawing.Point(199, 78);
            this.tbDimes.Name = "tbDimes";
            this.tbDimes.ReadOnly = true;
            this.tbDimes.Size = new System.Drawing.Size(51, 20);
            this.tbDimes.TabIndex = 5;
            this.tbDimes.TabStop = false;
            // 
            // tbNickels
            // 
            this.tbNickels.Location = new System.Drawing.Point(199, 104);
            this.tbNickels.Name = "tbNickels";
            this.tbNickels.ReadOnly = true;
            this.tbNickels.Size = new System.Drawing.Size(51, 20);
            this.tbNickels.TabIndex = 6;
            this.tbNickels.TabStop = false;
            // 
            // tbPennies
            // 
            this.tbPennies.Location = new System.Drawing.Point(199, 130);
            this.tbPennies.Name = "tbPennies";
            this.tbPennies.ReadOnly = true;
            this.tbPennies.Size = new System.Drawing.Size(51, 20);
            this.tbPennies.TabIndex = 7;
            this.tbPennies.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quarters:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dimes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nickels:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pennies:";
            // 
            // frmCalculateChange
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(294, 192);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPennies);
            this.Controls.Add(this.tbNickels);
            this.Controls.Add(this.tbDimes);
            this.Controls.Add(this.tbQuarters);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbChange);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculateChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbChange;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbQuarters;
        private System.Windows.Forms.TextBox tbDimes;
        private System.Windows.Forms.TextBox tbNickels;
        private System.Windows.Forms.TextBox tbPennies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

