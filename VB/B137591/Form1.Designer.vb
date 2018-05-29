Imports Microsoft.VisualBasic
Imports System
Namespace B137591
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.dataColumn4 = New System.Data.DataColumn()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.byteEditor = New DXSample.RepositoryItemMyTextEdit()
			Me.shortEdit = New DXSample.RepositoryItemMyTextEdit()
			Me.integerEdit = New DXSample.RepositoryItemMyTextEdit()
			Me.longEdit = New DXSample.RepositoryItemMyTextEdit()
			Me.myTextEdit1 = New DXSample.MyTextEdit()
			Me.myTextEdit2 = New DXSample.MyTextEdit()
			Me.myTextEdit3 = New DXSample.MyTextEdit()
			Me.myTextEdit4 = New DXSample.MyTextEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.colByteColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShortColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colIntegerColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLongColumn = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.byteEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.shortEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.integerEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.longEdit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myTextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myTextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myTextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataMember = "Table1"
			Me.gridControl1.DataSource = Me.dataSet1
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(24, 12)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.byteEditor, Me.shortEdit, Me.integerEdit, Me.longEdit})
			Me.gridControl1.Size = New System.Drawing.Size(473, 216)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "ByteColumn"
			Me.dataColumn1.DataType = GetType(Byte)
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "ShortColumn"
			Me.dataColumn2.DataType = GetType(Short)
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "IntegerColumn"
			Me.dataColumn3.DataType = GetType(Integer)
			' 
			' dataColumn4
			' 
			Me.dataColumn4.ColumnName = "LongColumn"
			Me.dataColumn4.DataType = GetType(Long)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colByteColumn, Me.colShortColumn, Me.colIntegerColumn, Me.colLongColumn})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' byteEditor
			' 
			Me.byteEditor.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.byteEditor.AutoHeight = False
			Me.byteEditor.Mask.EditMask = "n0"
			Me.byteEditor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.byteEditor.Name = "byteEditor"
			Me.byteEditor.ValueType = DXSample.AllowedValueTypes.Byte
			' 
			' shortEdit
			' 
			Me.shortEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.shortEdit.AutoHeight = False
			Me.shortEdit.Mask.EditMask = "n0"
			Me.shortEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.shortEdit.Name = "shortEdit"
			Me.shortEdit.ValueType = DXSample.AllowedValueTypes.Int16
			' 
			' integerEdit
			' 
			Me.integerEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.integerEdit.AutoHeight = False
			Me.integerEdit.Mask.EditMask = "n0"
			Me.integerEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.integerEdit.Name = "integerEdit"
			' 
			' longEdit
			' 
			Me.longEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.longEdit.AutoHeight = False
			Me.longEdit.Mask.EditMask = "n0"
			Me.longEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.longEdit.Name = "longEdit"
			Me.longEdit.ValueType = DXSample.AllowedValueTypes.Int64
			' 
			' myTextEdit1
			' 
			Me.myTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dataSet1, "Table1.ByteColumn", True))
			Me.myTextEdit1.EditValue = (CByte(0))
			Me.myTextEdit1.Location = New System.Drawing.Point(81, 250)
			Me.myTextEdit1.Name = "myTextEdit1"
			Me.myTextEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.myTextEdit1.Properties.Mask.EditMask = "n0"
			Me.myTextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.myTextEdit1.Properties.ValueType = DXSample.AllowedValueTypes.Byte
			Me.myTextEdit1.Size = New System.Drawing.Size(100, 20)
			Me.myTextEdit1.TabIndex = 1
			' 
			' myTextEdit2
			' 
			Me.myTextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dataSet1, "Table1.IntegerColumn", True))
			Me.myTextEdit2.EditValue = 0
			Me.myTextEdit2.Location = New System.Drawing.Point(81, 297)
			Me.myTextEdit2.Name = "myTextEdit2"
			Me.myTextEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.myTextEdit2.Properties.Mask.EditMask = "n0"
			Me.myTextEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.myTextEdit2.Size = New System.Drawing.Size(100, 20)
			Me.myTextEdit2.TabIndex = 2
			' 
			' myTextEdit3
			' 
			Me.myTextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dataSet1, "Table1.ShortColumn", True))
			Me.myTextEdit3.EditValue = (CShort(Fix(0)))
			Me.myTextEdit3.Location = New System.Drawing.Point(256, 250)
			Me.myTextEdit3.Name = "myTextEdit3"
			Me.myTextEdit3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.myTextEdit3.Properties.Mask.EditMask = "n0"
			Me.myTextEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.myTextEdit3.Properties.ValueType = DXSample.AllowedValueTypes.Int16
			Me.myTextEdit3.Size = New System.Drawing.Size(100, 20)
			Me.myTextEdit3.TabIndex = 3
			' 
			' myTextEdit4
			' 
			Me.myTextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dataSet1, "Table1.LongColumn", True))
			Me.myTextEdit4.EditValue = (CLng(Fix(0)))
			Me.myTextEdit4.Location = New System.Drawing.Point(256, 297)
			Me.myTextEdit4.Name = "myTextEdit4"
			Me.myTextEdit4.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.myTextEdit4.Properties.Mask.EditMask = "n0"
			Me.myTextEdit4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			Me.myTextEdit4.Properties.ValueType = DXSample.AllowedValueTypes.Int64
			Me.myTextEdit4.Size = New System.Drawing.Size(100, 20)
			Me.myTextEdit4.TabIndex = 4
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 253)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(22, 13)
			Me.labelControl1.TabIndex = 5
			Me.labelControl1.Text = "Byte"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(187, 253)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(26, 13)
			Me.labelControl2.TabIndex = 6
			Me.labelControl2.Text = "Int16"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(12, 300)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(26, 13)
			Me.labelControl3.TabIndex = 7
			Me.labelControl3.Text = "Int32"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(187, 300)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(26, 13)
			Me.labelControl4.TabIndex = 8
			Me.labelControl4.Text = "Int64"
			' 
			' colByteColumn
			' 
			Me.colByteColumn.Caption = "ByteColumn"
			Me.colByteColumn.ColumnEdit = Me.byteEditor
			Me.colByteColumn.FieldName = "ByteColumn"
			Me.colByteColumn.Name = "colByteColumn"
			Me.colByteColumn.Visible = True
			Me.colByteColumn.VisibleIndex = 0
			' 
			' colShortColumn
			' 
			Me.colShortColumn.Caption = "ShortColumn"
			Me.colShortColumn.ColumnEdit = Me.shortEdit
			Me.colShortColumn.FieldName = "ShortColumn"
			Me.colShortColumn.Name = "colShortColumn"
			Me.colShortColumn.Visible = True
			Me.colShortColumn.VisibleIndex = 1
			' 
			' colIntegerColumn
			' 
			Me.colIntegerColumn.Caption = "IntegerColumn"
			Me.colIntegerColumn.ColumnEdit = Me.integerEdit
			Me.colIntegerColumn.FieldName = "IntegerColumn"
			Me.colIntegerColumn.Name = "colIntegerColumn"
			Me.colIntegerColumn.Visible = True
			Me.colIntegerColumn.VisibleIndex = 2
			' 
			' colLongColumn
			' 
			Me.colLongColumn.Caption = "LongColumn"
			Me.colLongColumn.ColumnEdit = Me.longEdit
			Me.colLongColumn.FieldName = "LongColumn"
			Me.colLongColumn.Name = "colLongColumn"
			Me.colLongColumn.Visible = True
			Me.colLongColumn.VisibleIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(540, 342)
			Me.Controls.Add(Me.labelControl4)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.myTextEdit4)
			Me.Controls.Add(Me.myTextEdit3)
			Me.Controls.Add(Me.myTextEdit2)
			Me.Controls.Add(Me.myTextEdit1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.byteEditor, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.shortEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.integerEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.longEdit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myTextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myTextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myTextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private myTextEdit1 As DXSample.MyTextEdit
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private dataColumn4 As System.Data.DataColumn
		Private byteEditor As DXSample.RepositoryItemMyTextEdit
		Private shortEdit As DXSample.RepositoryItemMyTextEdit
		Private integerEdit As DXSample.RepositoryItemMyTextEdit
		Private longEdit As DXSample.RepositoryItemMyTextEdit
		Private myTextEdit2 As DXSample.MyTextEdit
		Private myTextEdit3 As DXSample.MyTextEdit
		Private myTextEdit4 As DXSample.MyTextEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private colByteColumn As DevExpress.XtraGrid.Columns.GridColumn
		Private colShortColumn As DevExpress.XtraGrid.Columns.GridColumn
		Private colIntegerColumn As DevExpress.XtraGrid.Columns.GridColumn
		Private colLongColumn As DevExpress.XtraGrid.Columns.GridColumn

	End Class
End Namespace