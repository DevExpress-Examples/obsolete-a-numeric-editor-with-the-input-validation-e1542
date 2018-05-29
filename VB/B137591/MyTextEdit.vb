Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.ComponentModel
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.Utils

Namespace DXSample
	Public Class MyTextEdit
		Inherits TextEdit
		Shared Sub New()
			RepositoryItemMyTextEdit.RegisterMytextEdit()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyTextEdit.MyTextEditName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyTextEdit
			Get
				Return CType(MyBase.Properties, RepositoryItemMyTextEdit)
			End Get
		End Property
		Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
			MyBase.OnHandleCreated(e)
			If EditValue Is Nothing Then
				Properties.AssignDefaultValue(Me)
			End If
		End Sub
	End Class
	<UserRepositoryItem("RegisterMyTextEdit")> _
	Public Class RepositoryItemMyTextEdit
		Inherits RepositoryItemTextEdit
		Shared Sub New()
			RegisterMytextEdit()
		End Sub
		Public Sub New()
			MyBase.New()
			Mask.MaskType = MaskType.Numeric
			Mask.EditMask = "n0"
			valueType_Renamed = AllowedValueTypes.Int32
			AllowNullInput = DefaultBoolean.True
		End Sub
		Friend Const MyTextEditName As String = "MyTextEdit"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return MyTextEditName
			End Get
		End Property
		Private valueType_Renamed As AllowedValueTypes
		<DefaultValue(AllowedValueTypes.Int32)> _
		Public Property ValueType() As AllowedValueTypes
			Get
				Return valueType_Renamed
			End Get
			Set(ByVal value As AllowedValueTypes)
				valueType_Renamed = value
			End Set
		End Property
		Public Shared Sub RegisterMytextEdit()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(MyTextEditName, GetType(MyTextEdit), GetType(RepositoryItemMyTextEdit), GetType(TextEditViewInfo), New TextEditPainter(), True))
		End Sub
		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemMyTextEdit = TryCast(item, RepositoryItemMyTextEdit)
				If source Is Nothing Then
					Return
				End If
				valueType_Renamed = source.valueType
			Finally
				EndUpdate()
			End Try
		End Sub
		Friend Sub AssignDefaultValue(ByVal editor As MyTextEdit)
			Select Case valueType_Renamed
				Case AllowedValueTypes.Byte
					editor.EditValue = CByte(0)
				Case AllowedValueTypes.Int16
					editor.EditValue = CShort(Fix(0))
				Case AllowedValueTypes.Int32
					editor.EditValue = CInt(Fix(0))
				Case AllowedValueTypes.Int64
					editor.EditValue = CLng(Fix(0))
			End Select
		End Sub
		Public Overrides Function CreateEditor() As BaseEdit
			Dim editor As MyTextEdit = CType(MyBase.CreateEditor(), MyTextEdit)
			AssignDefaultValue(editor)
			Return editor
		End Function
	End Class
	Public Enum AllowedValueTypes
		[Byte]
		Int16
		Int32
		Int64
	End Enum
End Namespace