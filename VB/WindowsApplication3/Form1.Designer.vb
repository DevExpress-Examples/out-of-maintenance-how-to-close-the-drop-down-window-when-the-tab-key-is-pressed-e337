Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.checkedComboBoxEdit1 = New DevExpress.XtraEditors.CheckedComboBoxEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.popupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit()
			Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
			CType(Me.checkedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' checkedComboBoxEdit1
			' 
			Me.checkedComboBoxEdit1.Location = New System.Drawing.Point(90, 175)
			Me.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1"
			Me.checkedComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.checkedComboBoxEdit1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() { New DevExpress.XtraEditors.Controls.CheckedListBoxItem("1"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("2"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("4"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("5")})
'			Me.checkedComboBoxEdit1.Properties.Popup += New System.EventHandler(Me.checkedComboBoxEdit1_Properties_Popup);
			Me.checkedComboBoxEdit1.Size = New System.Drawing.Size(244, 20)
			Me.checkedComboBoxEdit1.TabIndex = 0
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(429, 238)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "simpleButton1"
			' 
			' popupContainerEdit1
			' 
			Me.popupContainerEdit1.Location = New System.Drawing.Point(168, 318)
			Me.popupContainerEdit1.Name = "popupContainerEdit1"
			Me.popupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.popupContainerEdit1.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Right))
			Me.popupContainerEdit1.Size = New System.Drawing.Size(252, 20)
			Me.popupContainerEdit1.TabIndex = 2
			' 
			' popupContainerControl1
			' 
			Me.popupContainerControl1.Location = New System.Drawing.Point(220, 368)
			Me.popupContainerControl1.Name = "popupContainerControl1"
			Me.popupContainerControl1.Size = New System.Drawing.Size(200, 100)
			Me.popupContainerControl1.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(598, 454)
			Me.Controls.Add(Me.popupContainerControl1)
			Me.Controls.Add(Me.popupContainerEdit1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.checkedComboBoxEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.checkedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents checkedComboBoxEdit1 As DevExpress.XtraEditors.CheckedComboBoxEdit
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private popupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit
		Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
	End Class
End Namespace

