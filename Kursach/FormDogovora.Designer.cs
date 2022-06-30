
namespace Kursach
{
    partial class FormDogovora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDogovora));
            this.kursachDataSet = new Kursach.kursachDataSet();
            this.договораBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договораTableAdapter = new Kursach.kursachDataSetTableAdapters.ДоговораTableAdapter();
            this.tableAdapterManager = new Kursach.kursachDataSetTableAdapters.TableAdapterManager();
            this.договораBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.договораBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.договораDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingNavigator)).BeginInit();
            this.договораBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.договораDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kursachDataSet
            // 
            this.kursachDataSet.DataSetName = "kursachDataSet";
            this.kursachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договораBindingSource
            // 
            this.договораBindingSource.DataMember = "Договора";
            this.договораBindingSource.DataSource = this.kursachDataSet;
            // 
            // договораTableAdapter
            // 
            this.договораTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Kursach.kursachDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДоговораTableAdapter = this.договораTableAdapter;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // договораBindingNavigator
            // 
            this.договораBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.договораBindingNavigator.BindingSource = this.договораBindingSource;
            this.договораBindingNavigator.CountItem = null;
            this.договораBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.договораBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.договораBindingNavigatorSaveItem});
            this.договораBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.договораBindingNavigator.MoveFirstItem = null;
            this.договораBindingNavigator.MoveLastItem = null;
            this.договораBindingNavigator.MoveNextItem = null;
            this.договораBindingNavigator.MovePreviousItem = null;
            this.договораBindingNavigator.Name = "договораBindingNavigator";
            this.договораBindingNavigator.PositionItem = null;
            this.договораBindingNavigator.Size = new System.Drawing.Size(403, 25);
            this.договораBindingNavigator.TabIndex = 0;
            this.договораBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // договораBindingNavigatorSaveItem
            // 
            this.договораBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.договораBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("договораBindingNavigatorSaveItem.Image")));
            this.договораBindingNavigatorSaveItem.Name = "договораBindingNavigatorSaveItem";
            this.договораBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.договораBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.договораBindingNavigatorSaveItem.Click += new System.EventHandler(this.договораBindingNavigatorSaveItem_Click);
            // 
            // договораDataGridView
            // 
            this.договораDataGridView.AutoGenerateColumns = false;
            this.договораDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.договораDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.договораDataGridView.DataSource = this.договораBindingSource;
            this.договораDataGridView.Location = new System.Drawing.Point(0, 28);
            this.договораDataGridView.Name = "договораDataGridView";
            this.договораDataGridView.Size = new System.Drawing.Size(404, 424);
            this.договораDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Договора";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Договора";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ДатаДоговора";
            this.dataGridViewTextBoxColumn2.HeaderText = "ДатаДоговора";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Клиента";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Клиента";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Форма заказа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.zakaz_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Форма клиента ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clients_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Форма сотрудника";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.sotrudnic_Click);
            // 
            // FormDogovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.договораDataGridView);
            this.Controls.Add(this.договораBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDogovora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма договора";
            this.Load += new System.EventHandler(this.FormDogovora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingNavigator)).EndInit();
            this.договораBindingNavigator.ResumeLayout(false);
            this.договораBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.договораDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kursachDataSet kursachDataSet;
        private System.Windows.Forms.BindingSource договораBindingSource;
        private kursachDataSetTableAdapters.ДоговораTableAdapter договораTableAdapter;
        private kursachDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator договораBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton договораBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView договораDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}