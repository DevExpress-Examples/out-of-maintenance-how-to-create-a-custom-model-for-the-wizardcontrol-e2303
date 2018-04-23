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
	Public Class MyWizardViewInfo
		Inherits WizardViewInfo

		Public ReadOnly Overloads Property NextButton() As MyNextButton
			Get
				Return (TryCast(WizardControl, MyWizardControl)).btnNext
			End Get
		End Property

		Public Sub New(ByVal control As WizardControl)
			MyBase.New(control)

		End Sub

		Protected Overrides Sub CreateButtonsInfo()
			MyBase.CreateButtonsInfo()
		End Sub

		Protected Overrides Function CreateWizardModelCore(ByVal style As WizardStyle) As WizardModelBase
			If style = WizardStyle.WizardAero Then
				Return New MyWizardAeroModel(Me)
			End If
			Return MyBase.CreateWizardModelCore(style)
		End Function


	End Class
End Namespace
