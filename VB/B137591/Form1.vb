Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace B137591
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			InitializeData()
		End Sub
		Private Sub InitializeData()
			For i As Integer = 0 To 9
				dataTable1.Rows.Add(Nothing, Nothing, Nothing, Nothing)
			Next i
		End Sub
	End Class
End Namespace