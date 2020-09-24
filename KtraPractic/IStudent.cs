using System;
namespace KtraPractic
{
     public interface IStudent
    {
         string Fullname {get; set;}
         int ID {get; set;}

         DateTime DateofBirth {get;set;}
         string Native {get;set;}
         string Class {get;set;}
         string PhoneNo{get;set;}
         int Mobile{get;set;}
         void Display();
         
    }
}