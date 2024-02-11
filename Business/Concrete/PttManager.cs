using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;



namespace Business.Concrete 
{
    public class PttManager : ISupplierService
    {
        //Field'lar classın içinde _ ile yazılır.
        private IApplicantService _applicantService;


        public PttManager(IApplicantService applicantService)//Constructer(oluşturucu) PttManager'ı newlediğimiz zaman bu blok önce çalışır
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager(); newlediğimiz için bağımlıyız o sebeple bu kısmı silip değiştirdik
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi ");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ!");
            }
               
        }

        public void GiveMask()
        {
            throw new NotImplementedException();
        }
    }
} 