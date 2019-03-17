namespace Printing.Kiosk.Forms
{
    partial class ComputationSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputationSummary));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtTotalAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTotalComputation = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNoOfCopies = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblNoOfCopies = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtCurrentBal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblCurrentBal = new System.Windows.Forms.Label();
            this.lblColored = new System.Windows.Forms.Label();
            this.txtColored = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnDispense = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWithPaper = new System.Windows.Forms.Button();
            this.txtNoOfPages = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblNoOfPages = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTotalAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalAmount.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTotalAmount.BorderThickness = 3;
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmount.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.Gray;
            this.txtTotalAmount.isPassword = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(178, 259);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(259, 44);
            this.txtTotalAmount.TabIndex = 0;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalComputation
            // 
            this.lblTotalComputation.AutoSize = true;
            this.lblTotalComputation.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComputation.Location = new System.Drawing.Point(26, 28);
            this.lblTotalComputation.Name = "lblTotalComputation";
            this.lblTotalComputation.Size = new System.Drawing.Size(301, 38);
            this.lblTotalComputation.TabIndex = 1;
            this.lblTotalComputation.Text = "Total Computation";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(33, 69);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(439, 19);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(30, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(182, 90);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(30, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 88);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNoOfCopies
            // 
            this.txtNoOfCopies.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNoOfCopies.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoOfCopies.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtNoOfCopies.BorderThickness = 3;
            this.txtNoOfCopies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoOfCopies.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfCopies.ForeColor = System.Drawing.Color.Gray;
            this.txtNoOfCopies.isPassword = false;
            this.txtNoOfCopies.Location = new System.Drawing.Point(178, 207);
            this.txtNoOfCopies.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoOfCopies.Name = "txtNoOfCopies";
            this.txtNoOfCopies.Size = new System.Drawing.Size(259, 44);
            this.txtNoOfCopies.TabIndex = 5;
            this.txtNoOfCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNoOfCopies
            // 
            this.lblNoOfCopies.AutoSize = true;
            this.lblNoOfCopies.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfCopies.Location = new System.Drawing.Point(63, 219);
            this.lblNoOfCopies.Name = "lblNoOfCopies";
            this.lblNoOfCopies.Size = new System.Drawing.Size(107, 18);
            this.lblNoOfCopies.TabIndex = 6;
            this.lblNoOfCopies.Text = "No of Copies:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(64, 272);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(107, 18);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // txtCurrentBal
            // 
            this.txtCurrentBal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtCurrentBal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurrentBal.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtCurrentBal.BorderThickness = 3;
            this.txtCurrentBal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentBal.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentBal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurrentBal.isPassword = false;
            this.txtCurrentBal.Location = new System.Drawing.Point(100, 379);
            this.txtCurrentBal.Margin = new System.Windows.Forms.Padding(7);
            this.txtCurrentBal.Name = "txtCurrentBal";
            this.txtCurrentBal.Size = new System.Drawing.Size(303, 127);
            this.txtCurrentBal.TabIndex = 8;
            this.txtCurrentBal.Text = "0";
            this.txtCurrentBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurrentBal
            // 
            this.lblCurrentBal.AutoSize = true;
            this.lblCurrentBal.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBal.Location = new System.Drawing.Point(96, 355);
            this.lblCurrentBal.Name = "lblCurrentBal";
            this.lblCurrentBal.Size = new System.Drawing.Size(168, 23);
            this.lblCurrentBal.TabIndex = 9;
            this.lblCurrentBal.Text = "Current Balance";
            // 
            // lblColored
            // 
            this.lblColored.AutoSize = true;
            this.lblColored.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColored.Location = new System.Drawing.Point(97, 119);
            this.lblColored.Name = "lblColored";
            this.lblColored.Size = new System.Drawing.Size(73, 18);
            this.lblColored.TabIndex = 10;
            this.lblColored.Text = "Colored:";
            // 
            // txtColored
            // 
            this.txtColored.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtColored.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtColored.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtColored.BorderThickness = 3;
            this.txtColored.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColored.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColored.ForeColor = System.Drawing.Color.Gray;
            this.txtColored.isPassword = false;
            this.txtColored.Location = new System.Drawing.Point(178, 107);
            this.txtColored.Margin = new System.Windows.Forms.Padding(4);
            this.txtColored.Name = "txtColored";
            this.txtColored.Size = new System.Drawing.Size(259, 44);
            this.txtColored.TabIndex = 11;
            this.txtColored.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 355);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(29, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(33, 341);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(439, 10);
            this.bunifuSeparator2.TabIndex = 13;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnDispense
            // 
            this.btnDispense.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispense.Location = new System.Drawing.Point(31, 220);
            this.btnDispense.Name = "btnDispense";
            this.btnDispense.Size = new System.Drawing.Size(182, 97);
            this.btnDispense.TabIndex = 14;
            this.btnDispense.Text = "Dispense Paper";
            this.btnDispense.UseVisualStyleBackColor = true;
            this.btnDispense.Click += new System.EventHandler(this.btnDispense_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWithPaper);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnDispense);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(478, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 437);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnWithPaper
            // 
            this.btnWithPaper.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithPaper.Location = new System.Drawing.Point(31, 116);
            this.btnWithPaper.Name = "btnWithPaper";
            this.btnWithPaper.Size = new System.Drawing.Size(182, 90);
            this.btnWithPaper.TabIndex = 15;
            this.btnWithPaper.Text = "w/ Paper";
            this.btnWithPaper.UseVisualStyleBackColor = true;
            this.btnWithPaper.Click += new System.EventHandler(this.btnWithPaper_Click);
            // 
            // txtNoOfPages
            // 
            this.txtNoOfPages.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNoOfPages.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNoOfPages.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtNoOfPages.BorderThickness = 3;
            this.txtNoOfPages.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoOfPages.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfPages.ForeColor = System.Drawing.Color.Gray;
            this.txtNoOfPages.isPassword = false;
            this.txtNoOfPages.Location = new System.Drawing.Point(178, 159);
            this.txtNoOfPages.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoOfPages.Name = "txtNoOfPages";
            this.txtNoOfPages.Size = new System.Drawing.Size(259, 44);
            this.txtNoOfPages.TabIndex = 16;
            this.txtNoOfPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNoOfPages
            // 
            this.lblNoOfPages.AutoSize = true;
            this.lblNoOfPages.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfPages.Location = new System.Drawing.Point(72, 171);
            this.lblNoOfPages.Name = "lblNoOfPages";
            this.lblNoOfPages.Size = new System.Drawing.Size(99, 18);
            this.lblNoOfPages.TabIndex = 17;
            this.lblNoOfPages.Text = "No of Pages:";
            // 
            // ComputationSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 522);
            this.Controls.Add(this.lblNoOfPages);
            this.Controls.Add(this.txtNoOfPages);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtColored);
            this.Controls.Add(this.lblColored);
            this.Controls.Add(this.lblCurrentBal);
            this.Controls.Add(this.txtCurrentBal);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblNoOfCopies);
            this.Controls.Add(this.txtNoOfCopies);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblTotalComputation);
            this.Controls.Add(this.txtTotalAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComputationSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComputationSummary";
            this.Load += new System.EventHandler(this.ComputationSummary_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.Label lblTotalComputation;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtTotalAmount;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.Label lblTotalAmount;
        public System.Windows.Forms.Label lblNoOfCopies;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtNoOfCopies;
        public System.Windows.Forms.Label lblCurrentBal;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtCurrentBal;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtColored;
        public System.Windows.Forms.Label lblColored;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnDispense;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        public System.Windows.Forms.Label lblNoOfPages;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtNoOfPages;
        public System.Windows.Forms.Button btnWithPaper;
    }
}