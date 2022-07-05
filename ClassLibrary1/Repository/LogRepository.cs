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
  public  class LogRepository : BaseRepository<Log, AppDb> , ILogs
    {
        AppDb app = new AppDb();

        public string saveLog(int mensId, string Mensflow, string Mood, string Symptoms)
        {
            app.Logs.Add(new Log { CrDate = DateTime.Now, MensId = mensId,  MenstrualFlow = Mensflow, Moods = Mood, Symptoms = Symptoms });
            app.SaveChanges();
            return "";
        }

        public List<LogsViewModel> getLog(int UserId)
        {
            var get = (from u in app.Logs
                       where u.UserId == UserId
                       select new
                       {
                           MensId = u.MensId,
                           MenstrualFlow = u.MenstrualFlow,
                           Moods = u.Moods,
                           Symptoms = u.Symptoms,
                           CrDate = u.CrDate,
                           Id = u.Id

                       }).Select(x => new LogsViewModel { Symptoms = x.Symptoms, Moods = x.Moods, MenstrualFlow = x.MenstrualFlow, MensId = x.MensId, CrDate = x.CrDate, Id = x.Id }).ToList();

            return get;
        
        }

        public List<LogsViewModel> getAllLog()
        {
            var get = (from u in app.Logs
                  
                       select new
                       {
                           MensId = u.MensId,
                           MenstrualFlow = u.MenstrualFlow,
                           Moods = u.Moods,
                           Symptoms = u.Symptoms,
                           CrDate = u.CrDate,
                           Id = u.Id

                       }).Select(x => new LogsViewModel { Symptoms = x.Symptoms, Moods = x.Moods, MenstrualFlow = x.MenstrualFlow, MensId = x.MensId, CrDate = x.CrDate, Id = x.Id }).ToList();

            return get;

        }
    }
}
