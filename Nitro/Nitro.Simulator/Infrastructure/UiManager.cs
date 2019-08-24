using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using Nitro.Simulator.Entities;
using Nitro.Simulator.Views;

namespace Nitro.Simulator.Infrastructure
{
    [Export(typeof(IUiManager))]
    public class UiManager : IUiManager
    {
        private readonly ExamConfigurationView _examConfigurationView;

        [ImportingConstructor]
        public UiManager(ExamConfigurationView examConfigurationView)
        {
            _examConfigurationView = examConfigurationView;
        }

        public ExamSession ShowExamConfigurationView(Exam exam)
        {
            _examConfigurationView.ShowDialog(Application.OpenForms[0], exam);

            if (_examConfigurationView.CustomCloseReason == CustomCloseReason.ok)
                return _examConfigurationView.ExamSession;

            return null;
        }
    }
}