
namespace narendra_ques3
{
    partial class FrmHeros
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
            this.dgvHeros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHeros
            // 
            this.dgvHeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHeros.Location = new System.Drawing.Point(0, 0);
            this.dgvHeros.Name = "dgvHeros";
            this.dgvHeros.Size = new System.Drawing.Size(507, 346);
            this.dgvHeros.TabIndex = 0;
            // 
            // FrmHeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 346);
            this.Controls.Add(this.dgvHeros);
            this.Name = "FrmHeros";
            this.Text = "FrmHeros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHeros;
    }
}