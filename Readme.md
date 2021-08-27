<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1542)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyTextEdit.cs](./CS/B137591/MyTextEdit.cs) (VB: [MyTextEdit.vb](./VB/B137591/MyTextEdit.vb))
<!-- default file list end -->
# (Obsolete) A numeric editor with the input validation


<p>In a simple situation, this task can be accomplished by assigning the numeric mask to the TextEdit editor. However, when editor is bound to the data source that allows Null values, editor might have no initial value assigned. In this situation, the type of value can't be resolved before the editor is validated. To overcome this problem, it's necessary to assign the value of appropriate type to the editor's EditValue property, before it is bound to the data. This example demonstrates how to implement the editor that perform this automatically. It can be used both as the stand-alone or in-place editor.</p>

<br/>


