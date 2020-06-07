namespace Calculate_Spare_Money
{
    partial class Main
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
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnShowHistory = new System.Windows.Forms.Button();
            this.btnCalcBudget = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.Silver;
            this.btnAddBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.ForeColor = System.Drawing.Color.Black;
            this.btnAddBill.Location = new System.Drawing.Point(111, 86);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(119, 42);
            this.btnAddBill.TabIndex = 0;
            this.btnAddBill.Text = "Add/Delete Bill";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnShowHistory
            // 
            this.btnShowHistory.BackColor = System.Drawing.Color.Silver;
            this.btnShowHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnShowHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHistory.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHistory.ForeColor = System.Drawing.Color.Black;
            this.btnShowHistory.Location = new System.Drawing.Point(111, 143);
            this.btnShowHistory.Name = "btnShowHistory";
            this.btnShowHistory.Size = new System.Drawing.Size(119, 42);
            this.btnShowHistory.TabIndex = 1;
            this.btnShowHistory.Text = "Show History";
            this.btnShowHistory.UseVisualStyleBackColor = false;
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // btnCalcBudget
            // 
            this.btnCalcBudget.BackColor = System.Drawing.Color.Silver;
            this.btnCalcBudget.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalcBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcBudget.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcBudget.ForeColor = System.Drawing.Color.Black;
            this.btnCalcBudget.Location = new System.Drawing.Point(111, 200);
            this.btnCalcBudget.Name = "btnCalcBudget";
            this.btnCalcBudget.Size = new System.Drawing.Size(119, 45);
            this.btnCalcBudget.TabIndex = 2;
            this.btnCalcBudget.Text = "Calculate Budget";
            this.btnCalcBudget.UseVisualStyleBackColor = false;
            this.btnCalcBudget.Click += new System.EventHandler(this.btnCalcBudget_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 29);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Budget";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(3, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 17);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Calculate_Spare_Money.Properties.Resources.Black_Matte_Vinyl_Wraps;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(345, 323);
            this.Controls.Add(this.btnShowHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalcBudget);
            this.Controls.Add(this.btnAddBill);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(345, 323);
            this.MinimumSize = new System.Drawing.Size(345, 323);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnShowHistory;
        private System.Windows.Forms.Button btnCalcBudget;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
    }
}