﻿using System;
using System.Windows.Forms;

namespace ReaLTaiizor.UI
{
    public partial class Form22 : Form
    {
        public Form22(bool State = false)
        {
            InitializeComponent();

            if (!State)
            {
                parrotSplashScreen1.InitializeLoader(this);
            }
        }

        private void ParrotColorPicker1_SelectedColorChanged(object sender, EventArgs e)
        {
            bigLabel1.Text = parrotColorPicker1.SelectedColorHex;
        }
    }
}