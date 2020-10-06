using System;
using System.Collections.Generic;

namespace ComputerFifm.Models
{
    public partial class Комплектующие
    {
        public long КодКомплектующего { get; set; }
        public long Марка { get; set; }
        public long ФирмаПроизводитель { get; set; }
        public long СтранаПроизводитель { get; set; }
        public long ДатаВыпуска { get; set; }
        public long Характеристики { get; set; }
        public long СрокГарантии { get; set; }
        public long Описание { get; set; }
        public long Цена { get; set; }
        public long КодВида { get; set; }

        public virtual ВидыКомплектующих КодВидаNavigation { get; set; }
    }
}
