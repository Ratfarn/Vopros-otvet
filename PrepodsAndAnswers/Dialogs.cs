//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrepodsAndAnswers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dialogs
    {
        public int ID { get; set; }
        public int Prepod_ID { get; set; }
        public string Text { get; set; }
    
        public virtual Prepods Prepods { get; set; }
    }
}