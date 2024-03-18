using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FOQAData;
namespace FOQA
{
    public partial class fAircraft : Form
    {
        DataSet dsAircraft;
        DataSet dsAircraftType;
        public fAircraft()
        {
            InitializeComponent();
        }

        private void fAircraft_Load(object sender, EventArgs e)
        {
            LoadAircraft();
        }

        private void LoadAircraft()
        {
            Cursor.Current = Cursors.WaitCursor;

            dsAircraft = fData.DataProc.Load_Aircraft();
            dsAircraftType = fData.DataProc.Load_AircraftType();

            dgvAircraft.DataSource = dsAircraft.Tables[0];

            cAircraftType.DataSource = dsAircraftType.Tables[0];
            cAircraftType.DisplayMember = "Type";
            cAircraftType.ValueMember = "AircraftTypeID";
            cAircraftType.Text = "";

            Cursor.Current = Cursors.Default;
        }

        private void bAddAircraft_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (tRegistration.Text != "" || cAircraftType.Text != "")
            {
                fData.DataProc.Insert_tAircraft(tRegistration.Text.ToString().ToUpper(),
                    cAircraftType.Text.ToString(),
                    Convert.ToInt32(cAircraftType.SelectedValue));
                LoadAircraft();
            }

            tRegistration.Text = "";
            cAircraftType.Text = "";

            Cursor.Current = Cursors.Default;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            fData.DataProc.Delete_tAircraft(Convert.ToInt32(dgvAircraft["cAircraftID", dgvAircraft.CurrentRow.Index].Value));
            LoadAircraft();
        }
        
    }
}
