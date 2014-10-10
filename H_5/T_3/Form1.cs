using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_3 {
    public partial class Links : Form {
        public Links() {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            WebBrowserForm form = new WebBrowserForm(BingLinkLabel.Text);
            form.Text = BingLinkLabel.Text;
            form.Show();
        }

        private void GoogleLinkLabe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            WebBrowserForm form = new WebBrowserForm(GoogleLinkLabe.Text);
            form.Show();
            form.Text = GoogleLinkLabe.Text;
        }

        private void StackOverFlowLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            WebBrowserForm form = new WebBrowserForm(StackOverFlowLink.Text);
            form.Text = StackOverFlowLink.Text;
            form.Show();
        }

        private void MuropakettiLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            WebBrowserForm form = new WebBrowserForm(MuropakettiLinkLabel.Text);
            form.Text = MuropakettiLinkLabel.Text;
            form.Show();
        }
    }
}
