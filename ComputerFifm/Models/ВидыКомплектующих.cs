using System;
using System.Collections.Generic;

namespace ComputerFifm.Models
{
    public partial class ВидыКомплектующих
    {
        public ВидыКомплектующих()
        {
            Комплектующие = new HashSet<Комплектующие>();
        }

        public long КодВида { get; set; }
        public long Наименование { get; set; }
        public long Описание { get; set; }

        public virtual ICollection<Комплектующие> Комплектующие { get; set; }
    }
}
