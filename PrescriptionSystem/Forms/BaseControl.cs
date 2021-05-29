using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class BaseControl : UserControl
    {
        public BaseControl()
        {
            InitializeComponent();
        }


        //public void NextScreen<T>(BaseControl oldControl)
        //{
        //    oldControl.Hide();
        //    var aux = new ((BaseControl)typeof(T))
        //    {
        //        Dock = DockStyle.Fill
        //    };
        //    (Parent as Window).Controls.Add(aux);
        //    (Parent as Window).ActiveControl = aux;
        //}

        protected void MoveToScreen(BaseControl newControl)
        {
            Window window = ((Window) Parent);
            window.Controls.Remove(this);
            newControl.Dock = DockStyle.Fill;
            window.Controls.Add(newControl);
        }

        protected void DisableBackButton()
        {
            ButtonBack.Enabled = false;
            ButtonBack.Visible = false;
        }
    }
}
