﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        

        public int Id { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public Guid HomeworkId { get; set; }

        public virtual Homework Homework { get; set; }
    }
}

