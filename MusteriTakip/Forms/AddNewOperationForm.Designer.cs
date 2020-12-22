
namespace MusteriTakip.Forms
{
    partial class AddNewOperationForm
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtChargeAmount = new System.Windows.Forms.TextBox();
            this.lblChargeAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(88, 12);
            this.txtDescription.MaxLength = 1024;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(286, 146);
            this.txtDescription.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 12);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "İş açıklaması:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtChargeAmount
            // 
            this.txtChargeAmount.Location = new System.Drawing.Point(88, 172);
            this.txtChargeAmount.MaxLength = 7;
            this.txtChargeAmount.Name = "txtChargeAmount";
            this.txtChargeAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtChargeAmount.Size = new System.Drawing.Size(69, 20);
            this.txtChargeAmount.TabIndex = 3;
            this.txtChargeAmount.Text = "0";
            // 
            // lblChargeAmount
            // 
            this.lblChargeAmount.AutoSize = true;
            this.lblChargeAmount.Location = new System.Drawing.Point(46, 175);
            this.lblChargeAmount.Name = "lblChargeAmount";
            this.lblChargeAmount.Size = new System.Drawing.Size(36, 13);
            this.lblChargeAmount.TabIndex = 4;
            this.lblChargeAmount.Text = "Ücret:";
            // 
            // AddNewOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblChargeAmount);
            this.Controls.Add(this.txtChargeAmount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.MaximizeBox = false;
            this.Name = "AddNewOperationForm";
            this.ShowIcon = false;
            this.Text = "Yeni İş Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtChargeAmount;
        private System.Windows.Forms.Label lblChargeAmount;
    }
}