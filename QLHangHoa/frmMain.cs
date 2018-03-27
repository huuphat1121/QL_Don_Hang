using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHangHoa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void setShowmenu(bool System=false,bool Application=false, bool Introduction=false,bool Contact=false)
        {
            grbSystem.Visible = System;
            grbApplication.Visible = Application;
            grbIntroduction.Visible = Introduction;
            grbContact.Visible = Contact;
        }
        private void btnSystem_Click(object sender, EventArgs e)
        {
            setShowmenu(true);
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            setShowmenu(false,true);
        }

        private void btnIntroduction_Click(object sender, EventArgs e)
        {
            setShowmenu(false, false, true);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            setShowmenu(false, false, false, true);
        }
    }
}
