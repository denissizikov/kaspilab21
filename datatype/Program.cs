using System;
using System.Collections.Generic;
using datatype.dto;



namespace datatype
{
    class Program
    {
          static void Main(string[] args)
        {
            Employee[] employees = new Employee[6];

            employees[0] = new Junior();
            employees[1] = new Junior();
            employees[2] = new Middle();
            employees[3] = new Director();
            employees[4] = new TeamLead();
            employees[5] = new BigBoss();


            foreach (var e in employees)
            {
                if (e is IManager mgr)
                {
                    mgr.Manage();
                }
            }


        }

    }
    
}
