namespace QColorTools
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
            this.btnStraw = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.tbxColorString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxR = new System.Windows.Forms.TextBox();
            this.tbxG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStraw
            // 
            this.btnStraw.BackgroundImage = global::QColorTools.Properties.Resources.icon_straw2;
            this.btnStraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStraw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStraw.Location = new System.Drawing.Point(248, 12);
            this.btnStraw.Name = "btnStraw";
            this.btnStraw.Size = new System.Drawing.Size(32, 33);
            this.btnStraw.TabIndex = 0;
            this.btnStraw.UseVisualStyleBackColor = true;
            this.btnStraw.Click += new System.EventHandler(this.btnStraw_Click);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.White;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(22, 13);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(211, 32);
            this.panelColor.TabIndex = 1;
            this.panelColor.BackColorChanged += new System.EventHandler(this.panelColor_BackColorChanged);
            // 
            // tbxColorString
            // 
            this.tbxColorString.Location = new System.Drawing.Point(47, 53);
            this.tbxColorString.MaxLength = 8;
            this.tbxColorString.Name = "tbxColorString";
            this.tbxColorString.Size = new System.Drawing.Size(100, 21);
            this.tbxColorString.TabIndex = 2;
            this.tbxColorString.TextChanged += new System.EventHandler(this.tbxColorString_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "RRGGBB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "R";
            // 
            // tbxR
            // 
            this.tbxR.Location = new System.Drawing.Point(47, 85);
            this.tbxR.MaxLength = 3;
            this.tbxR.Name = "tbxR";
            this.tbxR.Size = new System.Drawing.Size(38, 21);
            this.tbxR.TabIndex = 6;
            this.tbxR.TextChanged += new System.EventHandler(this.SingleChannel_TextChanged);
            // 
            // tbxG
            // 
            this.tbxG.Location = new System.Drawing.Point(124, 85);
            this.tbxG.MaxLength = 3;
            this.tbxG.Name = "tbxG";
            this.tbxG.Size = new System.Drawing.Size(38, 21);
            this.tbxG.TabIndex = 8;
            this.tbxG.TextChanged += new System.EventHandler(this.SingleChannel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "G";
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(201, 85);
            this.tbxB.MaxLength = 3;
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(38, 21);
            this.tbxB.TabIndex = 10;
            this.tbxB.TextChanged += new System.EventHandler(this.SingleChannel_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "B";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxColorString);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.btnStraw);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStraw;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.TextBox tbxColorString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxR;
        private System.Windows.Forms.TextBox tbxG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.Label label5;
    }
}

