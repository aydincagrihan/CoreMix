using DelegateTestApp.RequestCreators;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            var req = new GetPostRequestCreator();
            var posts = await req.GetPosts();
            MessageBox.Show(posts.FirstOrDefault()?.Title);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            CreatePostRequestCreator post=new CreatePostRequestCreator();
        }
    }
}
