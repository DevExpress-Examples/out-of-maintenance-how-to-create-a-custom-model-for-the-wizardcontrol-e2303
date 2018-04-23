Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraWizard
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.Skins

Namespace WindowsApplication1
	Public Class MyBackButtonViewInfo
		Inherits BackButtonViewInfo
		Public Sub New(ByVal owner As BackButton)
			MyBase.New(owner)

		End Sub

		Protected Overrides Function GetButtonPainter() As EditorButtonPainter
			Return New MyButtonPainter(Me.LookAndFeel)
		End Function
	End Class
End Namespace
