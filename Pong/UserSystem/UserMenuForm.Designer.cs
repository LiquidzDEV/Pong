﻿namespace RetroTable.UserSystem
{
    partial class UserMenuForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.trbBallSpeed = new System.Windows.Forms.TrackBar();
            this.trbPanelSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBallSpeed = new System.Windows.Forms.Label();
            this.lblPanelSize = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbBallSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPanelSize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 0;
            // 
            // trbBallSpeed
            // 
            this.trbBallSpeed.LargeChange = 50;
            this.trbBallSpeed.Location = new System.Drawing.Point(121, 46);
            this.trbBallSpeed.Maximum = 500;
            this.trbBallSpeed.Minimum = 100;
            this.trbBallSpeed.Name = "trbBallSpeed";
            this.trbBallSpeed.Size = new System.Drawing.Size(267, 45);
            this.trbBallSpeed.SmallChange = 5;
            this.trbBallSpeed.TabIndex = 1;
            this.trbBallSpeed.TickFrequency = 25;
            this.trbBallSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbBallSpeed.Value = 200;
            this.trbBallSpeed.Scroll += new System.EventHandler(this.trbBallSpeed_Scroll);
            // 
            // trbPanelSize
            // 
            this.trbPanelSize.LargeChange = 30;
            this.trbPanelSize.Location = new System.Drawing.Point(122, 97);
            this.trbPanelSize.Maximum = 400;
            this.trbPanelSize.Minimum = 50;
            this.trbPanelSize.Name = "trbPanelSize";
            this.trbPanelSize.Size = new System.Drawing.Size(266, 45);
            this.trbPanelSize.TabIndex = 2;
            this.trbPanelSize.TickFrequency = 10;
            this.trbPanelSize.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbPanelSize.Value = 150;
            this.trbPanelSize.Scroll += new System.EventHandler(this.trbPanelSize_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Benutzername:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ballgeschwindigkeit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Balkengröße:";
            // 
            // lblBallSpeed
            // 
            this.lblBallSpeed.AutoSize = true;
            this.lblBallSpeed.Location = new System.Drawing.Point(12, 59);
            this.lblBallSpeed.Name = "lblBallSpeed";
            this.lblBallSpeed.Size = new System.Drawing.Size(22, 13);
            this.lblBallSpeed.TabIndex = 6;
            this.lblBallSpeed.Text = "2.0";
            // 
            // lblPanelSize
            // 
            this.lblPanelSize.AutoSize = true;
            this.lblPanelSize.Location = new System.Drawing.Point(12, 110);
            this.lblPanelSize.Name = "lblPanelSize";
            this.lblPanelSize.Size = new System.Drawing.Size(36, 13);
            this.lblPanelSize.TabIndex = 7;
            this.lblPanelSize.Text = "150px";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 145);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(376, 17);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "lblInfo";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 169);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(208, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // UserMenuForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(400, 204);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPanelSize);
            this.Controls.Add(this.lblBallSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trbPanelSize);
            this.Controls.Add(this.trbBallSpeed);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserMenuForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.trbBallSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPanelSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TrackBar trbBallSpeed;
        private System.Windows.Forms.TrackBar trbPanelSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBallSpeed;
        private System.Windows.Forms.Label lblPanelSize;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}