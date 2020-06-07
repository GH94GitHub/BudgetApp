namespace Calculate_Spare_Money
{
    partial class ShowHistoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblDateCalculated = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.listCurrentBills = new System.Windows.Forms.CheckedListBox();
            this.btnPaid = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.txtPlus = new System.Windows.Forms.TextBox();
            this.txtMinus = new System.Windows.Forms.TextBox();
            this.lblForDates = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(295, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Budget Overview";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblX.Location = new System.Drawing.Point(3, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 17);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblDateCalculated
            // 
            this.lblDateCalculated.AutoSize = true;
            this.lblDateCalculated.BackColor = System.Drawing.Color.Transparent;
            this.lblDateCalculated.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCalculated.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDateCalculated.Location = new System.Drawing.Point(230, 43);
            this.lblDateCalculated.Name = "lblDateCalculated";
            this.lblDateCalculated.Size = new System.Drawing.Size(220, 29);
            this.lblDateCalculated.TabIndex = 1;
            this.lblDateCalculated.Text = "Date Calculated: ";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.BackColor = System.Drawing.Color.Transparent;
            this.lblBudget.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblBudget.Location = new System.Drawing.Point(326, 123);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(81, 19);
            this.lblBudget.TabIndex = 2;
            this.lblBudget.Text = "Budget: ";
            // 
            // listCurrentBills
            // 
            this.listCurrentBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listCurrentBills.CheckOnClick = true;
            this.listCurrentBills.ForeColor = System.Drawing.SystemColors.Control;
            this.listCurrentBills.FormattingEnabled = true;
            this.listCurrentBills.Location = new System.Drawing.Point(201, 164);
            this.listCurrentBills.Name = "listCurrentBills";
            this.listCurrentBills.Size = new System.Drawing.Size(261, 229);
            this.listCurrentBills.TabIndex = 3;
            this.listCurrentBills.TabStop = false;
            this.listCurrentBills.Enter += new System.EventHandler(this.listCurrentBills_Enter);
            this.listCurrentBills.Leave += new System.EventHandler(this.listCurrentBills_Leave);
            // 
            // btnPaid
            // 
            this.btnPaid.BackColor = System.Drawing.Color.Silver;
            this.btnPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaid.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaid.ForeColor = System.Drawing.Color.Black;
            this.btnPaid.Location = new System.Drawing.Point(476, 249);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(87, 32);
            this.btnPaid.TabIndex = 4;
            this.btnPaid.TabStop = false;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = false;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Silver;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.Black;
            this.btnPlus.Location = new System.Drawing.Point(518, 127);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(21, 20);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.TabStop = false;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Silver;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.Black;
            this.btnMinus.Location = new System.Drawing.Point(641, 127);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(21, 20);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.TabStop = false;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // txtPlus
            // 
            this.txtPlus.Location = new System.Drawing.Point(440, 127);
            this.txtPlus.Name = "txtPlus";
            this.txtPlus.Size = new System.Drawing.Size(72, 20);
            this.txtPlus.TabIndex = 2;
            this.txtPlus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlus.Enter += new System.EventHandler(this.txtPlus_Enter);
            this.txtPlus.Leave += new System.EventHandler(this.txtPlus_Leave);
            // 
            // txtMinus
            // 
            this.txtMinus.Location = new System.Drawing.Point(563, 127);
            this.txtMinus.Name = "txtMinus";
            this.txtMinus.Size = new System.Drawing.Size(72, 20);
            this.txtMinus.TabIndex = 1;
            this.txtMinus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinus.Enter += new System.EventHandler(this.txtMinus_Enter);
            this.txtMinus.Leave += new System.EventHandler(this.txtMinus_Leave);
            // 
            // lblForDates
            // 
            this.lblForDates.AutoSize = true;
            this.lblForDates.BackColor = System.Drawing.Color.Transparent;
            this.lblForDates.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForDates.ForeColor = System.Drawing.SystemColors.Control;
            this.lblForDates.Location = new System.Drawing.Point(80, 78);
            this.lblForDates.Name = "lblForDates";
            this.lblForDates.Size = new System.Drawing.Size(86, 18);
            this.lblForDates.TabIndex = 9;
            this.lblForDates.Text = "For Dates:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(260, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Budget: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(473, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Add/Subtract from the budget.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(198, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bills due in this time period.";
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Silver;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.Black;
            this.btnLog.Location = new System.Drawing.Point(505, 71);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(106, 32);
            this.btnLog.TabIndex = 14;
            this.btnLog.TabStop = false;
            this.btnLog.Text = "History Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Visible = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // ShowHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Calculate_Spare_Money.Properties.Resources.Black_Matte_Vinyl_Wraps;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblForDates);
            this.Controls.Add(this.txtMinus);
            this.Controls.Add(this.txtPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.listCurrentBills);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblDateCalculated);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowHistoryForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateCalculated;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.CheckedListBox listCurrentBills;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.TextBox txtPlus;
        private System.Windows.Forms.TextBox txtMinus;
        private System.Windows.Forms.Label lblForDates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLog;
    }
}