# (Obsolete) A numeric editor with the input validation


<p>In a simple situation, this task can be accomplished by assigning the numeric mask to the TextEdit editor. However, when editor is bound to the data source that allows Null values, editor might have no initial value assigned. In this situation, the type of value can't be resolved before the editor is validated. To overcome this problem, it's necessary to assign the value of appropriate type to the editor's EditValue property, before it is bound to the data. This example demonstrates how to implement the editor that perform this automatically. It can be used both as the stand-alone or in-place editor.</p>

<br/>


