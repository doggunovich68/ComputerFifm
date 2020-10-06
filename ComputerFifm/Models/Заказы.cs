using System;
using System.Collections.Generic;

namespace ComputerFifm.Models
{
    public partial class Заказы
    {
        public long ДатаЗаказа { get; set; }
        public long ДатаИсполнения { get; set; }
        public long ДоляПредоплаты { get; set; }
        public long ОтметкаОбОплате { get; set; }
        public long ОтметкаОбИсполнении { get; set; }
        public long ОбщаяСтоимость { get; set; }
        public long СрокОбщейГарантии { get; set; }
        public long КодСотрудника { get; set; }
        public long КодКомплектующего { get; set; }
        public long КодКомплектующего1 { get; set; }
        public long КодКомплектующего2 { get; set; }
        public long КодКомплектующего3 { get; set; }
        public long КодЗаказчика { get; set; }
        public long КодУслуги { get; set; }
        public long КодУслуги1 { get; set; }
        public long КодУслуги2 { get; set; }
        public long КодУслуги3 { get; set; }

        public virtual Заказчики КодЗаказчикаNavigation { get; set; }
        public virtual Комплектующие КодКомплектующего1Navigation { get; set; }
        public virtual Комплектующие КодКомплектующего2Navigation { get; set; }
        public virtual Комплектующие КодКомплектующего3Navigation { get; set; }
        public virtual Комплектующие КодКомплектующегоNavigation { get; set; }
        public virtual Сотрудники КодСотрудникаNavigation { get; set; }
        public virtual Услуги КодУслуги1Navigation { get; set; }
        public virtual Услуги КодУслуги2Navigation { get; set; }
        public virtual Услуги КодУслуги3Navigation { get; set; }
        public virtual Услуги КодУслугиNavigation { get; set; }
    }
}
