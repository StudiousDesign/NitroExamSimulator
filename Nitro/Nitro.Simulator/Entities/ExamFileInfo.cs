using System;

namespace Nitro.Simulator.Entities
{
    public class ExamFileInfo
    {
        public Guid Id { get; set; }
        public Guid ExamId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Path { get; set; }

        public ExamFileInfo(Guid examId, string name, string author, string path)
        {
            Id = Guid.NewGuid();
            ExamId = examId;
            Path = path;
            Name = name;
            Author = author;
        }
    }
}