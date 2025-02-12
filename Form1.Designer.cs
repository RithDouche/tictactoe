using System.Windows.Forms;

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
            this.stopGame = new System.Windows.Forms.Button();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.turnDisplay = new System.Windows.Forms.TextBox();
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
            this.winBox = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.stopGame, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.newGameBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.turnDisplay, 0, 0);
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
            this.tableLayoutPanel1.Controls.Add(this.winBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(627, 378);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // stopGame
            // 
            this.stopGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopGame.Location = new System.Drawing.Point(2, 265);
            this.stopGame.Margin = new System.Windows.Forms.Padding(2);
            this.stopGame.Name = "stopGame";
            this.stopGame.Size = new System.Drawing.Size(185, 112);
            this.stopGame.TabIndex = 34;
            this.stopGame.Text = "Stop Game";
            this.stopGame.UseVisualStyleBackColor = true;
            this.stopGame.Click += new System.EventHandler(this.stopGame_Click);
            // 
            // newGameBtn
            // 
            this.newGameBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBtn.Location = new System.Drawing.Point(2, 152);
            this.newGameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(185, 109);
            this.newGameBtn.TabIndex = 33;
            this.newGameBtn.Text = "New Game  \r\n";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // turnDisplay
            // 
            this.turnDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnDisplay.Location = new System.Drawing.Point(2, 2);
            this.turnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.turnDisplay.Multiline = true;
            this.turnDisplay.Name = "turnDisplay";
            this.turnDisplay.ReadOnly = true;
            this.turnDisplay.Size = new System.Drawing.Size(185, 33);
            this.turnDisplay.TabIndex = 31;
            this.turnDisplay.Text = "Turn: ";
            // 
            // bottomL
            // 
            this.bottomL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomL.Location = new System.Drawing.Point(191, 265);
            this.bottomL.Margin = new System.Windows.Forms.Padding(2);
            this.bottomL.Name = "bottomL";
            this.bottomL.Size = new System.Drawing.Size(185, 112);
            this.bottomL.TabIndex = 26;
            this.bottomL.UseVisualStyleBackColor = true;
            // 
            // bottomM
            // 
            this.bottomM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomM.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomM.Location = new System.Drawing.Point(380, 265);
            this.bottomM.Margin = new System.Windows.Forms.Padding(2);
            this.bottomM.Name = "bottomM";
            this.bottomM.Size = new System.Drawing.Size(185, 112);
            this.bottomM.TabIndex = 25;
            this.bottomM.UseVisualStyleBackColor = true;
            // 
            // bottomR
            // 
            this.bottomR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomR.Location = new System.Drawing.Point(569, 265);
            this.bottomR.Margin = new System.Windows.Forms.Padding(2);
            this.bottomR.Name = "bottomR";
            this.bottomR.Size = new System.Drawing.Size(185, 112);
            this.bottomR.TabIndex = 24;
            this.bottomR.UseVisualStyleBackColor = true;
            // 
            // middleL
            // 
            this.middleL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleL.Location = new System.Drawing.Point(191, 152);
            this.middleL.Margin = new System.Windows.Forms.Padding(2);
            this.middleL.Name = "middleL";
            this.middleL.Size = new System.Drawing.Size(185, 109);
            this.middleL.TabIndex = 22;
            this.middleL.UseVisualStyleBackColor = true;
            // 
            // middleM
            // 
            this.middleM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleM.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleM.Location = new System.Drawing.Point(380, 152);
            this.middleM.Margin = new System.Windows.Forms.Padding(2);
            this.middleM.Name = "middleM";
            this.middleM.Size = new System.Drawing.Size(185, 109);
            this.middleM.TabIndex = 21;
            this.middleM.UseVisualStyleBackColor = true;
            // 
            // middleR
            // 
            this.middleR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleR.Location = new System.Drawing.Point(569, 152);
            this.middleR.Margin = new System.Windows.Forms.Padding(2);
            this.middleR.Name = "middleR";
            this.middleR.Size = new System.Drawing.Size(185, 109);
            this.middleR.TabIndex = 20;
            this.middleR.UseVisualStyleBackColor = true;
            // 
            // topL
            // 
            this.topL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topL.Location = new System.Drawing.Point(191, 39);
            this.topL.Margin = new System.Windows.Forms.Padding(2);
            this.topL.Name = "topL";
            this.topL.Size = new System.Drawing.Size(185, 109);
            this.topL.TabIndex = 18;
            this.topL.UseVisualStyleBackColor = true;
            // 
            // topM
            // 
            this.topM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topM.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topM.Location = new System.Drawing.Point(380, 39);
            this.topM.Margin = new System.Windows.Forms.Padding(2);
            this.topM.Name = "topM";
            this.topM.Size = new System.Drawing.Size(185, 109);
            this.topM.TabIndex = 17;
            this.topM.UseVisualStyleBackColor = true;
            // 
            // topR
            // 
            this.topR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topR.Location = new System.Drawing.Point(569, 39);
            this.topR.Margin = new System.Windows.Forms.Padding(2);
            this.topR.Name = "topR";
            this.topR.Size = new System.Drawing.Size(185, 109);
            this.topR.TabIndex = 16;
            this.topR.UseVisualStyleBackColor = true;
            // 
            // userSC
            // 
            this.userSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSC.Location = new System.Drawing.Point(191, 2);
            this.userSC.Margin = new System.Windows.Forms.Padding(2);
            this.userSC.Multiline = true;
            this.userSC.Name = "userSC";
            this.userSC.ReadOnly = true;
            this.userSC.Size = new System.Drawing.Size(185, 33);
            this.userSC.TabIndex = 14;
            this.userSC.Text = "User score - 0";
            // 
            // computerSC
            // 
            this.computerSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerSC.Location = new System.Drawing.Point(382, 4);
            this.computerSC.Margin = new System.Windows.Forms.Padding(4);
            this.computerSC.Multiline = true;
            this.computerSC.Name = "computerSC";
            this.computerSC.ReadOnly = true;
            this.computerSC.Size = new System.Drawing.Size(181, 29);
            this.computerSC.TabIndex = 13;
            this.computerSC.Text = "Computer Score - 0";
            // 
            // winPercentage
            // 
            this.winPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winPercentage.Location = new System.Drawing.Point(571, 4);
            this.winPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.winPercentage.Multiline = true;
            this.winPercentage.Name = "winPercentage";
            this.winPercentage.ReadOnly = true;
            this.winPercentage.Size = new System.Drawing.Size(181, 29);
            this.winPercentage.TabIndex = 12;
            this.winPercentage.Text = "Win % -";
            // 
            // winBox
            // 
            this.winBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winBox.Location = new System.Drawing.Point(3, 40);
            this.winBox.Multiline = true;
            this.winBox.Name = "winBox";
            this.winBox.ReadOnly = true;
            this.winBox.Size = new System.Drawing.Size(183, 107);
            this.winBox.TabIndex = 35;
            this.winBox.Text = "Winner: ";
            this.winBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.winBox.TextChanged += new System.EventHandler(this.winBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 379);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1845, 943);
            this.MinimumSize = new System.Drawing.Size(772, 418);
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
        private System.Windows.Forms.TextBox turnDisplay;
        private System.Windows.Forms.Button stopGame;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.TextBox winBox;
    }
}

