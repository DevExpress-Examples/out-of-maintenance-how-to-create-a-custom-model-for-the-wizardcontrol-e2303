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
	Public Class MyWizardControl
		Inherits WizardControl
		Protected Friend btnNext As MyNextButton

		Public Sub New()
			btnNext = CreateNextButton()
			AddHandler btnNext.Click, AddressOf btnNext_Click
			SubsribeChanges()
			RefreshNextButtonState()
		End Sub

		Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not ValidatePageControls(SelectedPage)) Then
				Return
			End If
			If RaiseNextClick(SelectedPage) Then
				Return
			End If
			SetNextPage()
		End Sub

		Private Function CreateNextButton() As MyNextButton
			Dim button As New MyNextButton(Me)
			button.Parent = Me
			button.LookAndFeel.ParentLookAndFeel = LookAndFeel
			AddHandler button.MouseMove, AddressOf OnChildControlMouseMove
			Return button
		End Function
		Private Sub OnChildControlMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim pt As Point = e.Location
			Dim child As Control = TryCast(sender, Control)
			pt.Offset(child.Left, child.Top)
			OnMouseMove(New MouseEventArgs(e.Button, e.Clicks, pt.X, pt.Y, e.Delta))
		End Sub

		Protected Overrides Function CreateViewInfo() As WizardViewInfo
		  Return New MyWizardViewInfo(Me)

		End Function

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			MyBase.Dispose(disposing)
			RemoveHandler btnNext.Click, AddressOf btnNext_Click
		End Sub
		Private Sub SubsribeChanges()
			For Each c As Control In Controls
				AddHandler c.EnabledChanged, AddressOf c_EnabledChanged
			Next c
		End Sub

		Private Sub c_EnabledChanged(ByVal sender As Object, ByVal e As EventArgs)
			RefreshNextButtonState()
		End Sub

		Public Sub RefreshNextButtonState()
			btnNext.Enabled = SelectedPageIndex < Pages.Count - 1 AndAlso (SelectedPage.AllowNext OrElse DesignMode)
		End Sub
	End Class
End Namespace