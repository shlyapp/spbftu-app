using spbftu.Model;
using spbftu.Properties;
using spbftu.View.Pages.ContextPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace spbftu.ViewModel
{
    public class InstitutionsViewModel : INotifyPropertyChanged
    {
        public List<Institution> Institutions { get; private set; } 

        public InstitutionsViewModel()
        {
            Institutions = new List<Institution>
            {
                new Institution("Институт ландшафтной архитектуры, строительства и обработки древесины", "ИЛАСиОД", "Крюковский Александр Сергеевич", "+7 (812) 217 92-53", "i_arch@spbftu.ru", "../../../Resources/1.jpg"),
                new Institution("Институт леса и природопользования", "ИЛиП", "Селиванов Анатолий Архипович", "+7 (812) 217-93-18", "-", "../../../Resources/2.jpg"),
                new Institution("Институт лесного бизнеса и инноватики", "ИЛБиИ", "Нефедова Ирина Дмитриевна", "+7 (812) 217-93-20", "i_ilbi@spbftu.ru", "../../../Resources/3.jpg"),
                new Institution("Институт технологических машин и транспорта леса", "ИТМиТЛ", "Спиридонов Сергей Васильевич", "+7 (812) 217-92-51", "-", "../../../Resources/4.jpg"),
                new Institution("Институт химической переработки биомассы дерева и техносферной безопасности", "ИХПБДиТБ", "Васильев Александр Викторович", "+7 (812) 217-93-72", "-", "../../../Resources/5.jpg"),
                new Institution("Межотраслевой институт дополнительного образования", "МИДО", "Кацадзе Владимир Аркадьевич", "+7 (964) 342-77-19", "tp_mlk@spbftu.ru", "../../../Resources/6.jpg"),
                new Institution("Колледж технологий лесного комплекса и садово-паркового хозяйства", "ТЛКиСПХ", "Канатьева Алла Леонидовна", "+7 (812) 217-81-03", "spo@spbftu.ru", "../../../Resources/7.jpg"),
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
