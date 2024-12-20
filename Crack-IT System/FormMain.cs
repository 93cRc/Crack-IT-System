using Crack_IT_System.Controller;
using System.Diagnostics;

namespace Crack_IT_System {
	public partial class FormMain : Form {
		private readonly ElectricityController _electricityController;

		public FormMain() {
			InitializeComponent();

			_electricityController = new();
		}

		private async void FormMain_Load(object sender, EventArgs e) {
			await _electricityController.LoadCities();
			await _electricityController.LoadCountries();
		}
	}
}