using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs.Model
{
    public class Job
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<SubJob> SubJobs { get; set; }
    }
}
