using Business;
using Corelib;
using MyLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interface
{
   public interface IMensDate : IBaseRepository<MensDate>
    {
        string saveMensDate(DateTime startdate, DateTime enddate, string remarks, string status, string doctorRemarks);

        List<MensDateViewModel> getAllMensDate();

        List<MensDateViewModel> getMensDate(int UserId);
    }
}
