namespace WindowsFormsApp0305
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
            this.helloLbl = new System.Windows.Forms.Label();
            this.timeBtn = new System.Windows.Forms.Button();
            this.xTxtBx = new System.Windows.Forms.TextBox();
            this.yTxtBx = new System.Windows.Forms.TextBox();
            this.xLbl = new System.Windows.Forms.Label();
            this.yLbl = new System.Windows.Forms.Label();
            this.sumLbl = new System.Windows.Forms.Label();
            this.sumResultLbl = new System.Windows.Forms.Label();
            this.numberLbl = new System.Windows.Forms.Label();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloLbl
            // 
            this.helloLbl.AutoSize = true;
            this.helloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.helloLbl.Location = new System.Drawing.Point(99, 125);
            this.helloLbl.Name = "helloLbl";
            this.helloLbl.Size = new System.Drawing.Size(82, 29);
            this.helloLbl.TabIndex = 0;
            this.helloLbl.Text = "Hello!";
            this.helloLbl.MouseLeave += new System.EventHandler(this.helloLbl_MouseLeave);
            this.helloLbl.MouseHover += new System.EventHandler(this.helloLbl_MouseHover);
            // 
            // timeBtn
            // 
            this.timeBtn.AutoSize = true;
            this.timeBtn.Location = new System.Drawing.Point(79, 36);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.Size = new System.Drawing.Size(152, 53);
            this.timeBtn.TabIndex = 1;
            this.timeBtn.Text = "Show me the time!";
            this.timeBtn.UseVisualStyleBackColor = true;
            this.timeBtn.Click += new System.EventHandler(this.timeBtn_Click);
            // 
            // xTxtBx
            // 
            this.xTxtBx.Location = new System.Drawing.Point(131, 239);
            this.xTxtBx.Name = "xTxtBx";
            this.xTxtBx.Size = new System.Drawing.Size(100, 22);
            this.xTxtBx.TabIndex = 2;
            this.xTxtBx.Text = "0";
            this.xTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.xTxtBx.TextChanged += new System.EventHandler(this.xTxtBx_TextChanged);
            // 
            // yTxtBx
            // 
            this.yTxtBx.Location = new System.Drawing.Point(131, 290);
            this.yTxtBx.Name = "yTxtBx";
            this.yTxtBx.Size = new System.Drawing.Size(100, 22);
            this.yTxtBx.TabIndex = 3;
            this.yTxtBx.Text = "0";
            this.yTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.yTxtBx.TextChanged += new System.EventHandler(this.yTxtBx_TextChanged);
            // 
            // xLbl
            // 
            this.xLbl.AutoSize = true;
            this.xLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.xLbl.Location = new System.Drawing.Point(94, 239);
            this.xLbl.Name = "xLbl";
            this.xLbl.Size = new System.Drawing.Size(21, 20);
            this.xLbl.TabIndex = 4;
            this.xLbl.Text = "X";
            // 
            // yLbl
            // 
            this.yLbl.AutoSize = true;
            this.yLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.yLbl.Location = new System.Drawing.Point(94, 290);
            this.yLbl.Name = "yLbl";
            this.yLbl.Size = new System.Drawing.Size(20, 20);
            this.yLbl.TabIndex = 5;
            this.yLbl.Text = "Y";
            // 
            // sumLbl
            // 
            this.sumLbl.AutoSize = true;
            this.sumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sumLbl.Location = new System.Drawing.Point(100, 336);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(72, 20);
            this.sumLbl.TabIndex = 6;
            this.sumLbl.Text = "X + Y =";
            // 
            // sumResultLbl
            // 
            this.sumResultLbl.AutoSize = true;
            this.sumResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sumResultLbl.Location = new System.Drawing.Point(178, 336);
            this.sumResultLbl.Name = "sumResultLbl";
            this.sumResultLbl.Size = new System.Drawing.Size(19, 20);
            this.sumResultLbl.TabIndex = 7;
            this.sumResultLbl.Text = "0";
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numberLbl.Location = new System.Drawing.Point(340, 255);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(19, 20);
            this.numberLbl.TabIndex = 8;
            this.numberLbl.Text = "0";
            // 
            // plusBtn
            // 
            this.plusBtn.AutoSize = true;
            this.plusBtn.Location = new System.Drawing.Point(301, 248);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(33, 27);
            this.plusBtn.TabIndex = 9;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.AutoSize = true;
            this.minusBtn.Location = new System.Drawing.Point(365, 248);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(33, 27);
            this.minusBtn.TabIndex = 10;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 419);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.numberLbl);
            this.Controls.Add(this.sumResultLbl);
            this.Controls.Add(this.sumLbl);
            this.Controls.Add(this.yLbl);
            this.Controls.Add(this.xLbl);
            this.Controls.Add(this.yTxtBx);
            this.Controls.Add(this.xTxtBx);
            this.Controls.Add(this.timeBtn);
            this.Controls.Add(this.helloLbl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLbl;
        private System.Windows.Forms.Button timeBtn;
        private System.Windows.Forms.TextBox xTxtBx;
        private System.Windows.Forms.TextBox yTxtBx;
        private System.Windows.Forms.Label xLbl;
        private System.Windows.Forms.Label yLbl;
        private System.Windows.Forms.Label sumLbl;
        private System.Windows.Forms.Label sumResultLbl;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
    }
}

