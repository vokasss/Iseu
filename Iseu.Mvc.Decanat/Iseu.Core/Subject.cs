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
    
    public partial class Subject
    {
        public Subject()
        {
            this.Notes = new HashSet<Note>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ChairId { get; set; }
        public string Title { get; set; }
    
        public virtual Chair Chair { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
