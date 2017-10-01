using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool _isControlPanelVisible = true;
        private void btnShowHideControlPanel_Click(object sender, EventArgs e)
        {
            _isControlPanelVisible = !_isControlPanelVisible;
            btnShowHideControlPanel.Checked = _isControlPanelVisible;
            btnShowHideControlPanel.Text = (_isControlPanelVisible ? "Hide" : "Show") + @" Control Panel";

            mainSplitContainer.Panel2Collapsed = !_isControlPanelVisible;
            
        }
    }
}
