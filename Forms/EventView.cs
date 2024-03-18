using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using FOQAData;
using FDAClassLibrary;
using System.Net.Mail;
using System.Net;
using FOQA.TestForms;

namespace FOQA
{
    public partial class eventView : Form
    {
        public eventView()
        {
            InitializeComponent();
        }

        public int eventViewID;
		public int FileId = 0;

		private string time;

		private bool moenieSkryfNie = false;
		private string cMailAddress = "";
		private string foMailAddress = "";

		private string cleanString(string pilotStringToClean)
		{
			string cleanString = pilotStringToClean.Replace(@"""", " ");
			cleanString = cleanString.Replace(":", " ");
			cleanString = cleanString.Remove(0, 28);
			return cleanString;
		}

		private void eventView_Load(object sender, EventArgs e)
        {
			Cursor.Current = Cursors.WaitCursor;
            
			toepModus();
			loadCombo();
			loadDataSet();
			Cursor.Current = Cursors.Default;
        }

		private void loadCombo()
		{

			DataSet ds = new DataSet();
			ds = DataProsedures.LaaiBoksWaardesGebeurtenis();

            try
			{
                cFlightPhase.DataSource = ds.Tables[0];
                cFlightPhase.ValueMember = "flightPhaseId";
				cFlightPhase.DisplayMember = "Phase";
				
			}
			catch (Exception xx)
			{
				MessageBox.Show(xx.Message, "FDA Error loading flight phase.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
            try
            {
                cSeverity.DataSource = ds.Tables[2];
                cSeverity.ValueMember = "SeverityID";
				cSeverity.DisplayMember = "Severity";
                
               // cSeverity.DataSource = ds.Tables["severity"];
            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.Message, "FDA Error loading severity.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                cCause.DataSource = ds.Tables[1];
                cCause.ValueMember = "CauseID";
				cCause.DisplayMember = "Cause";
				
				//cCause.DataSource = ds.Tables["Cause"];
			}
			catch (Exception xx)
			{
				MessageBox.Show(xx.Message, "FDA Error loading cause.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			try
            {
                Scope.DataSource = ds.Tables[3];
                Scope.ValueMember = "ID";
				Scope.DisplayMember = "scope";
            }
            catch (Exception xx)
            {
            	MessageBox.Show(xx.Message, "FDA Error loading from table scope.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

		private void loadDataSet()
		{

			DataTable dt = DataProsedures.LoadEvent(eventViewID);

			if (dt.Rows.Count != 1)
			{
				return;
			}
			#region Test code
			//testForm tf = new testForm();
			//tf.dt = dt;	
			//tf.Show();
			//return;
			#endregion
			this.Text += eventViewID;
            //tFlightNo.Text = dt.Rows[0]["FlighNumber"].ToString();
            time = dt.Rows[0]["ExceedanceTime"].ToString();
			Date.Value = Convert.ToDateTime(dt.Rows[0]["EDate"]); //SQL will return "Date", made it date for access db that use "Date" as reserved word.

			lTime.Text = dt.Rows[0]["ExceedanceTime"].ToString();
			//int.TryParse(dt.Rows[0]["FileCounter"].ToString(), out counter);
			Counter.Text = dt.Rows[0]["FileCounter"].ToString();
			Gebeurtenis.Text = dt.Rows[0]["Description"].ToString();
			toa.Text = dt.Rows[0]["TakeOff"].ToString();
			tor.Text = dt.Rows[0]["TakeOffRunway"].ToString();
			takeOffTime.Text = dt.Rows[0]["TOTime"].ToString();
            landLughawe.Text = dt.Rows[0]["landing"].ToString();
			lr.Text = dt.Rows[0]["landRunway"].ToString();
            landingTime.Text = dt.Rows[0]["LandTime"].ToString();

            //MailSent.Checked = (bool)dt.Rows[0]["FeedbackSent"]; removed due not part og the access db.

            DateTime date = DateTime.Parse(dt.Rows[0]["TakeOffDate"].ToString());
			string reg = dt.Rows[0]["Registration"].ToString();
			if (reg.Length > 3)
            {
				reg = reg.Substring(reg.Length - 3, 3);
			}

			string fn = dt.Rows[0]["FlighNumber"].ToString();
			
			if (fn.Length > 3)
            {
				fn = fn.Substring(fn.Length - 3, 3);
            }
			tFlightNo.Text = fn;

            #region Comair spesifiec
   //         DataTable dtCrew = DataProsedures.LaaiBemaning(date
   //             , reg
   //             , fn);

   //         if (dtCrew.Rows.Count == 1)
   //         {
   //             captain.Text = dtCrew.Rows[0]["PilotName"].ToString();
			//	cMailAddress = dtCrew.Rows[0]["PilotEmail"].ToString();
			//	captainMail.Text = cMailAddress;
			//	firstOfficer.Text = dtCrew.Rows[0]["FirstOfficerName"].ToString();
			//	foMailAddress = dtCrew.Rows[0]["FirstOfficerEmail"].ToString();
			//	foMail.Text = foMailAddress;
			//}
   //         else
   //         {
   //             captain.Text = "No Crew " + dtCrew.Rows.Count;
			//	cMailAddress = "";
   //             firstOfficer.Text = "No Crew " + dtCrew.Rows.Count;
			//	foMailAddress = "";
   //         }

			//if (cMailAddress.Length < 10 || foMailAddress.Length < 10)
   //         {
			//	Mail.Enabled = false;
   //         }
            #endregion

			//tViewID + " | " + excDate.ToString("dd MMM yy") + " | " + flightNumber + " | " + Gebeurtenis.Text;
			//}
			
			#region load combo boxes
			

			if (Int32.TryParse(dt.Rows[0]["CauseId"].ToString(), out int CauseID))
			{
				cCause.SelectedValue = CauseID;
			}
			else
			{
				cCause.SelectedValue = 1;
			}

			if (Int32.TryParse(dt.Rows[0]["FlightPhaseId"].ToString(), out int PhaseID))
			{
				cFlightPhase.SelectedValue = PhaseID;
			}
			else
			{
				cFlightPhase.SelectedValue = 1;
			}

			if (Int32.TryParse(dt.Rows[0]["SeverityId"].ToString(), out int SeverityID))
			{
				cSeverity.SelectedValue = SeverityID;
			}
			else
			{
				cSeverity.SelectedValue = 1;
			}

			if (Int32.TryParse(dt.Rows[0]["scopeId"].ToString(), out int scopeID))
			{
				Scope.SelectedValue = scopeID;
			}
			else
			{
				Scope.SelectedValue = 1;
			}
			#endregion

			note.Text = dt.Rows[0]["ENote"].ToString(); // Changed from "Note" to "ENote to accomodate MSACCESS db.
			chkClosed.Checked = (bool)dt.Rows[0]["Closed"];

			#region lookup runway

			try
			{
				// TODO : Laai die runway wat van die log file kom.
				//fData.DataProc.loadApRyByCounterLerNaam(fileName, counter, out vlug.olh, out vlug.oBaan, out vlug.oKoers, out vlug.llh, out vlug.lBaan, out vlug.lKoers);

				//takeOffRWY.Text = vlug.olh + " " + vlug.oBaan + " "  + vlug.oKoers.ToString();
                //landRWY.Text = vlug.llh + " " + vlug.lBaan + " " + vlug.lKoers.ToString();
            }
			catch 
			{
				//takeOffAp.Text = "";
				//takeOffRWY.Text = "";
				//landAirport.Text = "";
				//landRWY.Text = "";
			}

			#endregion

			#region load pilot report
			if (FdmDataConnections.SQL)
			{
                richTextBox1.Text = LoadPilotReport(Date.Value.Date, dt.Rows[0]["Registration"].ToString(), tFlightNo.Text = dt.Rows[0]["FlighNumber"].ToString());
            }
			
			#endregion

		}

        public static string LoadPilotReport(DateTime dateTime, string registration, string flightNumber)
		{
			return null;
			if (!FdmDataConnections.SQL)
			{
				return "This database does not support auto loaded pilot reports.";
			}	
			DataTable dt = new DataTable();

			if (flightNumber.Length >= 3)
			{
				flightNumber = flightNumber.Substring(flightNumber.Length - 3);
			}

			if (registration.Length >= 3)
			{
				registration = registration.Substring(registration.Length - 3);
			}

			try
			{
				FdmDataConnections.sqlCompanyDataBaseConnection.Open();

				SqlCommand cmd = new SqlCommand("SELECT [Id],[Closed],[CSV],[Note] FROM [formCSV] WHERE [CSV] Like '%" + dateTime.ToString("yyyy-MM-dd") + "%' and [CSV] LIKE '%" + registration + "%' and [CSV] LIKE '%" + flightNumber + "%'", FdmDataConnections.sqlCompanyDataBaseConnection);

				SqlDataAdapter da = new SqlDataAdapter(cmd);

				da.Fill(dt);

				if (dt.Rows.Count == 1)
                {
					string pilotReport = dt.Rows[0]["CSV"].ToString();
					string cleanString = pilotReport.Replace(@"""", " ");
					cleanString = cleanString.Replace(":", " ");
					cleanString = cleanString.Remove(0, 28);
					return cleanString;
					
				}

				return "No report";

			}
			catch (Exception x)
			{
				MessageBox.Show(x.ToString(), "Searching for pilot reports.", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			finally
			{
				//AppData.FOQAsqlConnection.Close();
				FdmDataConnections.sqlCompanyDataBaseConnection.Close();
			}
		}

		private void toepModus()
		{
			if (appSettings.Mode.ToLower() == "demo".ToLower())
			{
				Date.Visible = false;
				tFlightNo.Visible = false;
				captain.Visible = false;
				captainMail.Visible = false;
				firstOfficer.Visible = false;
				foMail.Visible = false;
			}
			else if (appSettings.Mode.ToLower() == "dev")
			{
				this.Text = eventViewID.ToString();
			}
			else if (appSettings.Mode.ToLower() == "user" || !FdmDataConnections.SQL)
            {
				captain.Visible = false;
				captainMail.Visible = false;
				firstOfficer.Visible = false;
				foMail.Visible = false;
            }
			
		}

        private void Mail_Click(object sender, EventArgs e)
        {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Dear crew");
			sb.AppendLine("");
			sb.AppendLine("Your flight " + tFlightNo.Text + " on " + Date.Value.ToString("dd MMM yyyy") + " raised an event " + "'" + Gebeurtenis.Text + "'");

			if (Gebeurtenis.Text.Contains("Cooldown"))
            {
				sb.AppendLine("");
				sb.AppendLine("A reminder that a minimum of 3 minute cool down period is required before engine shut down. Refer GPN 6 (vs2)");
            }

			if (PosBoodskap.Lines.Length > 0)
            {
				for (int i = 0;i < PosBoodskap.Lines.Length; i++)
                {
					if (i == 0)
                    {
						note.AppendText(Environment.NewLine);
						sb.AppendLine("");
						note.AppendText("Note added to standard mail.");

					}
					note.AppendText( Environment.NewLine + PosBoodskap.Lines[i]);
					sb.AppendLine(PosBoodskap.Lines[i]);
					
                }
			}

			sb.AppendLine("");
			sb.AppendLine("Regards");
			sb.AppendLine("FDA Team");

			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Port = 587;
			smtpClient.Host = "smtp.office365.com";
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtpClient.EnableSsl = true;
			smtpClient.UseDefaultCredentials = false;
			smtpClient.Credentials = new NetworkCredential("foqa@comair.co.za","Comair@1", "comair.co.za");
			smtpClient.Timeout = 500000;

			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress("foqa@comair.co.za");
			mailMessage.To.Add(cMailAddress);
			mailMessage.To.Add(foMailAddress);
			mailMessage.Subject = "FDA event triggered.";
			mailMessage.Body = sb.ToString();
				
				

			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			try
            {
				Cursor.Current = Cursors.WaitCursor;
				smtpClient.Send(mailMessage);
				MailSent.Checked = true;
				Cursor.Current = Cursors.Default;
				
			}
            catch (Exception ex) 
			{
				MailSent.Checked = false;
				MessageBox.Show(ex.Message, "Mail send");
				
			}
		}

        private void eventView_FormClosing(object sender, FormClosingEventArgs e)
        {
			Cursor.Current = Cursors.WaitCursor;
			// TODO create write for this.
			// This is used to save the record

			if (moenieSkryfNie)
            {
				return;
            }

		

			if (int.TryParse(cFlightPhase.SelectedValue.ToString(), out int FlightPhaseValue))
			{
				if (FlightPhaseValue == 0) FlightPhaseValue = 1;
			}
			else
			{
				FlightPhaseValue = 1;
			}

			if (int.TryParse(cCause.SelectedValue.ToString(), out int CauseValue))
			{
				if (CauseValue == 0) CauseValue = 1;

			}
			else
			{
				CauseValue = 1;
			}

			if (int.TryParse(cSeverity.SelectedValue.ToString(), out int SeverityValue))
			{
				if (SeverityValue == 0) SeverityValue = 1;
			}
			else
			{
				SeverityValue = 1;
			}

			if (int.TryParse(Scope.SelectedValue.ToString(), out int scopeWaarde))
			{
				if (scopeWaarde == 0) scopeWaarde = 1;
			}
			else
			{
				scopeWaarde = 1;
			}

			double Counter;
			if (double.TryParse(this.Counter.Text, out Counter) == false)
			{
				MessageBox.Show("Evet details not saved. The counter could not be parsed.", " FDA Error updating event.", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				DataProsedures.GebeurtenisOpdateer(eventViewID
					, 0//Airport
					, 0//RunwayValue
					, FlightPhaseValue
					, SeverityValue
					, CauseValue
					, tFlightNo.Text
					, Gebeurtenis.Text
					, Counter
					, Date.Value
					, chkClosed.Checked
					, MailSent.Checked
					, note.Text
					, scopeWaarde
					, time);

				frmMainFOQA.reloadDataGridNeeded = true;
			}
			catch (Exception xx)
			{
				MessageBox.Show("Evet details not saved. " + xx.Message, " FDA Error updating event.", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

        private void Cancel_Click(object sender, EventArgs e)
        {

			if (MessageBox.Show("Close window without saving changes?", "Flight View", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				moenieSkryfNie = true;
				this.Close();
			}
			

        }

        
    }
   
}
