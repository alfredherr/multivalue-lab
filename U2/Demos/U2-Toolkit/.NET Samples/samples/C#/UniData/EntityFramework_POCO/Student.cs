//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework_POCO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.Semesters = new HashSet<Semester>();
        }
    
        public string ID { get; set; }
        public string LNAME { get; set; }
        public string FNAME { get; set; }
        public string MAJOR { get; set; }
        public string MINOR { get; set; }
        public string ADVISOR { get; set; }
        public string GPA1 { get; set; }
    
        public virtual ICollection<Semester> Semesters { get; set; }
    }
}