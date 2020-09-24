using System;
namespace KtraPractic3_2

{
    interface INew
    {
        int ID {get;set;}
        string Title {get; set;}
        DateTime PublishDate {get;set;}
        string Author {get;set;}
        string Content {get;set;}
        float AverageRate {get;set;}
        void Display();

    }
}