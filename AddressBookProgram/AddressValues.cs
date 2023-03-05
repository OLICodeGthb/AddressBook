using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class AddressValues
    {
        // refs
        private int m_ContactID;
        private string m_Title;
        private string m_FName;
        private string m_SName;
        private string m_Address;
        private int m_TelNo;

        // GET SET, RETRIEVE VALUES
        public int ContactID { get { return m_ContactID; } set { m_ContactID = value; } }
        public string Title { get { return m_Title; } set { m_Title = value; } }
        public string Fname { get { return m_FName; } set { m_FName = value; } }
        public string Sname { get { return m_SName; } set { m_SName = value; } }
        public string Address { get { return m_Address; } set { m_Address = value; } }
        public int TelNo {  get { return m_TelNo; } set { m_TelNo = value; } }


    }
}
