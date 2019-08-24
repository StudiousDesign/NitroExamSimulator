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
    [Export(typeof(ExamShellView))]
    public partial class ExamShellView : BaseXtraFrom
    {
        public ExamShellView()
        {
            InitializeComponent();
        }

        public void ShowDialog(ExamSession session)
        {
            ShowDialog();
        }
    }
}