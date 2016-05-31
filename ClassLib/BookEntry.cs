using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pmssystem.holiday
{
    public enum Enum_BookingEvent
    {
        evInitialStock,
        evBooking,
        evCancelation,
        evChargeBack, // Ausgleichsbuchung
        evDeletion
    }


    public class BookEntry
    {
        private int fAccountID;
        public int AccountID
        {
            get { return fAccountID; }
            set { fAccountID = value; }
        }

        private Enum_BookingEvent fBookingEvent;
        public Enum_BookingEvent BookingEvent
        {
            get { return fBookingEvent; }
            set { fBookingEvent = value; }
        }

        private DateTime fStartOfHoliday;
        public DateTime StartOfHoliday
        {
            get { return fStartOfHoliday; }
            set { fStartOfHoliday = value; }
        }

        private DateTime fEndOfHoliday;
        public DateTime EndOfHoliday
        {
            get { return fEndOfHoliday; }
            set { fEndOfHoliday = value; }
        }

        private double fEVentValue;
        public double EVentValue
        {
            get { return fEVentValue; }
            set { fEVentValue = value; }
        }

        private string fNote;
        public string Note
        {
            get { return fNote; }
            set { fNote = value; }
        }

        private DateTime fEventTimestamp;
        public DateTime EventTimestamp
        {
            get { return fEventTimestamp; }
            set { fEventTimestamp = value; }
        }

        private DateTime fDateTimeApplication;
        public DateTime DateTimeApplication
        {
            get { return fDateTimeApplication; }
            set { fDateTimeApplication = value; }
        }

        private int fApplicantID;
        public int ApplicantID
        {
            get { return fApplicantID; }
            set { fApplicantID = value; }
        }

        private int fApproverID;
        public int ApproverID
        {
            get { return fApproverID; }
            set { fApproverID = value; }
        }

        private Uri fApplicationURI;
        public Uri ApplicationURI
        {
            get { return fApplicationURI; }
            set { fApplicationURI = value; }
        }
    }
}
