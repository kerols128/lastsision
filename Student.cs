//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assiment2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int ID { get; set; }
        public string Names { get; set; }
        public string Passwords { get; set; }
        public string Email { get; set; }
        public string Addres { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> DepId { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
