using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Homework
    {
        private ICollection<Student> studentHW;

        public Homework()
        {
            this.studentHW = new HashSet<Student>();
        }

        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime? TimeSent { get; set; }

        public virtual ICollection<Student> StudentHW
        {
            get
            {
                return this.studentHW;
            }

            set
            {
                this.studentHW = value;
            }
        }
    }
}
