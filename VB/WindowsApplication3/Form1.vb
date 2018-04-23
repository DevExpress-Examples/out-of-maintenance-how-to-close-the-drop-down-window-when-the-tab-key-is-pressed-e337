Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors

Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub checkedComboBoxEdit1_Properties_Popup(ByVal sender As Object, ByVal e As EventArgs) Handles checkedComboBoxEdit1.Properties.Popup
			Dim popupForm As PopupContainerForm = TryCast((CType(sender, IPopupControl)).PopupWindow, PopupContainerForm)
			popupForm.KeyPreview = True
			AddHandler popupForm.KeyUp, AddressOf popupForm_KeyUp
		End Sub

		Private Sub popupForm_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.KeyCode = Keys.Tab Then
                CType(sender, PopupContainerForm).ClosePopup()
			End If
			Dim f As Form = (TryCast(sender, PopupContainerForm)).OwnerEdit.FindForm()
			Dim c As Control = f.GetNextControl((TryCast(sender, PopupContainerForm)).OwnerEdit, (Not e.Shift))
			Do While Not c.CanFocus
				c = f.GetNextControl(c, (Not e.Shift))
			Loop
			c.Focus()
		End Sub
	End Class
End Namespace