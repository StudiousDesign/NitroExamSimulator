﻿using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using Nitro.Simulator.Entities;
using Nitro.Simulator.Infrastructure.Interfaces;
using Nitro.Simulator.Views;

namespace Nitro.Simulator.Infrastructure
{
    [Export(typeof(IUiManager))]
    public class UiManager : IUiManager
    {
        private readonly ExamConfigurationView _examConfigurationView;
        private readonly ExamShellView _examShellView;
        private readonly IStorageManager _storageManager;

        [ImportingConstructor]
        public UiManager(ExamConfigurationView examConfigurationView, ExamShellView examShellView, IStorageManager storageManager)
        {
            _examConfigurationView = examConfigurationView;
            _examShellView = examShellView;
            _storageManager = storageManager;
        }

        public ExamSession ShowExamConfigurationView(ExamFileInfo examInfo)
        {
            Exam exam = _storageManager.LoadExam(examInfo);

            _examConfigurationView.ShowDialog(Application.OpenForms[0], exam);

            if (_examConfigurationView.CustomCloseReason == CustomCloseReason.ok)
                return _examConfigurationView.ExamSession;

            return null;
        }

        public void ShowExamShell(ExamSession session)
        {
            _examShellView.ShowDialog(session);
        }
    }
}