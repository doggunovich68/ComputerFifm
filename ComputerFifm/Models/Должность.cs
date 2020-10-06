using System;
using System.Collections.Generic;

namespace ComputerFifm.Models
{
    public partial class Должность
    {
        public Должность()
        {
            Сотрудники = new HashSet<Сотрудники>();
        }

        public long КодДолжности { get; set; }
        public long НаименованиеДолжности { get; set; }
        public long Оклад { get; set; }
        public long Обязанности { get; set; }
        public long Требования { get; set; }

        public virtual ICollection<Сотрудники> Сотрудники { get; set; }
    }
}
