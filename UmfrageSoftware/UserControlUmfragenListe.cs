using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmfrageSoftware
{
    public partial class UserControlUmfragenListe : UserControl
    {
        public UserControlUmfragenListe()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {

           ModelUmfragenListe.UmfragenSammeln();


            base.OnLoad(e);
        }

    }
}
