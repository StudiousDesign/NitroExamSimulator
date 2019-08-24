using System;
using Nitro.Simulator.Entities;

namespace Nitro.Simulator.Infrastructure.Interfaces
{
    public interface IExamManager
    {
        void BeginExam(ExamFileInfo examInfo);
        event EventHandler<ExamOutcome> OnExamCompleted;
    }
}