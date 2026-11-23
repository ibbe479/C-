namespace AppointmentsApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblVisit = new System.Windows.Forms.Label();
            this.lblCare = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbVisit = new System.Windows.Forms.ComboBox();
            this.cmbCare = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstAppointments = new System.Windows.Forms.ListBox();
            this.dtpFilter = new System.Windows.Forms.DateTimePicker();
            this.chkMonth = new System.Windows.Forms.CheckBox();
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.cmbFilterCare = new System.Windows.Forms.ComboBox();
            this.btnFilterCare = new System.Windows.Forms.Button();
            this.lstFilter = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // lblFirst
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(20, 20);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Text = "First Name";

            // lblLast
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(20, 50);
            this.lblLast.Name = "lblLast";
            this.lblLast.Text = "Last Name";

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(320, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Text = "Date";

            // lblVisit
            this.lblVisit.AutoSize = true;
            this.lblVisit.Location = new System.Drawing.Point(320, 50);
            this.lblVisit.Name = "lblVisit";
            this.lblVisit.Text = "Reason for visit";

            // lblCare
            this.lblCare.AutoSize = true;
            this.lblCare.Location = new System.Drawing.Point(320, 80);
            this.lblCare.Name = "lblCare";
            this.lblCare.Text = "Care Provider";

            // lblNotes
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(20, 85);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Text = "Notes";

            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(110, 17);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 23);

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(110, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 23);

            // txtNotes
            this.txtNotes.Location = new System.Drawing.Point(20, 105);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(270, 65);

            // dtpDate
            this.dtpDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(430, 17);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(190, 23);

            // cmbVisit
            this.cmbVisit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisit.Location = new System.Drawing.Point(430, 47);
            this.cmbVisit.Name = "cmbVisit";
            this.cmbVisit.Size = new System.Drawing.Size(190, 23);

            // cmbCare
            this.cmbCare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCare.Location = new System.Drawing.Point(430, 77);
            this.cmbCare.Name = "cmbCare";
            this.cmbCare.Size = new System.Drawing.Size(190, 23);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(20, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnChange
            this.btnChange.Location = new System.Drawing.Point(120, 185);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(90, 30);
            this.btnChange.Text = "Change";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);

            // btnRemove
            this.btnRemove.Location = new System.Drawing.Point(220, 185);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 30);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(540, 193);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "Total: 0";

            // lstAppointments
            this.lstAppointments.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstAppointments.FormattingEnabled = true;
            this.lstAppointments.Location = new System.Drawing.Point(20, 225);
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.Size = new System.Drawing.Size(600, 148);
            this.lstAppointments.SelectedIndexChanged += new System.EventHandler(this.lstAppointments_SelectedIndexChanged);

            // lblFilter
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(20, 390);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Text = "Filter appointments:";

            // dtpFilter
            this.dtpFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilter.Location = new System.Drawing.Point(20, 415);
            this.dtpFilter.Name = "dtpFilter";
            this.dtpFilter.Size = new System.Drawing.Size(130, 23);

            // chkMonth
            this.chkMonth.AutoSize = true;
            this.chkMonth.Location = new System.Drawing.Point(165, 418);
            this.chkMonth.Name = "chkMonth";
            this.chkMonth.Text = "Whole month";

            // btnFilterDate
            this.btnFilterDate.Location = new System.Drawing.Point(300, 412);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(130, 28);
            this.btnFilterDate.Text = "Filter by date";
            this.btnFilterDate.Click += new System.EventHandler(this.btnFilterDate_Click);

            // cmbFilterCare
            this.cmbFilterCare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCare.Location = new System.Drawing.Point(20, 450);
            this.cmbFilterCare.Name = "cmbFilterCare";
            this.cmbFilterCare.Size = new System.Drawing.Size(130, 23);

            // btnFilterCare
            this.btnFilterCare.Location = new System.Drawing.Point(300, 447);
            this.btnFilterCare.Name = "btnFilterCare";
            this.btnFilterCare.Size = new System.Drawing.Size(130, 28);
            this.btnFilterCare.Text = "Filter by care";
            this.btnFilterCare.Click += new System.EventHandler(this.btnFilterCare_Click);

            // lstFilter
            this.lstFilter.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstFilter.FormattingEnabled = true;
            this.lstFilter.Location = new System.Drawing.Point(20, 485);
            this.lstFilter.Name = "lstFilter";
            this.lstFilter.Size = new System.Drawing.Size(600, 108);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 610);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblVisit);
            this.Controls.Add(this.lblCare);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbVisit);
            this.Controls.Add(this.cmbCare);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstAppointments);
            this.Controls.Add(this.dtpFilter);
            this.Controls.Add(this.chkMonth);
            this.Controls.Add(this.btnFilterDate);
            this.Controls.Add(this.cmbFilterCare);
            this.Controls.Add(this.btnFilterCare);
            this.Controls.Add(this.lstFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVisit;
        private System.Windows.Forms.Label lblCare;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbVisit;
        private System.Windows.Forms.ComboBox cmbCare;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstAppointments;
        private System.Windows.Forms.DateTimePicker dtpFilter;
        private System.Windows.Forms.CheckBox chkMonth;
        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.ComboBox cmbFilterCare;
        private System.Windows.Forms.Button btnFilterCare;
        private System.Windows.Forms.ListBox lstFilter;
    }
}