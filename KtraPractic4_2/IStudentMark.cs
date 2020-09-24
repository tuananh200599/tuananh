using System;
namespace KtraPractic4_2
{
    public interface IStudentMark
    {
        string FullName { set; get; }
        int ID { set; get; }
        string Class { set; get; }
        int Semeter { set; get; }
        float AverageMark { set; get; }
        void Display();

    }
}