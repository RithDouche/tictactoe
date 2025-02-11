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
            this.button2 = new System.Windows.Forms.Button();
            this.turn = new System.Windows.Forms.TextBox();
            this.bottomL = new System.Windows.Forms.Button();
            this.bottomM = new System.Windows.Forms.Button();
            this.bottomR = new System.Windows.Forms.Button();
            this.middleL = new System.Windows.Forms.Button();
            this.middleM = new System.Windows.Forms.Button();
            this.middleR = new System.Windows.Forms.Button();
            this.topL = new System.Windows.Forms.Button();
            this.topM = new System.Windows.Forms.Button();
            this.topR = new System.Windows.Forms.Button();
            this.userSC = new System.Windows.Forms.TextBox();
            this.computerSC = new System.Windows.Forms.TextBox();
            this.winPercentage = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.turn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bottomL, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bottomM, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bottomR, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.middleL, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.middleM, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.middleR, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.topL, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.topM, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.topR, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.userSC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.computerSC, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.winPercentage, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(99, 47);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(836, 465);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 465);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 118);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 112);
            this.button2.TabIndex = 32;
            this.button2.Text = "   New Game   (Counts as a loss)\r\n";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // turn
            // 
            this.turn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn.Location = new System.Drawing.Point(3, 2);
            this.turn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(203, 24);
            this.turn.TabIndex = 31;
            this.turn.Text = "Turn: ";
            // 
            // bottomL
            // 
            this.bottomL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomL.Location = new System.Drawing.Point(212, 350);
            this.bottomL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottomL.Name = "bottomL";
            this.bottomL.Size = new System.Drawing.Size(203, 113);
            this.bottomL.TabIndex = 26;
            this.bottomL.UseVisualStyleBackColor = true;
            // 
            // bottomM
            // 
            this.bottomM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomM.Location = new System.Drawing.Point(421, 350);
            this.bottomM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottomM.Name = "bottomM";
            this.bottomM.Size = new System.Drawing.Size(203, 113);
            this.bottomM.TabIndex = 25;
            this.bottomM.UseVisualStyleBackColor = true;
            // 
            // bottomR
            // 
            this.bottomR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomR.Location = new System.Drawing.Point(630, 350);
            this.bottomR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottomR.Name = "bottomR";
            this.bottomR.Size = new System.Drawing.Size(203, 113);
            this.bottomR.TabIndex = 24;
            this.bottomR.UseVisualStyleBackColor = true;
            // 
            // middleL
            // 
            this.middleL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleL.Location = new System.Drawing.Point(212, 234);
            this.middleL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middleL.Name = "middleL";
            this.middleL.Size = new System.Drawing.Size(203, 112);
            this.middleL.TabIndex = 22;
            this.middleL.UseVisualStyleBackColor = true;
            // 
            // middleM
            // 
            this.middleM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleM.Location = new System.Drawing.Point(421, 234);
            this.middleM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middleM.Name = "middleM";
            this.middleM.Size = new System.Drawing.Size(203, 112);
            this.middleM.TabIndex = 21;
            this.middleM.UseVisualStyleBackColor = true;
            // 
            // middleR
            // 
            this.middleR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleR.Location = new System.Drawing.Point(630, 234);
            this.middleR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middleR.Name = "middleR";
            this.middleR.Size = new System.Drawing.Size(203, 112);
            this.middleR.TabIndex = 20;
            this.middleR.UseVisualStyleBackColor = true;
            // 
            // topL
            // 
            this.topL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topL.Location = new System.Drawing.Point(212, 118);
            this.topL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topL.Name = "topL";
            this.topL.Size = new System.Drawing.Size(203, 112);
            this.topL.TabIndex = 18;
            this.topL.UseVisualStyleBackColor = true;
            // 
            // topM
            // 
            this.topM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topM.Location = new System.Drawing.Point(421, 118);
            this.topM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topM.Name = "topM";
            this.topM.Size = new System.Drawing.Size(203, 112);
            this.topM.TabIndex = 17;
            this.topM.UseVisualStyleBackColor = true;
            // 
            // topR
            // 
            this.topR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topR.Location = new System.Drawing.Point(630, 118);
            this.topR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topR.Name = "topR";
            this.topR.Size = new System.Drawing.Size(203, 112);
            this.topR.TabIndex = 16;
            this.topR.UseVisualStyleBackColor = true;
            // 
            // userSC
            // 
            this.userSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSC.Location = new System.Drawing.Point(212, 2);
            this.userSC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userSC.Name = "userSC";
            this.userSC.Size = new System.Drawing.Size(203, 24);
            this.userSC.TabIndex = 14;
            this.userSC.Text = "User score -";
            // 
            // computerSC
            // 
            this.computerSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerSC.Location = new System.Drawing.Point(422, 4);
            this.computerSC.Margin = new System.Windows.Forms.Padding(4);
            this.computerSC.Name = "computerSC";
            this.computerSC.Size = new System.Drawing.Size(201, 24);
            this.computerSC.TabIndex = 13;
            this.computerSC.Text = "Computer Score -";
            // 
            // winPercentage
            // 
            this.winPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winPercentage.Location = new System.Drawing.Point(631, 4);
            this.winPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.winPercentage.Name = "winPercentage";
            this.winPercentage.Size = new System.Drawing.Size(201, 24);
            this.winPercentage.TabIndex = 12;
            this.winPercentage.Text = "Win % -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 663);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2522, 1215);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bottomL;
        private System.Windows.Forms.Button bottomM;
        private System.Windows.Forms.Button bottomR;
        private System.Windows.Forms.Button middleL;
        private System.Windows.Forms.Button middleM;
        private System.Windows.Forms.Button middleR;
        private System.Windows.Forms.Button topL;
        private System.Windows.Forms.Button topM;
        private System.Windows.Forms.Button topR;
        private System.Windows.Forms.TextBox userSC;
        private System.Windows.Forms.TextBox computerSC;
        private System.Windows.Forms.TextBox winPercentage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox turn;
    }
}

