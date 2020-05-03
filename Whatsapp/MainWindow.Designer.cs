namespace Whatsapp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chatterBStatusLbl = new System.Windows.Forms.Label();
            this.chatterAStatusLbl = new System.Windows.Forms.Label();
            this.chatterBTxtBx = new System.Windows.Forms.TextBox();
            this.chatterATxtBx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chatterBNameTxtBx = new System.Windows.Forms.TextBox();
            this.chatterANameTxtBx = new System.Windows.Forms.TextBox();
            this.chatLB = new System.Windows.Forms.ListBox();
            this.changeANameBtn = new System.Windows.Forms.Button();
            this.changeBNameBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.linesLbl = new System.Windows.Forms.Label();
            this.countLinesLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedIndexLbl = new System.Windows.Forms.Label();
            this.selectedItemLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chatterBStatusLbl);
            this.panel1.Controls.Add(this.chatterAStatusLbl);
            this.panel1.Controls.Add(this.chatterBTxtBx);
            this.panel1.Controls.Add(this.chatterATxtBx);
            this.panel1.Location = new System.Drawing.Point(35, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 194);
            this.panel1.TabIndex = 2;
            // 
            // chatterBStatusLbl
            // 
            this.chatterBStatusLbl.AutoSize = true;
            this.chatterBStatusLbl.Location = new System.Drawing.Point(28, 106);
            this.chatterBStatusLbl.Name = "chatterBStatusLbl";
            this.chatterBStatusLbl.Size = new System.Drawing.Size(49, 17);
            this.chatterBStatusLbl.TabIndex = 5;
            this.chatterBStatusLbl.Text = "Online";
            // 
            // chatterAStatusLbl
            // 
            this.chatterAStatusLbl.AutoSize = true;
            this.chatterAStatusLbl.Location = new System.Drawing.Point(28, 26);
            this.chatterAStatusLbl.Name = "chatterAStatusLbl";
            this.chatterAStatusLbl.Size = new System.Drawing.Size(49, 17);
            this.chatterAStatusLbl.TabIndex = 4;
            this.chatterAStatusLbl.Text = "Online";
            // 
            // chatterBTxtBx
            // 
            this.chatterBTxtBx.Location = new System.Drawing.Point(28, 138);
            this.chatterBTxtBx.Name = "chatterBTxtBx";
            this.chatterBTxtBx.Size = new System.Drawing.Size(388, 22);
            this.chatterBTxtBx.TabIndex = 3;
            this.chatterBTxtBx.TextChanged += new System.EventHandler(this.chatterBTxtBx_TextChanged);
            this.chatterBTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatterBTxtBx_KeyDown);
            this.chatterBTxtBx.Leave += new System.EventHandler(this.chatterBTxtBx_Leave);
            // 
            // chatterATxtBx
            // 
            this.chatterATxtBx.Location = new System.Drawing.Point(28, 63);
            this.chatterATxtBx.Name = "chatterATxtBx";
            this.chatterATxtBx.Size = new System.Drawing.Size(388, 22);
            this.chatterATxtBx.TabIndex = 2;
            this.chatterATxtBx.TextChanged += new System.EventHandler(this.chatterATxtBx_TextChanged);
            this.chatterATxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatterATxtBx_KeyDown);
            this.chatterATxtBx.Leave += new System.EventHandler(this.chatterATxtBx_Leave);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.changeBNameBtn);
            this.panel2.Controls.Add(this.changeANameBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chatterBNameTxtBx);
            this.panel2.Controls.Add(this.chatterANameTxtBx);
            this.panel2.Location = new System.Drawing.Point(35, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 114);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "second chatter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "first chatter";
            // 
            // chatterBNameTxtBx
            // 
            this.chatterBNameTxtBx.Location = new System.Drawing.Point(164, 65);
            this.chatterBNameTxtBx.Name = "chatterBNameTxtBx";
            this.chatterBNameTxtBx.Size = new System.Drawing.Size(155, 22);
            this.chatterBNameTxtBx.TabIndex = 3;
            this.chatterBNameTxtBx.Text = "Suzan";
            this.chatterBNameTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatterBNameTxtBx_KeyDown);
            // 
            // chatterANameTxtBx
            // 
            this.chatterANameTxtBx.Location = new System.Drawing.Point(164, 21);
            this.chatterANameTxtBx.Name = "chatterANameTxtBx";
            this.chatterANameTxtBx.Size = new System.Drawing.Size(155, 22);
            this.chatterANameTxtBx.TabIndex = 2;
            this.chatterANameTxtBx.Text = "Ralph";
            this.chatterANameTxtBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatterANameTxtBx_KeyDown);
            // 
            // chatLB
            // 
            this.chatLB.FormattingEnabled = true;
            this.chatLB.ItemHeight = 16;
            this.chatLB.Location = new System.Drawing.Point(527, 34);
            this.chatLB.Name = "chatLB";
            this.chatLB.Size = new System.Drawing.Size(412, 260);
            this.chatLB.TabIndex = 5;
            this.chatLB.SelectedIndexChanged += new System.EventHandler(this.chatLB_SelectedIndexChanged);
            this.chatLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chatLB_MouseDoubleClick);
            // 
            // changeANameBtn
            // 
            this.changeANameBtn.Location = new System.Drawing.Point(341, 17);
            this.changeANameBtn.Name = "changeANameBtn";
            this.changeANameBtn.Size = new System.Drawing.Size(75, 29);
            this.changeANameBtn.TabIndex = 6;
            this.changeANameBtn.Text = "Change";
            this.changeANameBtn.UseVisualStyleBackColor = true;
            this.changeANameBtn.Click += new System.EventHandler(this.changeANameBtn_Click);
            // 
            // changeBNameBtn
            // 
            this.changeBNameBtn.Location = new System.Drawing.Point(341, 62);
            this.changeBNameBtn.Name = "changeBNameBtn";
            this.changeBNameBtn.Size = new System.Drawing.Size(75, 29);
            this.changeBNameBtn.TabIndex = 7;
            this.changeBNameBtn.Text = "Change";
            this.changeBNameBtn.UseVisualStyleBackColor = true;
            this.changeBNameBtn.Click += new System.EventHandler(this.changeBNameBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(527, 358);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(93, 24);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear Chat";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // linesLbl
            // 
            this.linesLbl.AutoSize = true;
            this.linesLbl.Location = new System.Drawing.Point(651, 362);
            this.linesLbl.Name = "linesLbl";
            this.linesLbl.Size = new System.Drawing.Size(92, 17);
            this.linesLbl.TabIndex = 7;
            this.linesLbl.Text = "Lines in chat:";
            // 
            // countLinesLbl
            // 
            this.countLinesLbl.AutoSize = true;
            this.countLinesLbl.Location = new System.Drawing.Point(749, 362);
            this.countLinesLbl.Name = "countLinesLbl";
            this.countLinesLbl.Size = new System.Drawing.Size(16, 17);
            this.countLinesLbl.TabIndex = 8;
            this.countLinesLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selected Index: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selected Item:";
            // 
            // selectedIndexLbl
            // 
            this.selectedIndexLbl.AutoSize = true;
            this.selectedIndexLbl.Location = new System.Drawing.Point(636, 301);
            this.selectedIndexLbl.Name = "selectedIndexLbl";
            this.selectedIndexLbl.Size = new System.Drawing.Size(21, 17);
            this.selectedIndexLbl.TabIndex = 11;
            this.selectedIndexLbl.Text = "-1";
            // 
            // selectedItemLbl
            // 
            this.selectedItemLbl.AutoSize = true;
            this.selectedItemLbl.Location = new System.Drawing.Point(630, 327);
            this.selectedItemLbl.Name = "selectedItemLbl";
            this.selectedItemLbl.Size = new System.Drawing.Size(21, 17);
            this.selectedItemLbl.TabIndex = 12;
            this.selectedItemLbl.Text = "-1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 435);
            this.Controls.Add(this.selectedItemLbl);
            this.Controls.Add(this.selectedIndexLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countLinesLbl);
            this.Controls.Add(this.linesLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.chatLB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whatsapp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox chatterBTxtBx;
        private System.Windows.Forms.TextBox chatterATxtBx;
        private System.Windows.Forms.Label chatterBStatusLbl;
        private System.Windows.Forms.Label chatterAStatusLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chatterBNameTxtBx;
        private System.Windows.Forms.TextBox chatterANameTxtBx;
        private System.Windows.Forms.ListBox chatLB;
        private System.Windows.Forms.Button changeBNameBtn;
        private System.Windows.Forms.Button changeANameBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label linesLbl;
        private System.Windows.Forms.Label countLinesLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label selectedIndexLbl;
        private System.Windows.Forms.Label selectedItemLbl;
    }
}

