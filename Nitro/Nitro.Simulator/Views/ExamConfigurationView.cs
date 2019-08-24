using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Nitro.Simulator.Entities;

namespace Nitro.Simulator.Views
{
    [Export(typeof(ExamConfigurationView))]
    public partial class ExamConfigurationView : XtraForm
    {
        public ExamSession ExamSession { get; set; }
        public CustomCloseReason CustomCloseReason { get; set; }

        public ExamConfigurationView()
        {
            InitializeComponent();
        }

        internal void ShowDialog(IWin32Window owner, Exam exam)
        {
            ExamSession = new ExamSession(exam);
            this.ShowDialog(owner);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CustomCloseReason = CustomCloseReason.Cancel;
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                CustomCloseReason = CustomCloseReason.ok;
                this.Close();
            }
        }

        private bool FormIsValid()
        {
            return true;
        }
    }
}