﻿namespace RetroTable.Main
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnPong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnBounce = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(10, 10);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(125, 125);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "+";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnPong
            // 
            this.btnPong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPong.Location = new System.Drawing.Point(263, 187);
            this.btnPong.Name = "btnPong";
            this.btnPong.Size = new System.Drawing.Size(125, 125);
            this.btnPong.TabIndex = 3;
            this.btnPong.Text = "Pong";
            this.btnPong.UseVisualStyleBackColor = true;
            this.btnPong.Click += new System.EventHandler(this.btnPong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pnlUser
            // 
            this.pnlUser.AutoScroll = true;
            this.pnlUser.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.pnlUser.Controls.Add(this.btnAddUser);
            this.pnlUser.Location = new System.Drawing.Point(12, 341);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(776, 157);
            this.pnlUser.TabIndex = 6;
            // 
            // lblInfo
            // 
            this.lblInfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblInfo.Location = new System.Drawing.Point(12, 501);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(776, 21);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBounce
            // 
            this.btnBounce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBounce.Location = new System.Drawing.Point(413, 187);
            this.btnBounce.Name = "btnBounce";
            this.btnBounce.Size = new System.Drawing.Size(125, 125);
            this.btnBounce.TabIndex = 8;
            this.btnBounce.Text = "Prellball";
            this.btnBounce.UseVisualStyleBackColor = true;
            this.btnBounce.Click += new System.EventHandler(this.btnBounce_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.btnBounce);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.btnPong);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnPong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnBounce;
    }
}