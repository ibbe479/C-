using System;
using System.Windows.Forms;

namespace AppointmentsApp
{
    public partial class MainForm : Form
    {
        private BookingManager manager = new BookingManager(20);

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "The Appointment Manager by Ibrahim Halawani";

            // Fyll comboboxarna med enum-värden
            cmbVisit.DataSource = Enum.GetValues(typeof(VisitType));
            cmbCare.DataSource = Enum.GetValues(typeof(CareType));
            cmbFilterCare.DataSource = Enum.GetValues(typeof(CareType));

            ClearInput();
            lstFilter.Items.Clear();
            UpdateGUI();
        }

        private void ClearInput()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNotes.Clear();
            dtpDate.Value = DateTime.Now;
            cmbVisit.SelectedItem = VisitType.RoutineCheck;
            cmbCare.SelectedItem = CareType.Doctor;
        }

        private void UpdateGUI()
        {
            lstAppointments.Items.Clear();
            string[] info = manager.GetInfoStrings();
            for (int i = 0; i < info.Length; i++)
            {
                lstAppointments.Items.Add(info[i]);
            }
            lblTotal.Text = "Total: " + manager.Count;
        }

        private Appointment ReadInput()
        {
            try
            {
                Appointment a = new Appointment(txtFirstName.Text, txtLastName.Text, dtpDate.Value);
                a.VisitType = (VisitType)cmbVisit.SelectedItem;
                a.CareType = (CareType)cmbCare.SelectedItem;
                a.Notes = txtNotes.Text;
                return a;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid input");
                return null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Appointment a = ReadInput();
            if (a == null)
                return;

            if (manager.Add(a))
            {
                UpdateGUI();
                ClearInput();
            }
            else
            {
                MessageBox.Show("The booking list is full.", "Cannot add");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lstAppointments.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Select an appointment in the list first.", "Nothing selected");
                return;
            }

            if (manager.RemoveAt(index))
            {
                UpdateGUI();
                ClearInput();
            }
        }

        private void lstAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstAppointments.SelectedIndex;
            Appointment a = manager.GetAt(index);
            if (a == null)
                return;

            txtFirstName.Text = a.FirstName;
            txtLastName.Text = a.LastName;
            dtpDate.Value = a.AppointmentDate;
            cmbVisit.SelectedItem = a.VisitType;
            cmbCare.SelectedItem = a.CareType;
            txtNotes.Text = a.Notes;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = lstAppointments.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Select an appointment in the list first.", "Nothing selected");
                return;
            }

            Appointment a = ReadInput();
            if (a == null)
                return;

            if (manager.ChangeAt(index, a))
            {
                UpdateGUI();
            }
        }

        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            string[,] result = manager.FilterByDate(dtpFilter.Value, chkMonth.Checked);
            ShowFilterResult(result);
        }

        private void btnFilterCare_Click(object sender, EventArgs e)
        {
            string[,] result = manager.FilterByCareType((CareType)cmbFilterCare.SelectedItem);
            ShowFilterResult(result);
        }

        private void ShowFilterResult(string[,] table)
        {
            lstFilter.Items.Clear();
            int rows = table.GetLength(0);
            int cols = table.GetLength(1);

            if (rows == 0)
            {
                lstFilter.Items.Add("No matching appointments.");
                return;
            }

            for (int r = 0; r < rows; r++)
            {
                string line = "";
                for (int c = 0; c < cols; c++)
                {
                    line += table[r, c] + "   ";
                }
                lstFilter.Items.Add(line);
            }
        }
    }
}