namespace LivreEventDelegate
{
    partial class FHISTORIQUE
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
            this.lbHistoriquePrix = new System.Windows.Forms.ListBox();
            this.tbPourcentage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHistoriquePrix
            // 
            this.lbHistoriquePrix.FormattingEnabled = true;
            this.lbHistoriquePrix.Location = new System.Drawing.Point(35, 75);
            this.lbHistoriquePrix.Name = "lbHistoriquePrix";
            this.lbHistoriquePrix.Size = new System.Drawing.Size(249, 251);
            this.lbHistoriquePrix.TabIndex = 1;
            // 
            // tbPourcentage
            // 
            this.tbPourcentage.Location = new System.Drawing.Point(116, 34);
            this.tbPourcentage.Name = "tbPourcentage";
            this.tbPourcentage.Size = new System.Drawing.Size(168, 20);
            this.tbPourcentage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pourcentage :";
            // 
            // FHISTORIQUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPourcentage);
            this.Controls.Add(this.lbHistoriquePrix);
            this.Name = "FHISTORIQUE";
            this.Text = "Historique des prix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbHistoriquePrix;
        private System.Windows.Forms.TextBox tbPourcentage;
        private System.Windows.Forms.Label label1;
    }
}