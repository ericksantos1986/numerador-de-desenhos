using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerador.Services
{
    static class Status
    {
        static FrmNum frm = (FrmNum)Application.OpenForms["FrmNum"];

        static public void altStatus(string status)
        {
            frm.toolStripStatusLabel1.Text = "";
            frm.toolStripStatusLabel1.Text = status;
        }

    }
}
