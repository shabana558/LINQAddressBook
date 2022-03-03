using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LINQ AddressBookSystem");
            //Create Object for DataTable
            ContactDataManager contactDataManager = new ContactDataManager();
            ContactDataManager contactDataManagers = new ContactDataManager();
            DataTableManager dataTableManger = new DataTableManager();
            dataTableManger.CreateDataTable();

            //Insert Values into Table
            contactDataManager.FirstName = "Shaik";
            contactDataManager.LastName = "Shabana";
            contactDataManager.PhoneNumber = 9381730292;
            contactDataManager.Email = "shabana@gmail.com";
            contactDataManager.Address = "Amberpet,Hyderabad";
            contactDataManager.City = "Hyderabad";
            contactDataManager.State = "Telangana";
            contactDataManager.zip = 500013;
            dataTableManger.InsertintoDataTable(contactDataManager);

            //Insert Values into Table
            contactDataManagers.FirstName = "Shaik";
            contactDataManagers.LastName = "Shakil";
            contactDataManagers.PhoneNumber = 987654321;
            contactDataManagers.Email = "shakil@gmail.com";
            contactDataManagers.Address = "Bestastreet,Porumamilla";
            contactDataManagers.City = "Kadapa";
            contactDataManagers.State = "AndhraPradesh";
            contactDataManagers.zip = 516193;
            dataTableManger.InsertintoDataTable(contactDataManagers);
            dataTableManger.Display();
            //Modify
            int varl = dataTableManger.EditDataTable("Shafi", "Lastname");
            Console.WriteLine("Success" + varl);
            //Delete
            int var2 = dataTableManger.DeleteRowInDataTable("Shaik");
            Console.WriteLine("Success" + varl);
            //Retrieve based on city or state
            string var3 = dataTableManger.RetrieveBasedOnCityorState("Hyderabad", "Amberpet");
            Console.WriteLine("Success" + varl);
            //count based on city or state
            string var4 = dataTableManger.RetrieveCountBasedOnCityorState();
            Console.WriteLine("Success" + varl);
        }
    }
}
