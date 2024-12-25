using Crack_IT_System.Controllers;
using Crack_IT_System.Views.Electricity;
using System.Runtime.InteropServices;
using System.Timers;

namespace Crack_IT_System.Views {
	public partial class FormMain : Form {
		#region Fields
		Button? currentButton;

		Form? activeForm;

		readonly int borderSize = 2;

		//readonly object[,] translator;

		Size formSize;

		readonly System.Timers.Timer timerDateTime = new() {
			Interval = 1000
		};

		readonly Panel[] submenusPanels;

		private readonly ElectricityController _electricityController;
		#endregion


		#region Constructors
		public FormMain() {
			InitializeComponent();

			_electricityController = new();

			Color color = SelectThemeColor();
			ThemeColor.PrimaryColor = color;
			panelLogo.BackColor = ThemeColor.PrimaryColor;
			panelTitleBar.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.5);
			panelMenu.BackColor = ThemeColor.PrimaryColor;
			panelDesktop.BackColor = Color.White;
			panelTitleBar.ForeColor = Color.White;
			panelMenu.ForeColor = Color.White;

			lblChildFormTitle.Text = "Crack-IT System";
			panelMenu.Width = 68;
			submenusPanels = [panelElectricity, panelGraphic];

			ControlBox = false;
			DoubleBuffered = true;
			MinimumSize = new Size(640, 480);
			Padding = new Padding(borderSize);
			Text = "Crack-IT System";
			WindowState = FormWindowState.Maximized;

			foreach (Panel pnl in submenusPanels) {
				pnl.Visible = false;
			}
		}
		#endregion


		#region DLL import
		[DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
		#endregion


		#region Overriden methods
		protected override void WndProc(ref Message m) {
			const int WM_NCCALCSIZE = 0x0083;//Standard Title Bar - Snap Window
			const int WM_SYSCOMMAND = 0x0112;
			const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
			const int SC_RESTORE = 0xF120; //Restore form (Before)
			const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
			const int resizeAreaSize = 10;

			#region Form Resize
			// Resize/WM_NCHITTEST values
			const int HTCLIENT = 1; //Represents the client area of the window
			const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
			const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
			const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
			const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
			const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
			const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
			const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
			const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
			///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
			if (m.Msg == WM_NCHITTEST) { //If the windows m is WM_NCHITTEST
				base.WndProc(ref m);
				if (WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
				{
					if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
					{
						Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
						Point clientPoint = PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
						if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
						{
							if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
								m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
							else if (clientPoint.X < (Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
								m.Result = (IntPtr)HTTOP; //Resize vertically up
							else //Resize diagonally to the right
								m.Result = (IntPtr)HTTOPRIGHT;
						}
						else if (clientPoint.Y <= (Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
						{
							if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
								m.Result = (IntPtr)HTLEFT;
							else if (clientPoint.X > (Width - resizeAreaSize))//Resize horizontally to the right
								m.Result = (IntPtr)HTRIGHT;
						}
						else {
							if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
								m.Result = (IntPtr)HTBOTTOMLEFT;
							else if (clientPoint.X < (Size.Width - resizeAreaSize)) //Resize vertically down
								m.Result = (IntPtr)HTBOTTOM;
							else //Resize diagonally to the right
								m.Result = (IntPtr)HTBOTTOMRIGHT;
						}
					}
				}
				return;
			}
			#endregion

			//Remove border and keep snap window
			if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) {
				return;
			}
			//Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
			if (m.Msg == WM_SYSCOMMAND) {
				/// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
				/// Quote:
				/// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
				/// are used internally by the system.To obtain the correct result when testing 
				/// the value of wParam, an application must combine the value 0xFFF0 with the 
				/// wParam value by using the bitwise AND operator.
				int wParam = (m.WParam.ToInt32() & 0xFFF0);
				if (wParam == SC_MINIMIZE)  //Before
					formSize = ClientSize;
				if (wParam == SC_RESTORE)// Restored form(Before)
					Size = formSize;
			}
			base.WndProc(ref m);
		}
		#endregion


		#region Methods
		private void ActivateButton(object btnSender) {
			if (btnSender != null) {
				if (currentButton != (Button)btnSender) {
					DeactivateButton();

					currentButton = (Button)btnSender;
					currentButton.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.5);
					currentButton.ForeColor = Color.White;
					currentButton.Font = new("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);

					panelLogo.BackColor = ThemeColor.PrimaryColor;
					panelTitleBar.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, -0.5);
					panelMenu.BackColor = ThemeColor.PrimaryColor;
					panelDesktop.BackColor = Color.White;
					panelTitleBar.ForeColor = Color.White;
					panelMenu.ForeColor = Color.White;
				}
			}
		}


		private void AdjustForm() {
			panelDesktop.Dock = DockStyle.Fill;

			switch (WindowState) {
				case FormWindowState.Maximized:
					Padding = new Padding(5, 5, 5, 5);
					break;
				case FormWindowState.Normal:
					if (Padding.Top != borderSize) {
						Padding = new Padding(borderSize);
					}
					break;
			}
		}


		private void DeactivateButton() {
			foreach (Control previousBtn in panelMenu.Controls) {
				if (previousBtn.GetType() == typeof(Button)) {
					previousBtn.BackColor = ThemeColor.PrimaryColor;
					previousBtn.ForeColor = Color.White;
					previousBtn.Font = new("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
				}
			}
		}


		public void OpenChildForm(Form childForm, object btnSender) {
			foreach (Control c in panelMenu.Controls) {
				if (c.GetType() == typeof(Panel) && c != panelLogo) { c.Visible = false; }
			}
			activeForm?.Close();
			activeForm?.Dispose();
			ActivateButton(btnSender);
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelDesktop.Controls.Add(childForm);
			panelDesktop.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			lblChildFormTitle.Text = childForm.Text;
		}


		private void ResetForm() {
			DeactivateButton();

			currentButton = null;
			lblChildFormTitle.Text = Text;
			//lblChildFormTitle.Text = "HOME";

			//Text = "HOME";

			foreach (Form f in panelDesktop.Controls.OfType<Form>()) { f.Dispose(); }
		}


		private Color SelectThemeColor() {
			string color = ThemeColor.DefaultHTMLColor;

			return ColorTranslator.FromHtml(color);
		}


		/*private void SetLanguage(string language) {
			if (language == "pl") {
				int i = 0;
				foreach (object obj in translator) {
					if (obj.GetType() == typeof(Button)) {
						Button btn = (Button)obj;
						btn.Text = translator[i, 1].ToString();
						i++;
					}
					if (obj.GetType() == typeof(Label)) {
						Label lbl = (Label)obj;
						lbl.Text = translator[i, 1].ToString();
						i++;
					}
				}
			}
			else if (language == "en") {
				int i = 0;
				foreach (object obj in translator) {
					if (obj.GetType() == typeof(Button)) {
						Button btn = (Button)obj;
						btn.Text = translator[i, 2].ToString();
						i++;
					}
					if (obj.GetType() == typeof(Label)) {
						Label lbl = (Label)obj;
						lbl.Text = translator[i, 2].ToString();
						i++;
					}
				}
			}
		}*/


		private void Timer_Elapsed(object? sender, ElapsedEventArgs e) {
			Invoke((MethodInvoker)delegate { lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss"); });
		}
		#endregion


		#region Events
		private async void FormMain_Load(object sender, EventArgs e) {
			timerDateTime.Elapsed += Timer_Elapsed;
			timerDateTime.Start();

			formSize = ClientSize;

			//lbAppName.Text = Config.AppName;
			//lbAppVersion.Text = Config.AppVersion;
			lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss");
			//picBoxLogo.Dock = DockStyle.Fill;

			//OpenChildForm(new FormOee(), btnOee);

			await Task.Delay(100); // do usunięcia
								   //await _electricityController.LoadCities();
								   //await _electricityController.LoadCountries();
		}


		private void btnMenu_Click(object sender, EventArgs e) {
			if (panelMenu.Width != btnMenu.Width) {
				panelMenu.Width = btnMenu.Width;
			}
			else {
				panelMenu.Width = 280;
			}
		}


		private void btnMinimize_Click(object sender, EventArgs e) {
			WindowState = FormWindowState.Minimized;
		}


		private void btnMaximize_Click(object sender, EventArgs e) {
			if (WindowState == FormWindowState.Normal) { WindowState = FormWindowState.Maximized; }
			else { WindowState = FormWindowState.Normal; }
		}


		private void btnClose_Click(object sender, EventArgs e) {
			activeForm?.Close();
			Application.Exit();
		}


		private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
			timerDateTime.Elapsed -= Timer_Elapsed;
			timerDateTime.Stop();
			timerDateTime.Dispose();
		}


		private void FormMain_Resize(object sender, EventArgs e) {
			AdjustForm();
		}


		private void lblDateTime_MouseDown(object sender, MouseEventArgs e) {
			ReleaseCapture();
			SendMessage(Handle, 0x112, 0xf012, 0);
		}


		private void lblChildFormTitle_MouseDown(object sender, MouseEventArgs e) {
			ReleaseCapture();
			SendMessage(Handle, 0x112, 0xf012, 0);
		}


		private void panelDesktop_ControlRemoved(object sender, ControlEventArgs e) {
			ResetForm();
		}


		private void panelTitleBar_DoubleClick(object sender, EventArgs e) {
			if (WindowState == FormWindowState.Normal) { WindowState = FormWindowState.Maximized; }
			else { WindowState = FormWindowState.Normal; }
		}


		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e) {
			ReleaseCapture();
			SendMessage(Handle, 0x112, 0xf012, 0);
		}


		private void btnElectricity_Click(object sender, EventArgs e) {
			OpenChildForm(new FormDocumentsToPrint(), sender);
			panelElectricity.Visible = true;
		}


		private void btnGraphic_Click(object sender, EventArgs e) {
			panelGraphic.Visible = true;
		}


		private void btnInsulation_Click(object sender, EventArgs e) {
			OpenChildForm(new FormInsulationResistanceCablesAndWires(), sender);
		}


		private void btnIndicator_Click(object sender, EventArgs e) {
			OpenChildForm(new FormTestingDevicesProtectedByRCD(), sender);
			_electricityController.LoadCities();
			_electricityController.LoadCountries();
		}


		private void btnDocumentsToPrint_Click(object sender, EventArgs e) {
			OpenChildForm(new FormDocumentsToPrint(), sender);
		}
		#endregion
	}
}