﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employment_center_v2._0
{
    public partial class headband : Form
    {
        public headband()
        {
            InitializeComponent();
        }
//Если бы я знал, что будет все так просто, я бы взялся в последнюю неделю за дипломку :) 
        private void button1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            this.Hide();
        }
    }
}
