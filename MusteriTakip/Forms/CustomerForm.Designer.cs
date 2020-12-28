
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.operationsDataGridView = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteOperation = new System.Windows.Forms.Button();
            this.btnAddOperation = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(12, 159);
            this.txtNotes.MaxLength = 1024;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(270, 234);
            this.txtNotes.TabIndex = 3;
            this.txtNotes.TextChanged += new System.EventHandler(this.textChanged);
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
            this.operationsDataGridView.Location = new System.Drawing.Point(288, 102);
            this.operationsDataGridView.MultiSelect = false;
            this.operationsDataGridView.Name = "operationsDataGridView";
            this.operationsDataGridView.ReadOnly = true;
            this.operationsDataGridView.RowHeadersVisible = false;
            this.operationsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.operationsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.operationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.operationsDataGridView.Size = new System.Drawing.Size(715, 346);
            this.operationsDataGridView.TabIndex = 4;
            this.operationsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.operationsDataGridView_CellDoubleClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 76);
            this.txtName.MaxLength = 256;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TabStop = false;
            this.txtName.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(59, 102);
            this.txtCompany.MaxLength = 256;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(223, 20);
            this.txtCompany.TabIndex = 2;
            this.txtCompany.TabStop = false;
            this.txtCompany.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(8, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "İsim";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(8, 102);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(49, 20);
            this.lblCompany.TabIndex = 6;
            this.lblCompany.Text = "Firma";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(8, 136);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 20);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Notlar";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreated.Location = new System.Drawing.Point(687, 462);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(193, 20);
            this.lblDateCreated.TabIndex = 8;
            this.lblDateCreated.Text = "Müşteri oluşturulma tarihi: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(363, 74);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(73, 20);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Açıklama";
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.Location = new System.Drawing.Point(626, 74);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(48, 20);
            this.lblCharge.TabIndex = 12;
            this.lblCharge.Text = "Ücret";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(867, 74);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Tarih";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::MusteriTakip.Properties.Resources.back;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(2);
            this.btnBack.Size = new System.Drawing.Size(90, 47);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Geri";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteOperation
            // 
            this.btnDeleteOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOperation.Image = global::MusteriTakip.Properties.Resources.negative;
            this.btnDeleteOperation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteOperation.Location = new System.Drawing.Point(814, 12);
            this.btnDeleteOperation.Name = "btnDeleteOperation";
            this.btnDeleteOperation.Padding = new System.Windows.Forms.Padding(2);
            this.btnDeleteOperation.Size = new System.Drawing.Size(83, 47);
            this.btnDeleteOperation.TabIndex = 6;
            this.btnDeleteOperation.TabStop = false;
            this.btnDeleteOperation.Text = "İşi sil";
            this.btnDeleteOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteOperation.UseVisualStyleBackColor = true;
            this.btnDeleteOperation.Click += new System.EventHandler(this.btnDeleteOperation_Click);
            // 
            // btnAddOperation
            // 
            this.btnAddOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOperation.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOperation.Image")));
            this.btnAddOperation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOperation.Location = new System.Drawing.Point(903, 12);
            this.btnAddOperation.Name = "btnAddOperation";
            this.btnAddOperation.Padding = new System.Windows.Forms.Padding(2);
            this.btnAddOperation.Size = new System.Drawing.Size(100, 47);
            this.btnAddOperation.TabIndex = 10;
            this.btnAddOperation.TabStop = false;
            this.btnAddOperation.Text = "İş Ekle";
            this.btnAddOperation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddOperation.UseVisualStyleBackColor = true;
            this.btnAddOperation.Click += new System.EventHandler(this.btnAddOperation_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Image = global::MusteriTakip.Properties.Resources.remove;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(12, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(2);
            this.btnDelete.Size = new System.Drawing.Size(129, 49);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Müşteriyi Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Image = global::MusteriTakip.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(186, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(2);
            this.btnSave.Size = new System.Drawing.Size(96, 49);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1015, 491);
            this.Controls.Add(this.btnBack);
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
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Müşteri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.Move += new System.EventHandler(this.CustomerForm_Move);
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
        private System.Windows.Forms.Button btnBack;
    }
}