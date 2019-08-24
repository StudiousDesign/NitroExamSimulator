using Nitro.Simulator.Entities;

namespace Nitro.Simulator.Infrastructure.Interfaces
{
    public interface IUiManager
    {
        ExamSession ShowExamConfigurationView(ExamFileInfo exam);
    }
}