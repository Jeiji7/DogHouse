//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DogHouse.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Survey
    {
        public int ID { get; set; }
        public Nullable<int> IdDog { get; set; }
        public string Illness { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> IdStatus { get; set; }
        public string Comment { get; set; }
        public Nullable<int> IdDoctor { get; set; }
    
        public virtual Dog Dog { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual StatusSurvey StatusSurvey { get; set; }
    }
}
