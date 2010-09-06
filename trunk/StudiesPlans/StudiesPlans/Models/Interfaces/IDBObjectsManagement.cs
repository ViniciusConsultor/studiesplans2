using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlans.Models.Interfaces
{
    interface IDBObjectsManagement
    {
        void addElement(Object o);

        void editElement(Object o);

        void deleteElement(Object o);

    }
}
