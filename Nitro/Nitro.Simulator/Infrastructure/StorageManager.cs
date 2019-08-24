using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using Newtonsoft.Json;
using Nitro.Simulator.Entities;
using Nitro.Simulator.Infrastructure.Interfaces;

namespace Nitro.Simulator.Infrastructure
{
    [Export(typeof(IStorageManager))]
    public class StorageManager : IStorageManager
    {
        private readonly IsolatedStorageFile _isolatedStorageFile;

        public StorageManager()
        {
            _isolatedStorageFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
        }

        public IList<ExamFileInfo> GetExamFileInfoList()
        {
            if (_isolatedStorageFile.FileExists("examCatalogue.json"))
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("examCatalogue.json", FileMode.Open, _isolatedStorageFile))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        ExamFileCatalogueInfo examCatalogue = JsonConvert.DeserializeObject<ExamFileCatalogueInfo>(reader.ReadToEnd());

                        if (examCatalogue?.ExamFileInfos != null)
                            return examCatalogue.ExamFileInfos.ToList();

                        return new List<ExamFileInfo>();
                    }
                }
            }
            else
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("examCatalogue.json", FileMode.CreateNew, _isolatedStorageFile))
                {
                    using (StreamWriter writer = new StreamWriter(isoStream))
                        writer.Write(JsonConvert.SerializeObject(new ExamFileCatalogueInfo()));
                }
            }

            return new List<ExamFileInfo>();
        }

        public void SaveExamFileInfos(List<ExamFileInfo> examFileInfos)
        {
            ExamFileCatalogueInfo examCatalogue;

            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("examCatalogue.json", FileMode.Open, _isolatedStorageFile))
            {
                using (StreamReader reader = new StreamReader(isoStream))
                    examCatalogue = JsonConvert.DeserializeObject<ExamFileCatalogueInfo>(reader.ReadToEnd());
            }

            examCatalogue.AddExamFileInfos(examFileInfos);
            _isolatedStorageFile.DeleteFile("examCatalogue.json");

            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("examCatalogue.json", FileMode.CreateNew, _isolatedStorageFile))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                    writer.Write(JsonConvert.SerializeObject(examCatalogue));
            }
        }

        public void RemoveExamInfo(ExamFileInfo info)
        {
            ExamFileCatalogueInfo examCatalogue;

            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("examCatalogue.json", FileMode.Open, _isolatedStorageFile))
            {
                using (StreamReader reader = new StreamReader(isoStream))
                    examCatalogue = JsonConvert.DeserializeObject<ExamFileCatalogueInfo>(reader.ReadToEnd());
            }

            int index = -1;

            for (int i = 0; i < examCatalogue.ExamFileInfos.Count; i++)
            {
                if (examCatalogue.ExamFileInfos[0].Id.Equals(info.Id))
                {
                    index = i;
                    break;
                }
            }

            if (index > -1)
                examCatalogue.ExamFileInfos.RemoveAt(index);

            _isolatedStorageFile.DeleteFile("examCatalogue.json");

            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("examCatalogue.json", FileMode.CreateNew, _isolatedStorageFile))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                    writer.Write(JsonConvert.SerializeObject(examCatalogue));
            }
        }

        public Exam LoadExam(ExamFileInfo examInfo)
        {
            if (File.Exists(examInfo.Path))
                return JsonConvert.DeserializeObject<Exam>(File.ReadAllText(examInfo.Path));

            return null;
        }
    }
}