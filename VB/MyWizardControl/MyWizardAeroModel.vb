Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraWizard

Namespace WindowsApplication1
	Public Class MyWizardAeroModel
		Inherits WizardViewInfo.WizardAeroModel
		Public Sub New(ByVal viewInfo As WizardViewInfo)
			MyBase.New(viewInfo)

		End Sub


		Public Overrides Function GetTitleBarTitleTextBounds(ByVal iconVisible As Boolean) As Rectangle
			Return Rectangle.Empty

		End Function


		Public Overrides Sub UpdateButtonsLocation()
			MyBase.UpdateButtonsLocation()
			TryCast(ViewInfo, MyWizardViewInfo).NextButton.Bounds = GetNextButtonBounds()
		End Sub

		Private Function GetNextButtonBounds() As Rectangle
			Dim backButtonBounds As Rectangle = GetBackButtonBounds()
			backButtonBounds.Offset(backButtonBounds.Width, 0)
			Return backButtonBounds
		End Function

	End Class
End Namespace
