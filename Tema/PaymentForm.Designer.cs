namespace Tema
{
    partial class PaymentForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblSold = new System.Windows.Forms.Label();
            this.spAccount1Sold = new System.Windows.Forms.NumericUpDown();
            this.gcPayment = new System.Windows.Forms.GroupBox();
            this.spPaymentValue = new System.Windows.Forms.NumericUpDown();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spTransferFrom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTransferFrom = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.spAccount2Sold = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.spTransferTo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTransferTo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spAccount1Sold)).BeginInit();
            this.gcPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spPaymentValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spTransferFrom)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spAccount2Sold)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spTransferTo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(197, 16);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(79, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirma";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Location = new System.Drawing.Point(6, 21);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(57, 13);
            this.lblSold.TabIndex = 2;
            this.lblSold.Text = "Sold initial:";
            // 
            // spAccount1Sold
            // 
            this.spAccount1Sold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spAccount1Sold.Location = new System.Drawing.Point(69, 19);
            this.spAccount1Sold.Name = "spAccount1Sold";
            this.spAccount1Sold.Size = new System.Drawing.Size(122, 20);
            this.spAccount1Sold.TabIndex = 0;
            this.spAccount1Sold.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spSold_KeyDown);
            // 
            // gcPayment
            // 
            this.gcPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcPayment.Controls.Add(this.spPaymentValue);
            this.gcPayment.Controls.Add(this.spAccount1Sold);
            this.gcPayment.Controls.Add(this.lblWithdraw);
            this.gcPayment.Controls.Add(this.lblSold);
            this.gcPayment.Controls.Add(this.btnWithdraw);
            this.gcPayment.Controls.Add(this.btnConfirm);
            this.gcPayment.Location = new System.Drawing.Point(6, 19);
            this.gcPayment.Name = "gcPayment";
            this.gcPayment.Size = new System.Drawing.Size(282, 75);
            this.gcPayment.TabIndex = 4;
            this.gcPayment.TabStop = false;
            this.gcPayment.Text = "Plata bancara";
            // 
            // spPaymentValue
            // 
            this.spPaymentValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spPaymentValue.Location = new System.Drawing.Point(69, 48);
            this.spPaymentValue.Name = "spPaymentValue";
            this.spPaymentValue.Size = new System.Drawing.Size(122, 20);
            this.spPaymentValue.TabIndex = 1;
            this.spPaymentValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spPaymentValue_KeyDown);
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(6, 50);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(57, 13);
            this.lblWithdraw.TabIndex = 2;
            this.lblWithdraw.Text = "Retragere:";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWithdraw.Location = new System.Drawing.Point(197, 45);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(79, 23);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Confirma";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spTransferFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTransferFrom);
            this.groupBox1.Location = new System.Drawing.Point(6, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer";
            // 
            // spTransferFrom
            // 
            this.spTransferFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spTransferFrom.Location = new System.Drawing.Point(69, 19);
            this.spTransferFrom.Name = "spTransferFrom";
            this.spTransferFrom.Size = new System.Drawing.Size(122, 20);
            this.spTransferFrom.TabIndex = 0;
            this.spTransferFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spSold_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valoare:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gcPayment);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 155);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cont 1";
            // 
            // btnTransferFrom
            // 
            this.btnTransferFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransferFrom.Location = new System.Drawing.Point(197, 16);
            this.btnTransferFrom.Name = "btnTransferFrom";
            this.btnTransferFrom.Size = new System.Drawing.Size(79, 23);
            this.btnTransferFrom.TabIndex = 1;
            this.btnTransferFrom.Text = "Confirma";
            this.btnTransferFrom.UseVisualStyleBackColor = true;
            this.btnTransferFrom.Click += new System.EventHandler(this.btnTransferFrom_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(312, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 155);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cont 2";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.spAccount2Sold);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 75);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plata bancara";
            // 
            // spAccount2Sold
            // 
            this.spAccount2Sold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spAccount2Sold.Enabled = false;
            this.spAccount2Sold.Location = new System.Drawing.Point(69, 19);
            this.spAccount2Sold.Name = "spAccount2Sold";
            this.spAccount2Sold.Size = new System.Drawing.Size(122, 20);
            this.spAccount2Sold.TabIndex = 0;
            this.spAccount2Sold.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spSold_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sold:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.spTransferTo);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.btnTransferTo);
            this.groupBox5.Location = new System.Drawing.Point(6, 100);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 48);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Transfer";
            // 
            // spTransferTo
            // 
            this.spTransferTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spTransferTo.Location = new System.Drawing.Point(69, 19);
            this.spTransferTo.Name = "spTransferTo";
            this.spTransferTo.Size = new System.Drawing.Size(122, 20);
            this.spTransferTo.TabIndex = 0;
            this.spTransferTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spSold_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valoare:";
            // 
            // btnTransferTo
            // 
            this.btnTransferTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransferTo.Location = new System.Drawing.Point(197, 16);
            this.btnTransferTo.Name = "btnTransferTo";
            this.btnTransferTo.Size = new System.Drawing.Size(79, 23);
            this.btnTransferTo.TabIndex = 1;
            this.btnTransferTo.Text = "Confirma";
            this.btnTransferTo.UseVisualStyleBackColor = true;
            this.btnTransferTo.Click += new System.EventHandler(this.btnTransferTo_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 172);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "PaymentForm";
            this.Text = "Plata bancara";
            ((System.ComponentModel.ISupportInitialize)(this.spAccount1Sold)).EndInit();
            this.gcPayment.ResumeLayout(false);
            this.gcPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spPaymentValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spTransferFrom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spAccount2Sold)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spTransferTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.NumericUpDown spAccount1Sold;
        private System.Windows.Forms.GroupBox gcPayment;
        private System.Windows.Forms.NumericUpDown spPaymentValue;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown spTransferFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTransferFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown spAccount2Sold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown spTransferTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTransferTo;
    }
}

