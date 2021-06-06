using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Forms
{
    public partial class AddPermission : BaseControl
    {
        public AddPermission()
        {
            InitializeComponent();
        }

        private void AddPermission_Load(object sender, EventArgs e)
        {

        }
		
		private void ButtonBack_Click(object sender, EventArgs e)
        {
            MoveToScreen(new CalendarScreenPatient());
        }
    }
}
