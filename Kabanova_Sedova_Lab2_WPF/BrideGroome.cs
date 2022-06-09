using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kabanova_Sedova_Lab2_WPF
{
    public enum Candidate
    {
        Кирилл, Фёдор, Василий, Владимир, Александр
    }
    public enum Properties
    {
        Высокий, Брюнет, Зеленоглазый, Спортсмен, Богатый
    }
    class BrideGroome
    {
       

        public string PrintCandidate()
        {
            return $"Кандидаты";
        }
    }
}
