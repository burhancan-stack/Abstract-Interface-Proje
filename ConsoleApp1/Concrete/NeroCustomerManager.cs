using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuleProje.Abstract;

namespace SimuleProje.Concrete
{
    public class NeroCustomerManager:BaseCustomerManager
    {
        //neronun istedigini düşünelim.

        private ICustomerCheckService _customerCheckService;
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("not a valid person");
            }

        }


    }
}
