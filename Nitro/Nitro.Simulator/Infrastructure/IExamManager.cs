using System;
using System.Threading.Tasks;
using Nitro.Simulator.Entities;

namespace Nitro.Simulator.Infrastructure
{
    public interface IExamManager
    {
        void BeginExam(ExamFileInfo examInfo);
        event EventHandler<ExamOutcome> OnExamCompleted;
    }
}