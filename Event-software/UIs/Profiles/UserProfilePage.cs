﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.andrea
{
    public partial class UserProfilePage : UserControl
    {
        public UserProfilePage()
        {
            InitializeComponent();
        }

        private void UserProfilePage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                eventsUserWillAttendCarousel.AddControl(new UIs.Common.EventMiniView());
            }
        }

    }
}
