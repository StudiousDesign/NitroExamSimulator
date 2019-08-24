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
using DevExpress.XtraEditors.Controls;
using Nitro.Simulator.Entities;
using Nitro.Simulator.ExtensionMethods;
using Nitro.Simulator.Infrastructure;

namespace Nitro.Simulator.Views
{
    [Export(typeof(ExamConfigurationView))]
    public partial class ExamConfigurationView : XtraForm
    {
        private Exam _exam;

        public ExamSession ExamSession => new ExamSession(_exam, CandidateName, ExamMode);

        public ExamMode ExamMode
        {
            get
            {
                if (rbtnTakeEntireExam.Checked)
                    return ExamMode.AllQuestions;

                return ExamMode.AllQuestions;
            }
        }

        public string CandidateName
        {
            get { return txtCandidateName.Text.ToTitleCase(); }
        }

        public CustomCloseReason CustomCloseReason { get; set; }

        public ExamConfigurationView()
        {
            InitializeComponent();
        }

        public void ShowDialog(IWin32Window owner, Exam exam)
        {
            ResetView();
            _exam = exam;
            this.ShowDialog(owner);
        }

        private void ResetView()
        {
            txtCandidateName.Text = string.Empty;
            rbtnTakeEntireExam.Checked = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CustomCloseReason = CustomCloseReason.Cancel;
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CustomCloseReason = CustomCloseReason.ok;
            this.Close();
        }

        #region validation
        private bool FormIsValid()
        {
            return true;
        }

        private void txtCandidateName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCandidateName.Text))
                e.Cancel = true;
        }

        private void txtCandidateName_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
            e.ErrorText = "Please provide a value for field candidate name";
        }
        #endregion validation 
    }
}