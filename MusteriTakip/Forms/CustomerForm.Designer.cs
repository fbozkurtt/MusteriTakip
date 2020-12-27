
namespace MusteriTakip.Forms
{
    partial class CustomerForm
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
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.operationsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddOperation = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDeleteOperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(15, 140);
            this.txtNotes.MaxLength = 1024;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(270, 234);
            this.txtNotes.TabIndex = 1;
            // 
            // operationsDataGridView
            // 
            this.operationsDataGridView.AllowUserToAddRows = false;
            this.operationsDataGridView.AllowUserToDeleteRows = false;
            this.operationsDataGridView.AllowUserToResizeColumns = false;
            this.operationsDataGridView.AllowUserToResizeRows = false;
            this.operationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.operationsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.operationsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.operationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationsDataGridView.ColumnHeadersVisible = false;
            this.operationsDataGridView.Location = new System.Drawing.Point(288, 72);
            this.operationsDataGridView.MultiSelect = false;
            this.operationsDataGridView.Name = "operationsDataGridView";
            this.operationsDataGridView.ReadOnly = true;
            this.operationsDataGridView.RowHeadersVisible = false;
            this.operationsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.operationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.operationsDataGridView.Size = new System.Drawing.Size(715, 334);
            this.operationsDataGridView.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(202, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 26);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 46);
            this.txtName.MaxLength = 256;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TabStop = false;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(59, 72);
            this.txtCompany.MaxLength = 256;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(223, 20);
            this.txtCompany.TabIndex = 1;
            this.txtCompany.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(25, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "İsim";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(12, 75);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(32, 13);
            this.lblCompany.TabIndex = 6;
            this.lblCompany.Text = "Firma";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 124);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Notlar";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(103, 95);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(91, 13);
            this.lblDateCreated.TabIndex = 8;
            this.lblDateCreated.Text = "oluşturulma tarihi: ";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(604, 412);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Müşteriyi Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.Location = new System.Drawing.Point(928, 412);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Size = new System.Drawing.Size(75, 23);
            this.btnAddOperation.TabIndex = 10;
            this.btnAddOperation.Text = "İş Ekle";
            this.btnAddOperation.UseVisualStyleBackColor = true;
            this.btnAddOperation.Click += new System.EventHandler(this.btnAddOperation_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(364, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(50, 13);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Açıklama";
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Location = new System.Drawing.Point(626, 56);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(33, 13);
            this.lblCharge.TabIndex = 12;
            this.lblCharge.Text = "Ücret";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(860, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 13);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Tarih";
            // 
            // btnDeleteOperation
            // 
            this.btnDeleteOperation.Location = new System.Drawing.Point(847, 412);
            this.btnDeleteOperation.Name = "btnDeleteOperation";
            this.btnDeleteOperation.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOperation.TabIndex = 14;
            this.btnDeleteOperation.Text = "İşi sil";
            this.btnDeleteOperation.UseVisualStyleBackColor = true;
            this.btnDeleteOperation.Click += new System.EventHandler(this.btnDeleteOperation_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 447);
            this.Controls.Add(this.btnDeleteOperation);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnAddOperation);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.operationsDataGridView);
            this.Controls.Add(this.txtNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomerForm";
            this.ShowIcon = false;
            this.Text = "Müşteri";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DataGridView operationsDataGridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddOperation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnDeleteOperation;
    }
}