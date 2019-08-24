using System;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using Nitro.Simulator.Entities;
using Nitro.Simulator.Infrastructure.Interfaces;

namespace Nitro.Simulator.Infrastructure
{
    [Export(typeof(IExamManager))]
    public class ExamManager : IExamManager
    {
        private readonly IUiManager _uiManager;
        public event EventHandler<ExamOutcome> OnExamCompleted;

        [ImportingConstructor]
        public ExamManager(IUiManager uiManager)
        {
            _uiManager = uiManager;
        }

        public void BeginExam(ExamFileInfo examInfo)
        {
            ExamSession session = _uiManager.ShowExamConfigurationView(examInfo);

            if (session != null)
                BeginExamSession(session);

            OnExamCompleted?.Invoke(null, session == null ? ExamOutcome.NotStarted : ExamOutcome.Completed);
        }

        private void BeginExamSession(ExamSession session)
        {
            _uiManager.ShowExamShell(session);
        }
    }
}