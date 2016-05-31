using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pmssystem.holiday
{
    public enum Enum_StaffStatus
    {
        ssActive,
        ssInactive,
        ssPrivate
    }


    public class StaffMember
    {
        private int fD;

        public int ID
        {
            get { return fD; }
            set { fD = value; }
        }
        private Enum_StaffStatus fStatus;

        public Enum_StaffStatus Status
        {
            get { return fStatus; }
            set { fStatus = value; }
        }

        private int fRights;

        public int Rights
        {
            get { return fRights; }
            set { fRights = value; }
        }

        private DateTime fDateTimeCreation;

        public DateTime DateTimeCreation
        {
            get { return fDateTimeCreation; }
            set { fDateTimeCreation = value; }
        }

        private int fStaffNr;
        /// <summary>
        /// Personalnummer
        /// </summary>
        public int StaffNr
        {
            get { return fStaffNr; }
            set { fStaffNr = value; }
        }

        private string fPrename;

        public string Prename
        {
            get { return fPrename; }
            set { fPrename = value; }
        }
        private string fSurname;

        public string Surname
        {
            get { return fSurname; }
            set { fSurname = value; }
        }

    }
}
