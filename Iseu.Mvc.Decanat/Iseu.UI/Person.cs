//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Iseu.UI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<int> Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<int> CityId { get; set; }
        public string Address { get; set; }
        public int Role { get; set; }
        public int Status { get; set; }
    
        public virtual Parent Parent { get; set; }
        public virtual Student Student { get; set; }
    }
}
