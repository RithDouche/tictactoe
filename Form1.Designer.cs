namespace tictactoe
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bottomR = new System.Windows.Forms.Button();
            this.bottomM = new System.Windows.Forms.Button();
            this.bottomL = new System.Windows.Forms.Button();
            this.middleR = new System.Windows.Forms.Button();
            this.middleM = new System.Windows.Forms.Button();
            this.middleL = new System.Windows.Forms.Button();
            this.topR = new System.Windows.Forms.Button();
            this.topM = new System.Windows.Forms.Button();
            this.topL = new System.Windows.Forms.Button();
            this.scoreCount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.bottomR, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bottomM, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bottomL, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.middleR, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.middleM, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.middleL, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.topR, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.topM, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.topL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.scoreCount, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(344, 150);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 433);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bottomR
            // 
            this.bottomR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomR.Location = new System.Drawing.Point(330, 328);
            this.bottomR.Margin = new System.Windows.Forms.Padding(4);
            this.bottomR.Name = "bottomR";
            this.bottomR.Size = new System.Drawing.Size(157, 101);
            this.bottomR.TabIndex = 9;
            this.bottomR.UseVisualStyleBackColor = true;
            // 
            // bottomM
            // 
            this.bottomM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomM.Location = new System.Drawing.Point(167, 328);
            this.bottomM.Margin = new System.Windows.Forms.Padding(4);
            this.bottomM.Name = "bottomM";
            this.bottomM.Size = new System.Drawing.Size(155, 101);
            this.bottomM.TabIndex = 8;
            this.bottomM.UseVisualStyleBackColor = true;
            // 
            // bottomL
            // 
            this.bottomL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomL.Location = new System.Drawing.Point(4, 328);
            this.bottomL.Margin = new System.Windows.Forms.Padding(4);
            this.bottomL.Name = "bottomL";
            this.bottomL.Size = new System.Drawing.Size(155, 101);
            this.bottomL.TabIndex = 7;
            this.bottomL.UseVisualStyleBackColor = true;
            // 
            // middleR
            // 
            this.middleR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleR.Location = new System.Drawing.Point(330, 220);
            this.middleR.Margin = new System.Windows.Forms.Padding(4);
            this.middleR.Name = "middleR";
            this.middleR.Size = new System.Drawing.Size(157, 100);
            this.middleR.TabIndex = 6;
            this.middleR.UseVisualStyleBackColor = true;
            // 
            // middleM
            // 
            this.middleM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleM.Location = new System.Drawing.Point(167, 220);
            this.middleM.Margin = new System.Windows.Forms.Padding(4);
            this.middleM.Name = "middleM";
            this.middleM.Size = new System.Drawing.Size(155, 100);
            this.middleM.TabIndex = 5;
            this.middleM.UseVisualStyleBackColor = true;
            // 
            // middleL
            // 
            this.middleL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleL.Location = new System.Drawing.Point(4, 220);
            this.middleL.Margin = new System.Windows.Forms.Padding(4);
            this.middleL.Name = "middleL";
            this.middleL.Size = new System.Drawing.Size(155, 100);
            this.middleL.TabIndex = 4;
            this.middleL.UseVisualStyleBackColor = true;
            // 
            // topR
            // 
            this.topR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topR.Location = new System.Drawing.Point(330, 112);
            this.topR.Margin = new System.Windows.Forms.Padding(4);
            this.topR.Name = "topR";
            this.topR.Size = new System.Drawing.Size(157, 100);
            this.topR.TabIndex = 3;
            this.topR.UseVisualStyleBackColor = true;
            // 
            // topM
            // 
            this.topM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topM.Location = new System.Drawing.Point(167, 112);
            this.topM.Margin = new System.Windows.Forms.Padding(4);
            this.topM.Name = "topM";
            this.topM.Size = new System.Drawing.Size(155, 100);
            this.topM.TabIndex = 2;
            this.topM.UseVisualStyleBackColor = true;
            // 
            // topL
            // 
            this.topL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topL.Location = new System.Drawing.Point(4, 112);
            this.topL.Margin = new System.Windows.Forms.Padding(4);
            this.topL.Name = "topL";
            this.topL.Size = new System.Drawing.Size(155, 100);
            this.topL.TabIndex = 0;
            this.topL.UseVisualStyleBackColor = true;
            // 
            // scoreCount
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.scoreCount, 3);
            this.scoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreCount.Location = new System.Drawing.Point(4, 4);
            this.scoreCount.Margin = new System.Windows.Forms.Padding(4);
            this.scoreCount.Name = "scoreCount";
            this.scoreCount.Size = new System.Drawing.Size(483, 37);
            this.scoreCount.TabIndex = 1;
            this.scoreCount.Text = "Your score -           Bot score-       ";
            this.scoreCount.TextChanged += new System.EventHandler(this.scoreCount_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button topL;
        private System.Windows.Forms.TextBox scoreCount;
        private System.Windows.Forms.Button bottomR;
        private System.Windows.Forms.Button bottomM;
        private System.Windows.Forms.Button bottomL;
        private System.Windows.Forms.Button middleR;
        private System.Windows.Forms.Button middleM;
        private System.Windows.Forms.Button middleL;
        private System.Windows.Forms.Button topR;
        private System.Windows.Forms.Button topM;
    }
}

