using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookProgram
{
    public class Contact
    {

        // refs
        // objects to store and edit data
        private decimal m_contactID;
        private string m_Title;   
        private string m_Fname;
        private string m_Sname;
        private string m_Address;
        private decimal m_telNo;

        public decimal ContactID { get { return m_contactID; } set { m_contactID = value; } }
        public string Title { get { return m_Title; } set { m_Title = value; } }
        public string FName { get { return m_Fname; } set { m_Fname = value; } }
        public string SName { get { return m_Sname; } set { m_Sname = value; } }
        public string Address { get { return m_Address; } set { m_Address = value; } }
        public decimal Telno { get { return m_telNo; } set { m_telNo = value; } }


    }
}
