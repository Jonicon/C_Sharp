using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esim_7_2 {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            if (FavouritesList.Items.IndexOf(webBrowser1.Document.Url.ToString()) == -1 ) {
                FavouritesList.Items.Add(webBrowser1.Document.Url.ToString() );
                FavouritesList.Text = webBrowser1.Document.Url.ToString();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            // TÃ¤ssÃ¤ Web-selain saadaan siirtymÃ¤Ã¤n mÃ¤Ã¤rÃ¤ttyyn osoitteeseen
            webBrowser1.Url = new Uri("http://www.google.fi");
        }

        private void MainWindow_Resize(object sender, EventArgs e) {
            Size uusiKoko = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);
            webBrowser1.Size = uusiKoko;
        }

        private void PrevButton_Click(object sender, EventArgs e) {
            webBrowser1.GoBack();
        }

        private void HomeButton_Click(object sender, EventArgs e) {
            webBrowser1.GoHome();
        }

        private void NextButton_Click(object sender, EventArgs e) {
            webBrowser1.GoForward();
        }

        private void FavouritesList_SelectedIndexChanged(object sender, EventArgs e) {
            webBrowser1.Url = new Uri(FavouritesList.SelectedItem.ToString());
        }

        private void FavouritesList_KeyUp(object sender, KeyEventArgs e) {
            if (!string.IsNullOrEmpty(FavouritesList.Text) && e.KeyCode.Equals(Keys.Enter)) {
                if (!FavouritesList.Text.StartsWith("http://") && !FavouritesList.Text.StartsWith("https://") && !FavouritesList.Text.StartsWith("file://") ) {
                    FavouritesList.Text = "http://" + FavouritesList.Text;
                }
                webBrowser1.Navigate(FavouritesList.Text);
            }
        }


        private void SearchTextBox_KeyUp(object sender, KeyEventArgs e) {
            if (!string.IsNullOrEmpty(SearchTextBox.Text) && e.KeyCode.Equals(Keys.Enter) ) {
                string str = SearchTextBox.Text.Replace(' ', '+');
                webBrowser1.Navigate("https://www.google.fi/?gws_rd=ssl#q=" + str);
                webBrowser1.Focus();
            }
        }
    }
}
