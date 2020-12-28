
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
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(117, 9);
            this.txtDescription.MaxLength = 1024;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(227, 146);
            this.txtDescription.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(8, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(99, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "İş açıklaması";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::MusteriTakip.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(251, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtChargeAmount
            // 
            this.txtChargeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChargeAmount.Location = new System.Drawing.Point(117, 161);
            this.txtChargeAmount.MaxLength = 7;
            this.txtChargeAmount.Name = "txtChargeAmount";
            this.txtChargeAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtChargeAmount.Size = new System.Drawing.Size(69, 26);
            this.txtChargeAmount.TabIndex = 3;
            this.txtChargeAmount.Text = "0";
            this.txtChargeAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChargeAmount_KeyPress);
            // 
            // lblChargeAmount
            // 
            this.lblChargeAmount.AutoSize = true;
            this.lblChargeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargeAmount.Location = new System.Drawing.Point(59, 161);
            this.lblChargeAmount.Name = "lblChargeAmount";
            this.lblChargeAmount.Size = new System.Drawing.Size(48, 20);
            this.lblChargeAmount.TabIndex = 4;
            this.lblChargeAmount.Text = "Ücret";
            // 
            // AddNewOperationForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 214);
            this.Controls.Add(this.lblChargeAmount);
            this.Controls.Add(this.txtChargeAmount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.MaximizeBox = false;
            this.Name = "AddNewOperationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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