﻿/*
 * Pascal "Liquidz" H.
 * 10.02.2017 / 07:47
 * 
 * Description:
 */
namespace Pong.Source
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.timerPaddle = new System.Windows.Forms.Timer(this.components);
            this.pBall = new System.Windows.Forms.PictureBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.timerBall = new System.Windows.Forms.Timer(this.components);
            this.timerIncreaseSpeed = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ctxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPanelSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPanelNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPanelBig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBallSlow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBallNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBallFast = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsClose = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).BeginInit();
            this.ctxtMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlPlayer1.Location = new System.Drawing.Point(16, 252);
            this.pnlPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(20, 154);
            this.pnlPlayer1.TabIndex = 0;
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlPlayer2.Location = new System.Drawing.Point(1008, 252);
            this.pnlPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(20, 154);
            this.pnlPlayer2.TabIndex = 1;
            // 
            // timerPaddle
            // 
            this.timerPaddle.Interval = 30;
            this.timerPaddle.Tick += new System.EventHandler(this.timerPaddle_Tick);
            // 
            // pBall
            // 
            this.pBall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBall.BackColor = System.Drawing.Color.Transparent;
            this.pBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBall.BackgroundImage")));
            this.pBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBall.Location = new System.Drawing.Point(520, 309);
            this.pBall.Margin = new System.Windows.Forms.Padding(4);
            this.pBall.Name = "pBall";
            this.pBall.Size = new System.Drawing.Size(21, 20);
            this.pBall.TabIndex = 2;
            this.pBall.TabStop = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPlayer1.Location = new System.Drawing.Point(384, 3);
            this.lblPlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(63, 32);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "0";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPlayer2.Location = new System.Drawing.Point(600, 3);
            this.lblPlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(68, 32);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "0";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerBall
            // 
            this.timerBall.Interval = 10;
            this.timerBall.Tick += new System.EventHandler(this.timerBall_Tick);
            // 
            // timerIncreaseSpeed
            // 
            this.timerIncreaseSpeed.Interval = 10000;
            this.timerIncreaseSpeed.Tick += new System.EventHandler(this.timerIncreaseSpeed_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctxtMenu
            // 
            this.ctxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPanel,
            this.tsBall,
            this.tsFullscreen,
            this.tsClose});
            this.ctxtMenu.Name = "ctxtMenu";
            this.ctxtMenu.Size = new System.Drawing.Size(153, 114);
            // 
            // tsPanel
            // 
            this.tsPanel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPanelSmall,
            this.tsPanelNormal,
            this.tsPanelBig});
            this.tsPanel.Name = "tsPanel";
            this.tsPanel.Size = new System.Drawing.Size(152, 22);
            this.tsPanel.Text = "Balken";
            // 
            // tsPanelSmall
            // 
            this.tsPanelSmall.CheckOnClick = true;
            this.tsPanelSmall.Name = "tsPanelSmall";
            this.tsPanelSmall.Size = new System.Drawing.Size(114, 22);
            this.tsPanelSmall.Text = "Schmal";
            this.tsPanelSmall.Click += new System.EventHandler(this.ctxtMenu_Click);
            // 
            // tsPanelNormal
            // 
            this.tsPanelNormal.CheckOnClick = true;
            this.tsPanelNormal.Name = "tsPanelNormal";
            this.tsPanelNormal.Size = new System.Drawing.Size(114, 22);
            this.tsPanelNormal.Text = "Normal";
            this.tsPanelNormal.Click += new System.EventHandler(this.ctxtMenu_Click);
            // 
            // tsPanelBig
            // 
            this.tsPanelBig.CheckOnClick = true;
            this.tsPanelBig.Name = "tsPanelBig";
            this.tsPanelBig.Size = new System.Drawing.Size(114, 22);
            this.tsPanelBig.Text = "Breit";
            this.tsPanelBig.Click += new System.EventHandler(this.ctxtMenu_Click);
            // 
            // tsBall
            // 
            this.tsBall.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBallSlow,
            this.tsBallNormal,
            this.tsBallFast});
            this.tsBall.Name = "tsBall";
            this.tsBall.Size = new System.Drawing.Size(152, 22);
            this.tsBall.Text = "Ball";
            // 
            // tsBallSlow
            // 
            this.tsBallSlow.CheckOnClick = true;
            this.tsBallSlow.Name = "tsBallSlow";
            this.tsBallSlow.Size = new System.Drawing.Size(152, 22);
            this.tsBallSlow.Text = "Langsam";
            this.tsBallSlow.Click += new System.EventHandler(this.ctxtMenu_Click);
            // 
            // tsBallNormal
            // 
            this.tsBallNormal.CheckOnClick = true;
            this.tsBallNormal.Name = "tsBallNormal";
            this.tsBallNormal.Size = new System.Drawing.Size(152, 22);
            this.tsBallNormal.Text = "Normal";
            this.tsBallNormal.Click += new System.EventHandler(this.ctxtMenu_Click);
            // 
            // tsBallFast
            // 
            this.tsBallFast.CheckOnClick = true;
            this.tsBallFast.Name = "tsBallFast";
            this.tsBallFast.Size = new System.Drawing.Size(152, 22);
            this.tsBallFast.Text = "Schnell";
            this.tsBallFast.Click += new System.EventHandler(this.ctxtMenu_Click);
            // 
            // tsFullscreen
            // 
            this.tsFullscreen.Checked = true;
            this.tsFullscreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsFullscreen.Name = "tsFullscreen";
            this.tsFullscreen.Size = new System.Drawing.Size(152, 22);
            this.tsFullscreen.Text = "Vollbild";
            this.tsFullscreen.Click += new System.EventHandler(this.tsFullscreen_Click);
            // 
            // tsClose
            // 
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(152, 22);
            this.tsClose.Text = "Schliessen";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1044, 583);
            this.Controls.Add(this.pnlPlayer1);
            this.Controls.Add(this.pnlPlayer2);
            this.Controls.Add(this.pBall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1044, 583);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyUp);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pBall)).EndInit();
            this.ctxtMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.PictureBox pBall;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Timer timerPaddle;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Timer timerBall;
        private System.Windows.Forms.Timer timerIncreaseSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip ctxtMenu;
        private System.Windows.Forms.ToolStripMenuItem tsPanel;
        private System.Windows.Forms.ToolStripMenuItem tsPanelSmall;
        private System.Windows.Forms.ToolStripMenuItem tsPanelNormal;
        private System.Windows.Forms.ToolStripMenuItem tsPanelBig;
        private System.Windows.Forms.ToolStripMenuItem tsBall;
        private System.Windows.Forms.ToolStripMenuItem tsBallSlow;
        private System.Windows.Forms.ToolStripMenuItem tsBallNormal;
        private System.Windows.Forms.ToolStripMenuItem tsBallFast;
        private System.Windows.Forms.ToolStripMenuItem tsFullscreen;
        private System.Windows.Forms.ToolStripMenuItem tsClose;
    }
}
