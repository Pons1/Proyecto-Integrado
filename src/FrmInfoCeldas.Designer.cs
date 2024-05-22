namespace PROYECTO
{
    partial class FrmInfoCeldas
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
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblNif1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(194, 57);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(44, 16);
            this.lblNombre1.TabIndex = 0;
            this.lblNombre1.Text = "label1";
            // 
            // lblNif1
            // 
            this.lblNif1.AutoSize = true;
            this.lblNif1.Location = new System.Drawing.Point(194, 125);
            this.lblNif1.Name = "lblNif1";
            this.lblNif1.Size = new System.Drawing.Size(44, 16);
            this.lblNif1.TabIndex = 1;
            this.lblNif1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(194, 159);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(44, 16);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "label1";
            // 
            // FrmInfoCeldas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNif1);
            this.Controls.Add(this.lblNombre1);
            this.Name = "FrmInfoCeldas";
            this.Text = "FrmInfoCeldas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblNif1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
    }
}