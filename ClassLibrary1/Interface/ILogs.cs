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
   public interface ILogs : IBaseRepository<Log>
    {
        string saveLog(int mensId, string Mensflow, string Mood, string Symptoms);
        List<LogsViewModel> getLog(int UserId);

        List<LogsViewModel> getAllLog();
    }
}
