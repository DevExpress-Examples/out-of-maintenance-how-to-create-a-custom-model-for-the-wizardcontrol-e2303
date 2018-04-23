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
	Public Class MyButtonPainter
		Inherits SkinBackButtonPainter
		Public Sub New(ByVal provider As DevExpress.Skins.ISkinProvider)
			MyBase.New(provider)

		End Sub

		Protected Overrides Sub DrawContent(ByVal e As DevExpress.Utils.Drawing.ObjectInfoArgs)
			MyBase.DrawContent(e)
		End Sub
		Protected Overrides Function GetRotationAngle(ByVal e As DevExpress.Utils.Drawing.ObjectInfoArgs) As RotateFlipType
			Return RotateFlipType.Rotate180FlipNone
		End Function
	End Class
End Namespace
