using Nitro.Simulator.Entities;

namespace Nitro.Simulator.Infrastructure
{
    public interface IUiManager
    {
        ExamSession ShowExamConfigurationView(Exam exam);
    }
}