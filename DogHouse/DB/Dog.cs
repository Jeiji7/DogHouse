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
    
    public partial class Dog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dog()
        {
            this.Survey = new HashSet<Survey>();
        }
    
        public int ID { get; set; }
        public string Number { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<int> Weight { get; set; }
        public string Description { get; set; }
        public Nullable<int> IdAviary { get; set; }
        public Nullable<int> AboutAge { get; set; }
        public Nullable<int> IdGender { get; set; }
        public Nullable<bool> IsDie { get; set; }
        public Nullable<bool> IsGive { get; set; }
        public string PhoneNumber { get; set; }
        public string Photo { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual TypeAviary TypeAviary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Survey> Survey { get; set; }
    }
}
