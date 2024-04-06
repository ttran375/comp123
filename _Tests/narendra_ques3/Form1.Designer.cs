
namespace narendra_ques3
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnShowHeros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.chkIsGood = new System.Windows.Forms.CheckBox();
            this.cboPowers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(15, 133);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(96, 133);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnShowHeros
            // 
            this.btnShowHeros.Location = new System.Drawing.Point(177, 133);
            this.btnShowHeros.Name = "btnShowHeros";
            this.btnShowHeros.Size = new System.Drawing.Size(75, 23);
            this.btnShowHeros.TabIndex = 2;
            this.btnShowHeros.Text = "Show Heros";
            this.btnShowHeros.UseVisualStyleBackColor = true;
            this.btnShowHeros.Click += new System.EventHandler(this.btnShowHeros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age (yrs)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Powers";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(85, 34);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(167, 20);
            this.txtAge.TabIndex = 7;
            // 
            // chkIsGood
            // 
            this.chkIsGood.AutoSize = true;
            this.chkIsGood.Location = new System.Drawing.Point(85, 96);
            this.chkIsGood.Name = "chkIsGood";
            this.chkIsGood.Size = new System.Drawing.Size(63, 17);
            this.chkIsGood.TabIndex = 8;
            this.chkIsGood.Text = "Is Good";
            this.chkIsGood.UseVisualStyleBackColor = true;
            // 
            // cboPowers
            // 
            this.cboPowers.FormattingEnabled = true;
            this.cboPowers.Location = new System.Drawing.Point(85, 60);
            this.cboPowers.Name = "cboPowers";
            this.cboPowers.Size = new System.Drawing.Size(121, 21);
            this.cboPowers.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 164);
            this.Controls.Add(this.cboPowers);
            this.Controls.Add(this.chkIsGood);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowHeros);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btncancel);
            this.Name = "Form1";
            this.Text = "Super Hero Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnShowHeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.CheckBox chkIsGood;
        private System.Windows.Forms.ComboBox cboPowers;
    }
}

