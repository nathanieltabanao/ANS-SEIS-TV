using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANS_SEIS_TV
{
    public partial class LoadingScreen2 : Form
    {
        public LoadingScreen2()
        {
            InitializeComponent();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await Task.Delay(2000);
            Close();
        }
    }
}
