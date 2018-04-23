using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors;

namespace WindowsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedComboBoxEdit1_Properties_Popup(object sender, EventArgs e)
        {
            PopupContainerForm popupForm = ((IPopupControl)sender).PopupWindow as PopupContainerForm;
            popupForm.KeyPreview = true;
            popupForm.KeyUp += new KeyEventHandler(popupForm_KeyUp);
        }

        void popupForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab) {
                (sender as PopupContainerForm).ClosePopup();
            }
            Form f = (sender as PopupContainerForm).OwnerEdit.FindForm();
            Control c = f.GetNextControl((sender as PopupContainerForm).OwnerEdit, !e.Shift);
            while (!c.CanFocus) 
            {
                c = f.GetNextControl(c, !e.Shift);
            }
            c.Focus();
        }
    }
}