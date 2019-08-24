using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nitro.Simulator.Infrastructure;

namespace Nitro.Simulator.Entities
{
    public class ExamSession
    {
        public Exam Exam { get; set; }
        public string CandidateName { get; set; }
        public ExamMode ExamMode { get; set; }

        public ExamSession(Exam exam, string candidateName, ExamMode examMode)
        {
            Exam = exam;
            CandidateName = candidateName;
            ExamMode = examMode;
        }
    }
}
