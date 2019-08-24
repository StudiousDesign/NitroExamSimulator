using System.Collections.Generic;
using DevExpress.Data.Helpers;

namespace Nitro.Simulator.Entities
{
    public class ExamFileCatalogueInfo
    {
        public List<ExamFileInfo> ExamFileInfos { get; set; }

        public void AddExamFileInfos(List<ExamFileInfo> examFileInfos)
        {
            if (ExamFileInfos == null)
                ExamFileInfos = new List<ExamFileInfo>();

            foreach (ExamFileInfo examFileInfo in examFileInfos)
            {
                //todo de-dupe exam infos.
                this.ExamFileInfos.Add(examFileInfo);
            }
        }
    }
}