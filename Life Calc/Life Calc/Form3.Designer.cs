namespace Life_Calc
{
    partial class Form3
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
            this.TitleLB = new System.Windows.Forms.Label();
            this.FinShapeLB = new System.Windows.Forms.Label();
            this.SpendLimitLB = new System.Windows.Forms.Label();
            this.EarningLB = new System.Windows.Forms.Label();
            this.RecalcBN = new System.Windows.Forms.Button();
            this.FinTimesBN = new System.Windows.Forms.Button();
            this.HomeBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLB
            // 
            this.TitleLB.BackColor = System.Drawing.Color.Gold;
            this.TitleLB.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLB.Location = new System.Drawing.Point(0, 0);
            this.TitleLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(1950, 168);
            this.TitleLB.TabIndex = 1;
            this.TitleLB.Text = "Understanding Your Results";
            this.TitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinShapeLB
            // 
            this.FinShapeLB.Font = new System.Drawing.Font("Georgia", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinShapeLB.ForeColor = System.Drawing.Color.Lime;
            this.FinShapeLB.Location = new System.Drawing.Point(46, 195);
            this.FinShapeLB.Name = "FinShapeLB";
            this.FinShapeLB.Size = new System.Drawing.Size(1798, 145);
            this.FinShapeLB.TabIndex = 18;
            this.FinShapeLB.Text = "You are in good financial shape: You will be able to pay off your loans in an est" +
    "imated __ years.";
            this.FinShapeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpendLimitLB
            // 
            this.SpendLimitLB.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpendLimitLB.ForeColor = System.Drawing.Color.Black;
            this.SpendLimitLB.Location = new System.Drawing.Point(46, 393);
            this.SpendLimitLB.Name = "SpendLimitLB";
            this.SpendLimitLB.Size = new System.Drawing.Size(1798, 145);
            this.SpendLimitLB.TabIndex = 19;
            this.SpendLimitLB.Text = "Not My Job";
            this.SpendLimitLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EarningLB
            // 
            this.EarningLB.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EarningLB.ForeColor = System.Drawing.Color.Black;
            this.EarningLB.Location = new System.Drawing.Point(49, 606);
            this.EarningLB.Name = "EarningLB";
            this.EarningLB.Size = new System.Drawing.Size(1798, 145);
            this.EarningLB.TabIndex = 20;
            this.EarningLB.Text = "Not My Job";
            this.EarningLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecalcBN
            // 
            this.RecalcBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RecalcBN.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecalcBN.ForeColor = System.Drawing.Color.White;
            this.RecalcBN.Location = new System.Drawing.Point(12, 913);
            this.RecalcBN.Name = "RecalcBN";
            this.RecalcBN.Size = new System.Drawing.Size(572, 99);
            this.RecalcBN.TabIndex = 22;
            this.RecalcBN.Text = "Recalculate Your Future";
            this.RecalcBN.UseVisualStyleBackColor = false;
            this.RecalcBN.Click += new System.EventHandler(this.RecalcBN_Click);
            // 
            // FinTimesBN
            // 
            this.FinTimesBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FinTimesBN.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinTimesBN.ForeColor = System.Drawing.Color.White;
            this.FinTimesBN.Location = new System.Drawing.Point(674, 913);
            this.FinTimesBN.Name = "FinTimesBN";
            this.FinTimesBN.Size = new System.Drawing.Size(572, 99);
            this.FinTimesBN.TabIndex = 23;
            this.FinTimesBN.Text = "Learn Financial Tips";
            this.FinTimesBN.UseVisualStyleBackColor = false;
            this.FinTimesBN.Click += new System.EventHandler(this.FinTimesBN_Click);
            // 
            // HomeBN
            // 
            this.HomeBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HomeBN.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBN.ForeColor = System.Drawing.Color.White;
            this.HomeBN.Location = new System.Drawing.Point(1314, 913);
            this.HomeBN.Name = "HomeBN";
            this.HomeBN.Size = new System.Drawing.Size(572, 99);
            this.HomeBN.TabIndex = 24;
            this.HomeBN.Text = "Home";
            this.HomeBN.UseVisualStyleBackColor = false;
            this.HomeBN.Click += new System.EventHandler(this.HomeBN_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.HomeBN);
            this.Controls.Add(this.FinTimesBN);
            this.Controls.Add(this.RecalcBN);
            this.Controls.Add(this.EarningLB);
            this.Controls.Add(this.SpendLimitLB);
            this.Controls.Add(this.FinShapeLB);
            this.Controls.Add(this.TitleLB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLB;
        private System.Windows.Forms.Label FinShapeLB;
        private System.Windows.Forms.Label SpendLimitLB;
        private System.Windows.Forms.Label EarningLB;
        private System.Windows.Forms.Button RecalcBN;
        private System.Windows.Forms.Button FinTimesBN;
        private System.Windows.Forms.Button HomeBN;
    }
}