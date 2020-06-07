namespace Calculate_Spare_Money
{
    partial class te
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddAmount = new System.Windows.Forms.TextBox();
            this.txtAddMonthlyDueDate = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddAmount = new System.Windows.Forms.Label();
            this.lblAddMonthlyDueDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabAdd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabDelete = new System.Windows.Forms.Button();
            this.listBills = new System.Windows.Forms.CheckedListBox();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.lblDollarSign = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(214, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 100);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(121, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add/Delete Bill";
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
            this.lblX.TabIndex = 5;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.Silver;
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.btnAddBill.Location = new System.Drawing.Point(148, 171);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(86, 27);
            this.btnAddBill.TabIndex = 4;
            this.btnAddBill.Text = "Add";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(205, 70);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(146, 20);
            this.txtAddName.TabIndex = 1;
            this.txtAddName.Enter += new System.EventHandler(this.txtAddName_Enter);
            // 
            // txtAddAmount
            // 
            this.txtAddAmount.Location = new System.Drawing.Point(205, 96);
            this.txtAddAmount.Name = "txtAddAmount";
            this.txtAddAmount.Size = new System.Drawing.Size(60, 20);
            this.txtAddAmount.TabIndex = 2;
            this.txtAddAmount.Enter += new System.EventHandler(this.txtAddAmount_Enter);
            // 
            // txtAddMonthlyDueDate
            // 
            this.txtAddMonthlyDueDate.Location = new System.Drawing.Point(205, 122);
            this.txtAddMonthlyDueDate.Name = "txtAddMonthlyDueDate";
            this.txtAddMonthlyDueDate.Size = new System.Drawing.Size(37, 20);
            this.txtAddMonthlyDueDate.TabIndex = 3;
            this.txtAddMonthlyDueDate.Enter += new System.EventHandler(this.txtAddMonthlyDueDate_Enter);
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.BackColor = System.Drawing.Color.Transparent;
            this.lblAddName.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddName.Location = new System.Drawing.Point(140, 68);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(46, 17);
            this.lblAddName.TabIndex = 5;
            this.lblAddName.Text = "Name";
            // 
            // lblAddAmount
            // 
            this.lblAddAmount.AutoSize = true;
            this.lblAddAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAddAmount.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddAmount.Location = new System.Drawing.Point(123, 97);
            this.lblAddAmount.Name = "lblAddAmount";
            this.lblAddAmount.Size = new System.Drawing.Size(63, 17);
            this.lblAddAmount.TabIndex = 6;
            this.lblAddAmount.Text = "Amount";
            // 
            // lblAddMonthlyDueDate
            // 
            this.lblAddMonthlyDueDate.AutoSize = true;
            this.lblAddMonthlyDueDate.BackColor = System.Drawing.Color.Transparent;
            this.lblAddMonthlyDueDate.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMonthlyDueDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddMonthlyDueDate.Location = new System.Drawing.Point(47, 125);
            this.lblAddMonthlyDueDate.Name = "lblAddMonthlyDueDate";
            this.lblAddMonthlyDueDate.Size = new System.Drawing.Size(139, 17);
            this.lblAddMonthlyDueDate.TabIndex = 7;
            this.lblAddMonthlyDueDate.Text = "Monthly Due Date";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabAdd);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 24);
            this.panel2.TabIndex = 8;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.Silver;
            this.tabAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabAdd.ForeColor = System.Drawing.Color.Black;
            this.tabAdd.Location = new System.Drawing.Point(0, 0);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Size = new System.Drawing.Size(201, 24);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.TabStop = false;
            this.tabAdd.Text = "Add Bill";
            this.tabAdd.UseVisualStyleBackColor = false;
            this.tabAdd.Click += new System.EventHandler(this.btnTabAdd_Click);
            this.tabAdd.Enter += new System.EventHandler(this.tabAdd_Enter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabDelete);
            this.panel4.Location = new System.Drawing.Point(202, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 24);
            this.panel4.TabIndex = 9;
            // 
            // tabDelete
            // 
            this.tabDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabDelete.Location = new System.Drawing.Point(0, 0);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(201, 24);
            this.tabDelete.TabIndex = 1;
            this.tabDelete.TabStop = false;
            this.tabDelete.Text = "Delete Bill";
            this.tabDelete.UseVisualStyleBackColor = true;
            this.tabDelete.Click += new System.EventHandler(this.tabDelete_Click);
            this.tabDelete.Enter += new System.EventHandler(this.tabDelete_Enter);
            // 
            // listBills
            // 
            this.listBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.listBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBills.CheckOnClick = true;
            this.listBills.ForeColor = System.Drawing.SystemColors.Control;
            this.listBills.FormattingEnabled = true;
            this.listBills.Location = new System.Drawing.Point(14, 68);
            this.listBills.Name = "listBills";
            this.listBills.Size = new System.Drawing.Size(187, 150);
            this.listBills.TabIndex = 10;
            this.listBills.Visible = false;
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BackColor = System.Drawing.Color.Silver;
            this.btnDeleteBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBill.Font = new System.Drawing.Font("Modern No. 20", 11.25F);
            this.btnDeleteBill.Location = new System.Drawing.Point(248, 125);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(86, 27);
            this.btnDeleteBill.TabIndex = 13;
            this.btnDeleteBill.Text = "Delete";
            this.btnDeleteBill.UseVisualStyleBackColor = false;
            this.btnDeleteBill.Visible = false;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // lblDollarSign
            // 
            this.lblDollarSign.BackColor = System.Drawing.Color.Transparent;
            this.lblDollarSign.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDollarSign.Location = new System.Drawing.Point(186, 94);
            this.lblDollarSign.Name = "lblDollarSign";
            this.lblDollarSign.Size = new System.Drawing.Size(18, 23);
            this.lblDollarSign.TabIndex = 14;
            this.lblDollarSign.Text = "$";
            this.lblDollarSign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // te
            // 
            this.AcceptButton = this.btnAddBill;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Calculate_Spare_Money.Properties.Resources.Black_Matte_Vinyl_Wraps;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(403, 238);
            this.Controls.Add(this.lblDollarSign);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblAddMonthlyDueDate);
            this.Controls.Add(this.lblAddAmount);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.txtAddMonthlyDueDate);
            this.Controls.Add(this.txtAddAmount);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBills);
            this.Controls.Add(this.btnDeleteBill);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(403, 238);
            this.MinimumSize = new System.Drawing.Size(403, 238);
            this.Name = "te";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddBill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddAmount;
        private System.Windows.Forms.TextBox txtAddMonthlyDueDate;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddAmount;
        private System.Windows.Forms.Label lblAddMonthlyDueDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tabAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button tabDelete;
        private System.Windows.Forms.CheckedListBox listBills;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Label lblDollarSign;
    }
}