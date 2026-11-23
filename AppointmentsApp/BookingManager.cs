using System;

namespace AppointmentsApp
{
    public class BookingManager
    {
        private Appointment[] appointments;
        private int numOfElements;

        public BookingManager(int size)
        {
            if (size < 1)
                size = 1;
            appointments = new Appointment[size];
            numOfElements = 0;
        }

        public int Count
        {
            get { return numOfElements; }
        }

        // ---------- Grade D ----------

        // Returnerar false om objektet är null eller arrayen är full
        public bool Add(Appointment appointment)
        {
            if (appointment == null)
                return false;
            if (numOfElements >= appointments.Length)
                return false;

            appointments[numOfElements] = appointment;
            numOfElements++;
            return true;
        }

        // Överlagrad version som skapar objektet själv
        public bool Add(string firstName, string lastName, DateTime date)
        {
            try
            {
                Appointment a = new Appointment(firstName, lastName, date);
                return Add(a);
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public string[] GetInfoStrings()
        {
            string[] info = new string[numOfElements];
            for (int i = 0; i < numOfElements; i++)
            {
                info[i] = appointments[i].ToString();
            }
            return info;
        }

        // ---------- Grade C ----------

        private bool IsValidIndex(int index)
        {
            return index >= 0 && index < numOfElements;
        }

        public bool RemoveAt(int index)
        {
            if (!IsValidIndex(index))
                return false;

            ShiftLeft(index);
            numOfElements--;
            return true;
        }

        // Flyttar alla element efter index ett steg åt vänster
        private void ShiftLeft(int index)
        {
            for (int i = index; i < numOfElements - 1; i++)
            {
                appointments[i] = appointments[i + 1];
            }
            appointments[numOfElements - 1] = null;
        }

        // ---------- Grade B ----------

        public Appointment GetAt(int index)
        {
            if (!IsValidIndex(index))
                return null;
            return appointments[index];
        }

        public bool ChangeAt(int index, Appointment appointment)
        {
            if (!IsValidIndex(index) || appointment == null)
                return false;

            appointments[index] = appointment;
            return true;
        }

        // ---------- Grade A ----------

        // Filtrera på ett datum, eller hela månaden om wholeMonth är true
        public string[,] FilterByDate(DateTime date, bool wholeMonth)
        {
            // Pass 1: räkna träffar
            int matches = 0;
            for (int i = 0; i < numOfElements; i++)
            {
                if (DateMatches(appointments[i], date, wholeMonth))
                    matches++;
            }

            // Pass 2: fyll tabellen
            string[,] table = new string[matches, 4];
            int row = 0;
            for (int i = 0; i < numOfElements; i++)
            {
                if (DateMatches(appointments[i], date, wholeMonth))
                {
                    FillRow(table, row, appointments[i]);
                    row++;
                }
            }
            return table;
        }

        public string[,] FilterByCareType(CareType careType)
        {
            int matches = 0;
            for (int i = 0; i < numOfElements; i++)
            {
                if (appointments[i].CareType == careType)
                    matches++;
            }

            string[,] table = new string[matches, 4];
            int row = 0;
            for (int i = 0; i < numOfElements; i++)
            {
                if (appointments[i].CareType == careType)
                {
                    FillRow(table, row, appointments[i]);
                    row++;
                }
            }
            return table;
        }

        private bool DateMatches(Appointment a, DateTime date, bool wholeMonth)
        {
            if (wholeMonth)
                return a.AppointmentDate.Year == date.Year &&
                       a.AppointmentDate.Month == date.Month;
            return a.AppointmentDate.Date == date.Date;
        }

        // Kolumner: vårdgivare, datum, tid, namn
        private void FillRow(string[,] table, int row, Appointment a)
        {
            table[row, 0] = a.CareType.ToString();
            table[row, 1] = a.AppointmentDate.ToString("yyyy-MM-dd");
            table[row, 2] = a.AppointmentDate.ToString("HH:mm");
            table[row, 3] = a.LastName + ", " + a.FirstName;
        }
    }
}