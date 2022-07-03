using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corelib
{
   public class LogsViewModel
    {
        public int Id { get; set; }

        public int? MensId { get; set; }

        public string MenstrualFlow { get; set; }

        public string Moods { get; set; }

        public string Symptoms { get; set; }

        public DateTime? CrDate { get; set; }
    }
}
