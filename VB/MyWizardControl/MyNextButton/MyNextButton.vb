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
	Public Class MyNextButton
		Inherits BackButton
		Public Sub New(ByVal wizard As WizardControl)
			MyBase.New(wizard)
		End Sub

		Protected Overrides Function CreateViewInfo() As DevExpress.XtraEditors.ViewInfo.BaseStyleControlViewInfo
			Return New MyBackButtonViewInfo(Me)
		End Function

	End Class

End Namespace
