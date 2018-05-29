namespace B137591 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.byteEditor = new DXSample.RepositoryItemMyTextEdit();
            this.shortEdit = new DXSample.RepositoryItemMyTextEdit();
            this.integerEdit = new DXSample.RepositoryItemMyTextEdit();
            this.longEdit = new DXSample.RepositoryItemMyTextEdit();
            this.myTextEdit1 = new DXSample.MyTextEdit();
            this.myTextEdit2 = new DXSample.MyTextEdit();
            this.myTextEdit3 = new DXSample.MyTextEdit();
            this.myTextEdit4 = new DXSample.MyTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.colByteColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIntegerColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLongColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.byteEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit4.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Table1";
            this.gridControl1.DataSource = this.dataSet1;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(24, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.byteEditor,
            this.shortEdit,
            this.integerEdit,
            this.longEdit});
            this.gridControl1.Size = new System.Drawing.Size(473, 216);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "ByteColumn";
            this.dataColumn1.DataType = typeof(byte);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "ShortColumn";
            this.dataColumn2.DataType = typeof(short);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "IntegerColumn";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "LongColumn";
            this.dataColumn4.DataType = typeof(long);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colByteColumn,
            this.colShortColumn,
            this.colIntegerColumn,
            this.colLongColumn});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // byteEditor
            // 
            this.byteEditor.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.byteEditor.AutoHeight = false;
            this.byteEditor.Mask.EditMask = "n0";
            this.byteEditor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.byteEditor.Name = "byteEditor";
            this.byteEditor.ValueType = DXSample.AllowedValueTypes.Byte;
            // 
            // shortEdit
            // 
            this.shortEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.shortEdit.AutoHeight = false;
            this.shortEdit.Mask.EditMask = "n0";
            this.shortEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.shortEdit.Name = "shortEdit";
            this.shortEdit.ValueType = DXSample.AllowedValueTypes.Int16;
            // 
            // integerEdit
            // 
            this.integerEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.integerEdit.AutoHeight = false;
            this.integerEdit.Mask.EditMask = "n0";
            this.integerEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.integerEdit.Name = "integerEdit";
            // 
            // longEdit
            // 
            this.longEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.longEdit.AutoHeight = false;
            this.longEdit.Mask.EditMask = "n0";
            this.longEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.longEdit.Name = "longEdit";
            this.longEdit.ValueType = DXSample.AllowedValueTypes.Int64;
            // 
            // myTextEdit1
            // 
            this.myTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataSet1, "Table1.ByteColumn", true));
            this.myTextEdit1.EditValue = ((byte)(0));
            this.myTextEdit1.Location = new System.Drawing.Point(81, 250);
            this.myTextEdit1.Name = "myTextEdit1";
            this.myTextEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.myTextEdit1.Properties.Mask.EditMask = "n0";
            this.myTextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.myTextEdit1.Properties.ValueType = DXSample.AllowedValueTypes.Byte;
            this.myTextEdit1.Size = new System.Drawing.Size(100, 20);
            this.myTextEdit1.TabIndex = 1;
            // 
            // myTextEdit2
            // 
            this.myTextEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataSet1, "Table1.IntegerColumn", true));
            this.myTextEdit2.EditValue = 0;
            this.myTextEdit2.Location = new System.Drawing.Point(81, 297);
            this.myTextEdit2.Name = "myTextEdit2";
            this.myTextEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.myTextEdit2.Properties.Mask.EditMask = "n0";
            this.myTextEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.myTextEdit2.Size = new System.Drawing.Size(100, 20);
            this.myTextEdit2.TabIndex = 2;
            // 
            // myTextEdit3
            // 
            this.myTextEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataSet1, "Table1.ShortColumn", true));
            this.myTextEdit3.EditValue = ((short)(0));
            this.myTextEdit3.Location = new System.Drawing.Point(256, 250);
            this.myTextEdit3.Name = "myTextEdit3";
            this.myTextEdit3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.myTextEdit3.Properties.Mask.EditMask = "n0";
            this.myTextEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.myTextEdit3.Properties.ValueType = DXSample.AllowedValueTypes.Int16;
            this.myTextEdit3.Size = new System.Drawing.Size(100, 20);
            this.myTextEdit3.TabIndex = 3;
            // 
            // myTextEdit4
            // 
            this.myTextEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataSet1, "Table1.LongColumn", true));
            this.myTextEdit4.EditValue = ((long)(0));
            this.myTextEdit4.Location = new System.Drawing.Point(256, 297);
            this.myTextEdit4.Name = "myTextEdit4";
            this.myTextEdit4.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.myTextEdit4.Properties.Mask.EditMask = "n0";
            this.myTextEdit4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.myTextEdit4.Properties.ValueType = DXSample.AllowedValueTypes.Int64;
            this.myTextEdit4.Size = new System.Drawing.Size(100, 20);
            this.myTextEdit4.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 253);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Byte";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(187, 253);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Int16";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 300);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Int32";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(187, 300);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Int64";
            // 
            // colByteColumn
            // 
            this.colByteColumn.Caption = "ByteColumn";
            this.colByteColumn.ColumnEdit = this.byteEditor;
            this.colByteColumn.FieldName = "ByteColumn";
            this.colByteColumn.Name = "colByteColumn";
            this.colByteColumn.Visible = true;
            this.colByteColumn.VisibleIndex = 0;
            // 
            // colShortColumn
            // 
            this.colShortColumn.Caption = "ShortColumn";
            this.colShortColumn.ColumnEdit = this.shortEdit;
            this.colShortColumn.FieldName = "ShortColumn";
            this.colShortColumn.Name = "colShortColumn";
            this.colShortColumn.Visible = true;
            this.colShortColumn.VisibleIndex = 1;
            // 
            // colIntegerColumn
            // 
            this.colIntegerColumn.Caption = "IntegerColumn";
            this.colIntegerColumn.ColumnEdit = this.integerEdit;
            this.colIntegerColumn.FieldName = "IntegerColumn";
            this.colIntegerColumn.Name = "colIntegerColumn";
            this.colIntegerColumn.Visible = true;
            this.colIntegerColumn.VisibleIndex = 2;
            // 
            // colLongColumn
            // 
            this.colLongColumn.Caption = "LongColumn";
            this.colLongColumn.ColumnEdit = this.longEdit;
            this.colLongColumn.FieldName = "LongColumn";
            this.colLongColumn.Name = "colLongColumn";
            this.colLongColumn.Visible = true;
            this.colLongColumn.VisibleIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 342);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.myTextEdit4);
            this.Controls.Add(this.myTextEdit3);
            this.Controls.Add(this.myTextEdit2);
            this.Controls.Add(this.myTextEdit1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.byteEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit4.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DXSample.MyTextEdit myTextEdit1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private DXSample.RepositoryItemMyTextEdit byteEditor;
        private DXSample.RepositoryItemMyTextEdit shortEdit;
        private DXSample.RepositoryItemMyTextEdit integerEdit;
        private DXSample.RepositoryItemMyTextEdit longEdit;
        private DXSample.MyTextEdit myTextEdit2;
        private DXSample.MyTextEdit myTextEdit3;
        private DXSample.MyTextEdit myTextEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn colByteColumn;
        private DevExpress.XtraGrid.Columns.GridColumn colShortColumn;
        private DevExpress.XtraGrid.Columns.GridColumn colIntegerColumn;
        private DevExpress.XtraGrid.Columns.GridColumn colLongColumn;

    }
}