
namespace Drivers
{
    partial class License
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idlicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddriverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenceseriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licencenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofdriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driversDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLb
            // 
            this.nameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLb.Location = new System.Drawing.Point(330, 28);
            this.nameLb.Size = new System.Drawing.Size(137, 29);
            this.nameLb.Text = "Лицензия";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 12);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlicenseDataGridViewTextBoxColumn,
            this.iddriverDataGridViewTextBoxColumn,
            this.expiredateDataGridViewTextBoxColumn,
            this.categoriesDataGridViewTextBoxColumn,
            this.licenceseriesDataGridViewTextBoxColumn,
            this.licencenumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.vINDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.engineTypeDataGridViewTextBoxColumn,
            this.typeofdriveDataGridViewTextBoxColumn,
            this.driversDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.licencesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(92, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 249);
            this.dataGridView1.TabIndex = 7;
            // 
            // idlicenseDataGridViewTextBoxColumn
            // 
            this.idlicenseDataGridViewTextBoxColumn.DataPropertyName = "id_license";
            this.idlicenseDataGridViewTextBoxColumn.HeaderText = "id_license";
            this.idlicenseDataGridViewTextBoxColumn.Name = "idlicenseDataGridViewTextBoxColumn";
            // 
            // iddriverDataGridViewTextBoxColumn
            // 
            this.iddriverDataGridViewTextBoxColumn.DataPropertyName = "id_driver";
            this.iddriverDataGridViewTextBoxColumn.HeaderText = "id_driver";
            this.iddriverDataGridViewTextBoxColumn.Name = "iddriverDataGridViewTextBoxColumn";
            // 
            // expiredateDataGridViewTextBoxColumn
            // 
            this.expiredateDataGridViewTextBoxColumn.DataPropertyName = "expire_date";
            this.expiredateDataGridViewTextBoxColumn.HeaderText = "expire_date";
            this.expiredateDataGridViewTextBoxColumn.Name = "expiredateDataGridViewTextBoxColumn";
            // 
            // categoriesDataGridViewTextBoxColumn
            // 
            this.categoriesDataGridViewTextBoxColumn.DataPropertyName = "categories";
            this.categoriesDataGridViewTextBoxColumn.HeaderText = "categories";
            this.categoriesDataGridViewTextBoxColumn.Name = "categoriesDataGridViewTextBoxColumn";
            // 
            // licenceseriesDataGridViewTextBoxColumn
            // 
            this.licenceseriesDataGridViewTextBoxColumn.DataPropertyName = "licence_series";
            this.licenceseriesDataGridViewTextBoxColumn.HeaderText = "licence_series";
            this.licenceseriesDataGridViewTextBoxColumn.Name = "licenceseriesDataGridViewTextBoxColumn";
            // 
            // licencenumberDataGridViewTextBoxColumn
            // 
            this.licencenumberDataGridViewTextBoxColumn.DataPropertyName = "licence_number";
            this.licencenumberDataGridViewTextBoxColumn.HeaderText = "licence_number";
            this.licencenumberDataGridViewTextBoxColumn.Name = "licencenumberDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // vINDataGridViewTextBoxColumn
            // 
            this.vINDataGridViewTextBoxColumn.DataPropertyName = "VIN";
            this.vINDataGridViewTextBoxColumn.HeaderText = "VIN";
            this.vINDataGridViewTextBoxColumn.Name = "vINDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // engineTypeDataGridViewTextBoxColumn
            // 
            this.engineTypeDataGridViewTextBoxColumn.DataPropertyName = "Engine_Type";
            this.engineTypeDataGridViewTextBoxColumn.HeaderText = "Engine_Type";
            this.engineTypeDataGridViewTextBoxColumn.Name = "engineTypeDataGridViewTextBoxColumn";
            // 
            // typeofdriveDataGridViewTextBoxColumn
            // 
            this.typeofdriveDataGridViewTextBoxColumn.DataPropertyName = "type_of_drive";
            this.typeofdriveDataGridViewTextBoxColumn.HeaderText = "type_of_drive";
            this.typeofdriveDataGridViewTextBoxColumn.Name = "typeofdriveDataGridViewTextBoxColumn";
            // 
            // driversDataGridViewTextBoxColumn
            // 
            this.driversDataGridViewTextBoxColumn.DataPropertyName = "drivers";
            this.driversDataGridViewTextBoxColumn.HeaderText = "drivers";
            this.driversDataGridViewTextBoxColumn.Name = "driversDataGridViewTextBoxColumn";
            // 
            // licencesBindingSource
            // 
            this.licencesBindingSource.DataSource = typeof(Drivers.Licences);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.exitBtn.Location = new System.Drawing.Point(335, 379);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(91, 30);
            this.exitBtn.TabIndex = 40;
            this.exitBtn.Text = "Назад";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(762, 439);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "License";
            this.Text = "Лицензия";
            this.Load += new System.EventHandler(this.License_Load);
            this.Controls.SetChildIndex(this.nameLb, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.exitBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddriverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenceseriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licencenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofdriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driversDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource licencesBindingSource;
        private System.Windows.Forms.Button exitBtn;
    }
}
