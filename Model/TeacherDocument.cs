//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tesis.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeacherDocument
    {
        public int ID { get; set; }
        public int TeacherID { get; set; }
        public int DocumentID { get; set; }
    
        public virtual Document Document { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
