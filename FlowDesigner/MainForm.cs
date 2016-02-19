using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowDesigner
{
    public partial class MainForm : Form
    {
        FlowChartForm m_chartForm = new FlowChartForm();

        public MainForm()
        {
            InitializeComponent();

            m_chartForm.Show(this.dockPanel);
        }
    }
}
