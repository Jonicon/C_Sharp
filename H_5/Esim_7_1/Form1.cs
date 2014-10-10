using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esim_7_1 {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            //TÃ¤ssÃ¤ yleistaLinkLabel:n tekstissÃ¤ mÃ¤Ã¤ritellÃ¤Ã¤n linkki, 
            //joka alkaa indeksillÃ¤ 0 ja sen pituus on
            //11 merkkiÃ¤ ja viittaa osoitteeseen www.suomi.fi. 
            GeneralInfoLinklabel.Links.Add(0, 11, "www.suomi.fi");

            //TÃ¤ssÃ¤ yleistaLinkLabel:n tekstissÃ¤ mÃ¤Ã¤ritellÃ¤Ã¤n toinen linkki, 
            //joka alkaa indeksillÃ¤ 58 ja sen pituus on
            //5 merkkiÃ¤ ja viittaa osoitteeseen www.vaasa.fi.  
            GeneralInfoLinklabel.Links.Add(58, 5, "www.vaasa.fi");


            //TÃ¤ssÃ¤ vamkLinkLabel:n tekstissÃ¤ mÃ¤Ã¤ritellÃ¤Ã¤n linkki, 
            //joka alkaa indeksillÃ¤ 0 ja sen pituus on
            //25 merkkiÃ¤ ja viittaa osoitteeseen www.puv.fi. 
            VAMLinklabel.Links.Add(0, 25, "www.puv.fi");
        }

        private void GeneralInfoLinklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //TÃ¤ssÃ¤ tarkistetaan onko linkkilipukkeen ensimmÃ¤istÃ¤ linkkiÃ¤ napsautettu. Jos on,
            //kÃ¤ynnistetÃ¤Ã¤n Internet Explorer ja linkin sisÃ¤ltÃ¶ nÃ¤ytetÃ¤Ã¤n. Huomaa, kuinka
            //linkkilipukkeen linkkeihin viitataan links-kokoelman kautta.
            if (e.Link.LinkData.Equals(GeneralInfoLinklabel.Links[0].LinkData))
                System.Diagnostics.Process.Start("IExplore", GeneralInfoLinklabel.Links[0].LinkData.ToString());

            //TÃ¤ssÃ¤ tarkistetaan onko linkkilipukkeen toista linkkiÃ¤ napsautettu. Jos on,
            //kÃ¤ynnistetÃ¤Ã¤n Internet Explorer ja linkin sisÃ¤ltÃ¶ nÃ¤ytetÃ¤Ã¤n. Huomaa, kuinka
            //linkkilipukkeen linkkeihin viitataan links-kokoelman kautta.
            if (e.Link.LinkData.Equals(GeneralInfoLinklabel.Links[1].LinkData))
                System.Diagnostics.Process.Start("IExplore", GeneralInfoLinklabel.Links[1].LinkData.ToString());
        }

        private void VAMLinklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //TÃ¤ssÃ¤ kÃ¤ynnistetÃ¤Ã¤n Internet Explorer ja vamkLinkkiLipuke:n ensimmÃ¤isen
            //linkin sisÃ¤ltÃ¶ nÃ¤ytetÃ¤Ã¤n.
            System.Diagnostics.Process.Start("IExplore", VAMLinklabel.Links[0].LinkData.ToString());
        }

        private void YleLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //TÃ¤ssÃ¤ kÃ¤ynnistetÃ¤Ã¤n Google Chrome ja yleLinkkiLipuke:n tekstin edustaman
            //linkin sisÃ¤ltÃ¶ nÃ¤ytetÃ¤Ã¤n.
            System.Diagnostics.Process.Start("chrome", YleLinkLabel.Text);
        }

        private void BeachBallLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //TÃ¤ssÃ¤ kÃ¤ynnistetÃ¤Ã¤n Mozilla Firefox ja rantaPallolinkkiLipuke:n tekstin edustaman
            //linkin sisÃ¤ltÃ¶ nÃ¤ytetÃ¤Ã¤n.
            System.Diagnostics.Process.Start("firefox", BeachBallLinkLabel.Text);
        }
    }
}
