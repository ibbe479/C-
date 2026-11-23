using System;

namespace AppointmentsApp
{
    public class Appointment
    {
        private string firstName;
        private string lastName;
        private DateTime appointmentDate;
        private VisitType visitType;
        private CareType careType;
        private string notes;

        public Appointment(string firstName, string lastName, DateTime appointmentDate)
        {
            // Använder properties så att valideringen körs
            FirstName = firstName;
            LastName = lastName;
            AppointmentDate = appointmentDate;
            visitType = VisitType.RoutineCheck;
            careType = CareType.Doctor;
            notes = "";
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name cannot be empty.");
                firstName = value.Trim();
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name cannot be empty.");
                lastName = value.Trim();
            }
        }

        public DateTime AppointmentDate
        {
            get { return appointmentDate; }
            set
            {
                if (value.Year < 2000)
                    throw new ArgumentException("The date is not reasonable.");
                appointmentDate = value;
            }
        }

        public VisitType VisitType
        {
            get { return visitType; }
            set { visitType = value; }
        }

        public CareType CareType
        {
            get { return careType; }
            set { careType = value; }
        }

        public string Notes
        {
            get { return notes; }
            set
            {
                if (value == null)
                    notes = "";
                else
                    notes = value;
            }
        }

        public override string ToString()
        {
            // Notes tas inte med eftersom den kan bli lång
            return string.Format("{0,-18}{1,-14}{2,-14}{3,-17}{4:yyyy-MM-dd}  {4:HH:mm}",
                LastName.ToUpper(), FirstName, VisitType, CareType, AppointmentDate);
        }
    }
}