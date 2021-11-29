
namespace frmCentralTelefonica
{
    partial class FrmMostrar
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
            this.rtbDatosCentralita = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbDatosCentralita
            // 
            this.rtbDatosCentralita.Location = new System.Drawing.Point(12, 12);
            this.rtbDatosCentralita.Name = "rtbDatosCentralita";
            this.rtbDatosCentralita.Size = new System.Drawing.Size(392, 218);
            this.rtbDatosCentralita.TabIndex = 0;
            this.rtbDatosCentralita.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 242);
            this.Controls.Add(this.rtbDatosCentralita);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDatosCentralita;
    }
}