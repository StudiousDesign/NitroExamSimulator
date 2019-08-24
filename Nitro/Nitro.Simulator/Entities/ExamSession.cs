using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nitro.Simulator.Entities
{
    public class ExamSession
    {
        public Exam Exam { get; set; }
        public string CandidateName { get; set; }

        public ExamSession(Exam exam)
        {
            Exam = exam;
        }
    }
}
