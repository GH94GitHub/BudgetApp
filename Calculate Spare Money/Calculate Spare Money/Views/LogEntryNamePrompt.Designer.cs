namespace Calculate_Spare_Money.Views
{
    partial class FrmAddToLog
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtTransactionName = new System.Windows.Forms.TextBox();
            this.lblForDates = new System.Windows.Forms.Label();
            this.btnLogIt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 29);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(172, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 25);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Add to log";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
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
            // txtTransactionName
            // 
            this.txtTransactionName.Location = new System.Drawing.Point(155, 86);
            this.txtTransactionName.Name = "txtTransactionName";
            this.txtTransactionName.Size = new System.Drawing.Size(182, 20);
            this.txtTransactionName.TabIndex = 2;
            // 
            // lblForDates
            // 
            this.lblForDates.AutoSize = true;
            this.lblForDates.BackColor = System.Drawing.Color.Transparent;
            this.lblForDates.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForDates.ForeColor = System.Drawing.SystemColors.Control;
            this.lblForDates.Location = new System.Drawing.Point(152, 65);
            this.lblForDates.Name = "lblForDates";
            this.lblForDates.Size = new System.Drawing.Size(192, 18);
            this.lblForDates.TabIndex = 10;
            this.lblForDates.Text = "Name of the transaction:";
            // 
            // btnLogIt
            // 
            this.btnLogIt.BackColor = System.Drawing.Color.Silver;
            this.btnLogIt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIt.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIt.ForeColor = System.Drawing.Color.Black;
            this.btnLogIt.Location = new System.Drawing.Point(200, 112);
            this.btnLogIt.Name = "btnLogIt";
            this.btnLogIt.Size = new System.Drawing.Size(87, 32);
            this.btnLogIt.TabIndex = 11;
            this.btnLogIt.TabStop = false;
            this.btnLogIt.Text = "Log It";
            this.btnLogIt.UseVisualStyleBackColor = false;
            // 
            // FrmAddToLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculate_Spare_Money.Properties.Resources.MatteBlackSteel_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 190);
            this.Controls.Add(this.btnLogIt);
            this.Controls.Add(this.lblForDates);
            this.Controls.Add(this.txtTransactionName);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddToLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddToLog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtTransactionName;
        private System.Windows.Forms.Label lblForDates;
        private System.Windows.Forms.Button btnLogIt;
    }
}