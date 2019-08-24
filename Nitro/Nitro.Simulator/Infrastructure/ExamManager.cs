using System;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using Nitro.Simulator.Entities;

namespace Nitro.Simulator.Infrastructure
{
    [Export(typeof(IExamManager))]
    public class ExamManager : IExamManager
    {
        private readonly IUiManager _uiManager;
        private readonly IStorageManager _storageManager;
        public event EventHandler<ExamOutcome> OnExamCompleted;


        [ImportingConstructor]
        public ExamManager(IUiManager uiManager, IStorageManager storageManager)
        {
            _uiManager = uiManager;
            _storageManager = storageManager;
        }

        public void BeginExam(ExamFileInfo examInfo)
        {
            Exam exam = _storageManager.LoadExam(examInfo);

            if (exam == null)
                return;

            ExamSession session = _uiManager.ShowExamConfigurationView(exam);

            OnExamCompleted?.Invoke(null, session == null ? ExamOutcome.NotStarted : ExamOutcome.Completed);
        }
    }
}