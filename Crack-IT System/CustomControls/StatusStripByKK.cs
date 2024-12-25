namespace Crack_IT_System.CustomControls {
	internal class StatusStripByKK : StatusStrip {
		protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);

			this.BackColor = Color.FromArgb(0, 0, 102);
		}
	}
}