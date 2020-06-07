namespace Calculate_Spare_Money
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblSpareMoney = new System.Windows.Forms.Label();
            this.lblPromptSpareMoney = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtBankAmount = new System.Windows.Forms.TextBox();
            this.lblPromptBankAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddMoney = new System.Windows.Forms.TextBox();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.txtSubtractMoney = new System.Windows.Forms.TextBox();
            this.btnSubtractMoney = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.monthCalendar1.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.monthCalendar1.Location = new System.Drawing.Point(67, 194);
            this.monthCalendar1.MaxSelectionCount = 20;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TabStop = false;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblSpareMoney
            // 
            this.lblSpareMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblSpareMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpareMoney.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSpareMoney.Location = new System.Drawing.Point(67, 150);
            this.lblSpareMoney.Name = "lblSpareMoney";
            this.lblSpareMoney.Size = new System.Drawing.Size(173, 23);
            this.lblSpareMoney.TabIndex = 1;
            this.lblSpareMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromptSpareMoney
            // 
            this.lblPromptSpareMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblPromptSpareMoney.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPromptSpareMoney.Location = new System.Drawing.Point(64, 127);
            this.lblPromptSpareMoney.Name = "lblPromptSpareMoney";
            this.lblPromptSpareMoney.Size = new System.Drawing.Size(150, 23);
            this.lblPromptSpareMoney.TabIndex = 2;
            this.lblPromptSpareMoney.Text = "Spare Money";
            this.lblPromptSpareMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(420, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(346, 281);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Silver;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(306, 324);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 32);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.TabStop = false;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtBankAmount
            // 
            this.txtBankAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBankAmount.Location = new System.Drawing.Point(67, 101);
            this.txtBankAmount.Name = "txtBankAmount";
            this.txtBankAmount.Size = new System.Drawing.Size(153, 20);
            this.txtBankAmount.TabIndex = 1;
            this.txtBankAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBankAmount.Leave += new System.EventHandler(this.txtBankAmount_Leave);
            // 
            // lblPromptBankAmount
            // 
            this.lblPromptBankAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPromptBankAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPromptBankAmount.Location = new System.Drawing.Point(67, 75);
            this.lblPromptBankAmount.Name = "lblPromptBankAmount";
            this.lblPromptBankAmount.Size = new System.Drawing.Size(153, 23);
            this.lblPromptBankAmount.TabIndex = 6;
            this.lblPromptBankAmount.Text = "Bank Balance";
            this.lblPromptBankAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(45, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddMoney
            // 
            this.txtAddMoney.Location = new System.Drawing.Point(251, 100);
            this.txtAddMoney.Name = "txtAddMoney";
            this.txtAddMoney.Size = new System.Drawing.Size(63, 20);
            this.txtAddMoney.TabIndex = 2;
            this.txtAddMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddMoney.Enter += new System.EventHandler(this.txtAddMoney_Enter);
            this.txtAddMoney.Leave += new System.EventHandler(this.txtAddMoney_Leave);
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.BackColor = System.Drawing.Color.Silver;
            this.btnAddMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMoney.Font = new System.Drawing.Font("Bernard MT Condensed", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMoney.ForeColor = System.Drawing.Color.Black;
            this.btnAddMoney.Location = new System.Drawing.Point(321, 101);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(38, 20);
            this.btnAddMoney.TabIndex = 10;
            this.btnAddMoney.TabStop = false;
            this.btnAddMoney.Text = "+";
            this.btnAddMoney.UseVisualStyleBackColor = false;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // txtSubtractMoney
            // 
            this.txtSubtractMoney.Location = new System.Drawing.Point(251, 152);
            this.txtSubtractMoney.Name = "txtSubtractMoney";
            this.txtSubtractMoney.Size = new System.Drawing.Size(63, 20);
            this.txtSubtractMoney.TabIndex = 3;
            this.txtSubtractMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubtractMoney.Enter += new System.EventHandler(this.txtSubtractMoney_Enter);
            this.txtSubtractMoney.Leave += new System.EventHandler(this.txtSubtractMoney_Leave);
            // 
            // btnSubtractMoney
            // 
            this.btnSubtractMoney.BackColor = System.Drawing.Color.Silver;
            this.btnSubtractMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtractMoney.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtractMoney.ForeColor = System.Drawing.Color.Black;
            this.btnSubtractMoney.Location = new System.Drawing.Point(321, 152);
            this.btnSubtractMoney.Name = "btnSubtractMoney";
            this.btnSubtractMoney.Size = new System.Drawing.Size(38, 21);
            this.btnSubtractMoney.TabIndex = 12;
            this.btnSubtractMoney.TabStop = false;
            this.btnSubtractMoney.Text = "-";
            this.btnSubtractMoney.UseVisualStyleBackColor = false;
            this.btnSubtractMoney.Click += new System.EventHandler(this.btnSubtractMoney_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 29);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(316, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Calculate Budget";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.Transparent;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.SystemColors.Control;
            this.lblX.Location = new System.Drawing.Point(3, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 17);
            this.lblX.TabIndex = 14;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(45, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "$";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Calculate_Spare_Money.Properties.Resources.Black_Matte_Vinyl_Wraps;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSubtractMoney);
            this.Controls.Add(this.txtSubtractMoney);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.txtAddMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPromptBankAmount);
            this.Controls.Add(this.txtBankAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPromptSpareMoney);
            this.Controls.Add(this.lblSpareMoney);
            this.Controls.Add(this.monthCalendar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculate Spare Money";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblSpareMoney;
        private System.Windows.Forms.Label lblPromptSpareMoney;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtBankAmount;
        private System.Windows.Forms.Label lblPromptBankAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddMoney;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.TextBox txtSubtractMoney;
        private System.Windows.Forms.Button btnSubtractMoney;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

