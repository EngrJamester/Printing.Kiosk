namespace Printing.Kiosk.Forms
{
    partial class frmAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnUpdate = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnShutdown = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuTileButton();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.lblAdminStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.color = System.Drawing.Color.DarkGray;
            this.btnUpdate.colorActive = System.Drawing.Color.DimGray;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImagePosition = 20;
            this.btnUpdate.ImageZoom = 50;
            this.btnUpdate.LabelPosition = 41;
            this.btnUpdate.LabelText = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(19, 15);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 129);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.DarkGray;
            this.btnShutdown.color = System.Drawing.Color.DarkGray;
            this.btnShutdown.colorActive = System.Drawing.Color.DimGray;
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnShutdown.ForeColor = System.Drawing.Color.White;
            this.btnShutdown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutdown.Image")));
            this.btnShutdown.ImagePosition = 20;
            this.btnShutdown.ImageZoom = 50;
            this.btnShutdown.LabelPosition = 41;
            this.btnShutdown.LabelText = "Shutdown";
            this.btnShutdown.Location = new System.Drawing.Point(201, 15);
            this.btnShutdown.Margin = new System.Windows.Forms.Padding(6);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(128, 129);
            this.btnShutdown.TabIndex = 1;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.color = System.Drawing.Color.DarkGray;
            this.btnCancel.colorActive = System.Drawing.Color.DimGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImagePosition = 20;
            this.btnCancel.ImageZoom = 50;
            this.btnCancel.LabelPosition = 41;
            this.btnCancel.LabelText = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(386, 555);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 129);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiplier.Location = new System.Drawing.Point(32, 116);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.ReadOnly = true;
            this.txtMultiplier.Size = new System.Drawing.Size(483, 66);
            this.txtMultiplier.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price Multiplier";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 72);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(531, 15);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(35, 185);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(96, 21);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "No update";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(42, 18);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(94, 86);
            this.btnOne.TabIndex = 11;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(162, 18);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(94, 86);
            this.btnTwo.TabIndex = 12;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(280, 18);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(94, 86);
            this.btnThree.TabIndex = 13;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(392, 18);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(94, 86);
            this.btnFour.TabIndex = 14;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(392, 123);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(94, 86);
            this.btnEight.TabIndex = 18;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(280, 123);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(94, 86);
            this.btnSeven.TabIndex = 17;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(162, 123);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(94, 86);
            this.btnSix.TabIndex = 16;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(42, 123);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(94, 86);
            this.btnFive.TabIndex = 15;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(44, 226);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(94, 86);
            this.btnNine.TabIndex = 19;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnTen
            // 
            this.btnTen.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTen.Location = new System.Drawing.Point(162, 226);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(94, 86);
            this.btnTen.TabIndex = 20;
            this.btnTen.Text = "0";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriod.Location = new System.Drawing.Point(280, 226);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(94, 86);
            this.btnPeriod.TabIndex = 21;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(392, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 86);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "DEL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnDelete);
            this.groupBox.Controls.Add(this.btnOne);
            this.groupBox.Controls.Add(this.btnPeriod);
            this.groupBox.Controls.Add(this.btnTwo);
            this.groupBox.Controls.Add(this.btnTen);
            this.groupBox.Controls.Add(this.btnThree);
            this.groupBox.Controls.Add(this.btnNine);
            this.groupBox.Controls.Add(this.btnFour);
            this.groupBox.Controls.Add(this.btnEight);
            this.groupBox.Controls.Add(this.btnFive);
            this.groupBox.Controls.Add(this.btnSeven);
            this.groupBox.Controls.Add(this.btnSix);
            this.groupBox.Location = new System.Drawing.Point(12, 209);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(531, 325);
            this.groupBox.TabIndex = 23;
            this.groupBox.TabStop = false;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.btnUpdate);
            this.groupBoxButtons.Controls.Add(this.btnShutdown);
            this.groupBoxButtons.Location = new System.Drawing.Point(12, 540);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(346, 153);
            this.groupBoxButtons.TabIndex = 24;
            this.groupBoxButtons.TabStop = false;
            // 
            // lblAdminStatus
            // 
            this.lblAdminStatus.AutoSize = true;
            this.lblAdminStatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminStatus.Location = new System.Drawing.Point(451, 86);
            this.lblAdminStatus.Name = "lblAdminStatus";
            this.lblAdminStatus.Size = new System.Drawing.Size(64, 23);
            this.lblAdminStatus.TabIndex = 25;
            this.lblAdminStatus.Text = "Status";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 710);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAdminStatus);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMultiplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatus;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMultiplier;
        private Bunifu.Framework.UI.BunifuTileButton btnCancel;
        private Bunifu.Framework.UI.BunifuTileButton btnShutdown;
        private Bunifu.Framework.UI.BunifuTileButton btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblAdminStatus;
        private System.Windows.Forms.GroupBox groupBoxButtons;
    }
}