using System.Collections.Generic;
using Nitro.Simulator.Entities;

namespace Nitro.Simulator.Infrastructure
{
    public interface IStorageManager
    {
        IList<ExamFileInfo> GetExamFileInfoList();
        void SaveExamFileInfos(List<ExamFileInfo> examFileInfos);
        void RemoveExamInfo(ExamFileInfo info);
        Exam LoadExam(ExamFileInfo examInfo);
    }
}