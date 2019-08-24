using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using Newtonsoft.Json;
using Nitro.Simulator.Entities;

namespace Nitro.Simulator.ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static List<ExamFileInfo> ToExamFileInfoList(this string[] fileNames)
        {
            List<ExamFileInfo> examFileInfos = new List<ExamFileInfo>(fileNames.Length);
            foreach (string fileName in fileNames)
            {
                Exam exam = JsonConvert.DeserializeObject<Exam>(File.ReadAllText(fileName));
                examFileInfos.Add(new ExamFileInfo(exam.Id, exam.Name, exam.Author, fileName));
            }
            return examFileInfos;
        }

        public static string ToTitleCase(this string input)
        {
            TextInfo textInfo = new CultureInfo("en-GB", false).TextInfo;
            return textInfo.ToTitleCase(input);
        }
    }
}
