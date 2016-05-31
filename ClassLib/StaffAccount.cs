using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pmssystem.holiday
{
    public enum Enum_AccountStatus
    {
        asActive,
        asInactive,
        asBlocked
    }

    /// <summary>
    /// Das Konto eines Mitarbeiters
    /// </summary>
    public class StaffAccount
    {
        private int fAccountID;

        /// <summary>
        /// ID des Kontos
        /// </summary>
        public int AccountID
        {
            get { return fAccountID; }
            set { fAccountID = value; }
        }

        private int fStaffID;
        /// <summary>
        /// ID des Mitarbeiters, dem das Konto zugeordnet ist
        /// </summary>
        public int StaffID
        {
            get { return fStaffID; }
            set { fStaffID = value; }
        }

        private Enum_AccountStatus fStatus;
        /// <summary>
        /// Status des Kontos (aktiv, gesperrt o.ä.)
        /// </summary>
        public Enum_AccountStatus Status
        {
            get { return fStatus; }
            set { fStatus = value; }
        }


        private DateTime fDateTimeCreation;
        /// <summary>
        /// Zeitpunkt, wann das Konto erstellt wurde
        /// </summary>
        public DateTime DateTimeCreation
        {
            get { return fDateTimeCreation; }
            set { fDateTimeCreation = value; }
        }
    }
}
