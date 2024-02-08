using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        //methodun imzası
        void ApplyForMask(Person person);
       
        List<Person> Getlist();


        bool CheckPerson(Person person);
       
    }
}
