using Business;
using ClassLibrary1.Interface;
using Corelib;
using MyLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
   public class MensDateRepositroy : BaseRepository<MensDate, AppDb> , IMensDate
    {

        AppDb app = new AppDb();

        public string saveMensDate(DateTime startdate, DateTime enddate, string remarks, string status, string doctorRemarks)
        {
            app.MensDates.Add(new MensDate { CrDate = DateTime.Now,  DoctorRemarks = doctorRemarks , EndDate = enddate,  Remarks = remarks , StartDate = startdate , Status = status });
            app.SaveChanges();
            return "";
        }


        public List<MensDateViewModel> getMensDate(int UserId)
        {


            var get = (from u in app.MensDates
                       where u.UserId == UserId
                       select new
                       {

                           StartDate = u.StartDate,
                           EndDate = u.EndDate,
                           Remarks = u.Remarks,
                           Status = u.Status,
                           DoctorRemarks = u.DoctorRemarks,
                           Id = u.Id,
                           CrDate = u.CrDate

                       }).Select(x => new MensDateViewModel { CrDate = x.CrDate, DoctorRemarks = x.DoctorRemarks, Status = x.Status, Remarks = x.Remarks, EndDate = x.EndDate, Id = x.Id, StartDate = x.StartDate }).ToList();


            return get;
        
        }


        public List<MensDateViewModel> getAllMensDate()
        {


            var get = (from u in app.MensDates
                 
                       select new
                       {

                           StartDate = u.StartDate,
                           EndDate = u.EndDate,
                           Remarks = u.Remarks,
                           Status = u.Status,
                           DoctorRemarks = u.DoctorRemarks,
                           Id = u.Id,
                           CrDate = u.CrDate

                       }).Select(x => new MensDateViewModel { CrDate = x.CrDate, DoctorRemarks = x.DoctorRemarks, Status = x.Status, Remarks = x.Remarks, EndDate = x.EndDate, Id = x.Id, StartDate = x.StartDate }).ToList();


            return get;

        }
    }
}
