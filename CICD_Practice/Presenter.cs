using Budget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICD_Practice
{
    public class Presenter
    {
        public Presenter()
        {
            HomeBudget budget = new HomeBudget("abc.db", true);
        }
    }
}
