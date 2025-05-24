
namespace Janelastone
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ростDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.весDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.талияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.шеяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бедерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.окружностьЗапясьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.предплечьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.икрыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.проектDataSet1 = new Janelastone.ПроектDataSet1();
            this.клиентTableAdapter = new Janelastone.ПроектDataSet1TableAdapters.КлиентTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.проектDataSet6 = new Janelastone.ПроектDataSet6();
            this.иМТИТдКлиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.иМТ_и_тд_клиентаTableAdapter = new Janelastone.ПроектDataSet6TableAdapters.ИМТ_и_тд_клиентаTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иМТDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.талияРостDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процентЖираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скуднаяМассаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.советыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иМТИТдКлиентаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.ростDataGridViewTextBoxColumn,
            this.весDataGridViewTextBoxColumn,
            this.талияDataGridViewTextBoxColumn,
            this.шеяDataGridViewTextBoxColumn,
            this.бедерDataGridViewTextBoxColumn,
            this.окружностьЗапясьяDataGridViewTextBoxColumn,
            this.предплечьяDataGridViewTextBoxColumn,
            this.икрыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1721, 151);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяDataGridViewTextBoxColumn.Width = 150;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            this.фамилияDataGridViewTextBoxColumn.Width = 150;
            // 
            // ростDataGridViewTextBoxColumn
            // 
            this.ростDataGridViewTextBoxColumn.DataPropertyName = "Рост";
            this.ростDataGridViewTextBoxColumn.HeaderText = "Рост";
            this.ростDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ростDataGridViewTextBoxColumn.Name = "ростDataGridViewTextBoxColumn";
            this.ростDataGridViewTextBoxColumn.ReadOnly = true;
            this.ростDataGridViewTextBoxColumn.Width = 150;
            // 
            // весDataGridViewTextBoxColumn
            // 
            this.весDataGridViewTextBoxColumn.DataPropertyName = "Вес";
            this.весDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.весDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.весDataGridViewTextBoxColumn.Name = "весDataGridViewTextBoxColumn";
            this.весDataGridViewTextBoxColumn.ReadOnly = true;
            this.весDataGridViewTextBoxColumn.Width = 150;
            // 
            // талияDataGridViewTextBoxColumn
            // 
            this.талияDataGridViewTextBoxColumn.DataPropertyName = "Талия";
            this.талияDataGridViewTextBoxColumn.HeaderText = "Талия";
            this.талияDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.талияDataGridViewTextBoxColumn.Name = "талияDataGridViewTextBoxColumn";
            this.талияDataGridViewTextBoxColumn.ReadOnly = true;
            this.талияDataGridViewTextBoxColumn.Width = 150;
            // 
            // шеяDataGridViewTextBoxColumn
            // 
            this.шеяDataGridViewTextBoxColumn.DataPropertyName = "Шея";
            this.шеяDataGridViewTextBoxColumn.HeaderText = "Шея";
            this.шеяDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.шеяDataGridViewTextBoxColumn.Name = "шеяDataGridViewTextBoxColumn";
            this.шеяDataGridViewTextBoxColumn.ReadOnly = true;
            this.шеяDataGridViewTextBoxColumn.Width = 150;
            // 
            // бедерDataGridViewTextBoxColumn
            // 
            this.бедерDataGridViewTextBoxColumn.DataPropertyName = "Бедер";
            this.бедерDataGridViewTextBoxColumn.HeaderText = "Бедер";
            this.бедерDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.бедерDataGridViewTextBoxColumn.Name = "бедерDataGridViewTextBoxColumn";
            this.бедерDataGridViewTextBoxColumn.ReadOnly = true;
            this.бедерDataGridViewTextBoxColumn.Width = 150;
            // 
            // окружностьЗапясьяDataGridViewTextBoxColumn
            // 
            this.окружностьЗапясьяDataGridViewTextBoxColumn.DataPropertyName = "Окружность запясья";
            this.окружностьЗапясьяDataGridViewTextBoxColumn.HeaderText = "Окружность запясья";
            this.окружностьЗапясьяDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.окружностьЗапясьяDataGridViewTextBoxColumn.Name = "окружностьЗапясьяDataGridViewTextBoxColumn";
            this.окружностьЗапясьяDataGridViewTextBoxColumn.ReadOnly = true;
            this.окружностьЗапясьяDataGridViewTextBoxColumn.Width = 150;
            // 
            // предплечьяDataGridViewTextBoxColumn
            // 
            this.предплечьяDataGridViewTextBoxColumn.DataPropertyName = "Предплечья";
            this.предплечьяDataGridViewTextBoxColumn.HeaderText = "Предплечья";
            this.предплечьяDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.предплечьяDataGridViewTextBoxColumn.Name = "предплечьяDataGridViewTextBoxColumn";
            this.предплечьяDataGridViewTextBoxColumn.ReadOnly = true;
            this.предплечьяDataGridViewTextBoxColumn.Width = 150;
            // 
            // икрыDataGridViewTextBoxColumn
            // 
            this.икрыDataGridViewTextBoxColumn.DataPropertyName = "Икры";
            this.икрыDataGridViewTextBoxColumn.HeaderText = "Икры";
            this.икрыDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.икрыDataGridViewTextBoxColumn.Name = "икрыDataGridViewTextBoxColumn";
            this.икрыDataGridViewTextBoxColumn.ReadOnly = true;
            this.икрыDataGridViewTextBoxColumn.Width = 150;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.проектDataSet1;
            // 
            // проектDataSet1
            // 
            this.проектDataSet1.DataSetName = "ПроектDataSet1";
            this.проектDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.имяКлиентаDataGridViewTextBoxColumn,
            this.фамилияКлиентаDataGridViewTextBoxColumn,
            this.иМТDataGridViewTextBoxColumn,
            this.талияРостDataGridViewTextBoxColumn,
            this.процентЖираDataGridViewTextBoxColumn,
            this.скуднаяМассаDataGridViewTextBoxColumn,
            this.советыDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.иМТИТдКлиентаBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(30, 318);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1458, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // проектDataSet6
            // 
            this.проектDataSet6.DataSetName = "ПроектDataSet6";
            this.проектDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // иМТИТдКлиентаBindingSource
            // 
            this.иМТИТдКлиентаBindingSource.DataMember = "ИМТ и тд клиента";
            this.иМТИТдКлиентаBindingSource.DataSource = this.проектDataSet6;
            // 
            // иМТ_и_тд_клиентаTableAdapter
            // 
            this.иМТ_и_тд_клиентаTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 150;
            // 
            // имяКлиентаDataGridViewTextBoxColumn
            // 
            this.имяКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Имя клиента";
            this.имяКлиентаDataGridViewTextBoxColumn.HeaderText = "Имя клиента";
            this.имяКлиентаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.имяКлиентаDataGridViewTextBoxColumn.Name = "имяКлиентаDataGridViewTextBoxColumn";
            this.имяКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.имяКлиентаDataGridViewTextBoxColumn.Width = 150;
            // 
            // фамилияКлиентаDataGridViewTextBoxColumn
            // 
            this.фамилияКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия клиента";
            this.фамилияКлиентаDataGridViewTextBoxColumn.HeaderText = "Фамилия клиента";
            this.фамилияКлиентаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фамилияКлиентаDataGridViewTextBoxColumn.Name = "фамилияКлиентаDataGridViewTextBoxColumn";
            this.фамилияКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фамилияКлиентаDataGridViewTextBoxColumn.Width = 150;
            // 
            // иМТDataGridViewTextBoxColumn
            // 
            this.иМТDataGridViewTextBoxColumn.DataPropertyName = "ИМТ";
            this.иМТDataGridViewTextBoxColumn.HeaderText = "ИМТ";
            this.иМТDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.иМТDataGridViewTextBoxColumn.Name = "иМТDataGridViewTextBoxColumn";
            this.иМТDataGridViewTextBoxColumn.ReadOnly = true;
            this.иМТDataGridViewTextBoxColumn.Width = 150;
            // 
            // талияРостDataGridViewTextBoxColumn
            // 
            this.талияРостDataGridViewTextBoxColumn.DataPropertyName = "Талия\\Рост";
            this.талияРостDataGridViewTextBoxColumn.HeaderText = "Талия\\Рост";
            this.талияРостDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.талияРостDataGridViewTextBoxColumn.Name = "талияРостDataGridViewTextBoxColumn";
            this.талияРостDataGridViewTextBoxColumn.ReadOnly = true;
            this.талияРостDataGridViewTextBoxColumn.Width = 150;
            // 
            // процентЖираDataGridViewTextBoxColumn
            // 
            this.процентЖираDataGridViewTextBoxColumn.DataPropertyName = "Процент жира";
            this.процентЖираDataGridViewTextBoxColumn.HeaderText = "Процент жира";
            this.процентЖираDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.процентЖираDataGridViewTextBoxColumn.Name = "процентЖираDataGridViewTextBoxColumn";
            this.процентЖираDataGridViewTextBoxColumn.ReadOnly = true;
            this.процентЖираDataGridViewTextBoxColumn.Width = 150;
            // 
            // скуднаяМассаDataGridViewTextBoxColumn
            // 
            this.скуднаяМассаDataGridViewTextBoxColumn.DataPropertyName = "Скудная масса";
            this.скуднаяМассаDataGridViewTextBoxColumn.HeaderText = "Скудная масса";
            this.скуднаяМассаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.скуднаяМассаDataGridViewTextBoxColumn.Name = "скуднаяМассаDataGridViewTextBoxColumn";
            this.скуднаяМассаDataGridViewTextBoxColumn.ReadOnly = true;
            this.скуднаяМассаDataGridViewTextBoxColumn.Width = 150;
            // 
            // советыDataGridViewTextBoxColumn
            // 
            this.советыDataGridViewTextBoxColumn.DataPropertyName = "Советы";
            this.советыDataGridViewTextBoxColumn.HeaderText = "Советы";
            this.советыDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.советыDataGridViewTextBoxColumn.Name = "советыDataGridViewTextBoxColumn";
            this.советыDataGridViewTextBoxColumn.ReadOnly = true;
            this.советыDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 606);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иМТИТдКлиентаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ростDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn весDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn талияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn шеяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бедерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn окружностьЗапясьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn предплечьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn икрыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public ПроектDataSet1 проектDataSet1;
        public System.Windows.Forms.BindingSource клиентBindingSource;
        public ПроектDataSet1TableAdapters.КлиентTableAdapter клиентTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иМТDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn талияРостDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процентЖираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скуднаяМассаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn советыDataGridViewTextBoxColumn;
        public ПроектDataSet6 проектDataSet6;
        public System.Windows.Forms.BindingSource иМТИТдКлиентаBindingSource;
        public ПроектDataSet6TableAdapters.ИМТ_и_тд_клиентаTableAdapter иМТ_и_тд_клиентаTableAdapter;
    }
}