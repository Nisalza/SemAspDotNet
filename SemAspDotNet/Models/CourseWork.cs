//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;

namespace SemAspDotNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class CourseWork
    {
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Title { get; set; }

        [DisplayName("Оценка")]
        public byte Mark { get; set; }

        [DisplayName("Курс")]
        public byte Course { get; set; }

        [DisplayName("Руководитель")]
        public virtual Teacher Teacher { get; set; }

        [DisplayName("Автор")]
        public virtual Student Student { get; set; }
    }
}
