//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Iseu.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faculty
    {
        public Faculty()
        {
            this.Chairs = new HashSet<Chair>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<Chair> Chairs { get; set; }
    }
}
