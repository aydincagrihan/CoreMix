﻿using DelegateTestApp.RequestCreators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateTestApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetPostRequestCreator req = new GetPostRequestCreator();
            var post=req.MakeRequest();
            MessageBox.Show(post.FirstOrDefault().Title);
        }
    }
}
