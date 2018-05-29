using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using DevExpress.XtraEditors.Mask;
using DevExpress.Utils;

namespace DXSample {
    public class MyTextEdit : TextEdit {
        static MyTextEdit() { RepositoryItemMyTextEdit.RegisterMytextEdit(); }
        public MyTextEdit() : base() { }
        public override string EditorTypeName { get { return RepositoryItemMyTextEdit.MyTextEditName; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyTextEdit Properties { 
            get { return (RepositoryItemMyTextEdit)base.Properties; } 
        }
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            if (EditValue == null)
                Properties.AssignDefaultValue(this);
        }
    }
    [UserRepositoryItem("RegisterMyTextEdit")]
    public class RepositoryItemMyTextEdit : RepositoryItemTextEdit {
        static RepositoryItemMyTextEdit() { RegisterMytextEdit(); }
        public RepositoryItemMyTextEdit() : base() {
            Mask.MaskType = MaskType.Numeric;
            Mask.EditMask = "n0";
            valueType = AllowedValueTypes.Int32;
            AllowNullInput = DefaultBoolean.True;
        }
        internal const string MyTextEditName = "MyTextEdit";
        public override string EditorTypeName { get { return MyTextEditName; } }
        private AllowedValueTypes valueType;
        [DefaultValue(AllowedValueTypes.Int32)]
        public AllowedValueTypes ValueType {
            get { return valueType; }
            set { valueType = value; }
        }
        public static void RegisterMytextEdit() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(MyTextEditName, typeof(MyTextEdit),
                typeof(RepositoryItemMyTextEdit), typeof(TextEditViewInfo), new TextEditPainter(), true));
        }
        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemMyTextEdit source = item as RepositoryItemMyTextEdit;
                if (source == null) return;
                valueType = source.valueType;
            } finally { EndUpdate(); }
        }
        internal void AssignDefaultValue(MyTextEdit editor) {
            switch (valueType) {
                case AllowedValueTypes.Byte: editor.EditValue = (byte)0; break;
                case AllowedValueTypes.Int16: editor.EditValue = (short)0; break;
                case AllowedValueTypes.Int32: editor.EditValue = (int)0; break;
                case AllowedValueTypes.Int64: editor.EditValue = (long)0; break;
            }
        }
        public override BaseEdit CreateEditor() {
            MyTextEdit editor = (MyTextEdit)base.CreateEditor();
            AssignDefaultValue(editor);
            return editor;
        }
    }
    public enum AllowedValueTypes { Byte, Int16, Int32, Int64 };
}