namespace Crack_IT_System.Views {
	partial class FormMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			statusStrip1 = new StatusStrip();
			panelMenu = new Panel();
			panelElectricity = new Panel();
			btnDocumentsToPrint = new Button();
			btnIndicator = new Button();
			btnInsulation = new Button();
			btnElectricity = new Button();
			panelGraphic = new Panel();
			btnCorespondency = new Button();
			btnInsertFileToPdf = new Button();
			btnNumerator = new Button();
			btnGraphic = new Button();
			panelLogo = new Panel();
			btnMenu = new Button();
			panelTitleBar = new Panel();
			btnClose = new Button();
			btnMaximize = new Button();
			btnMinimize = new Button();
			lblDateTime = new Label();
			lblChildFormTitle = new Label();
			panelDesktop = new Panel();
			panelMenu.SuspendLayout();
			panelElectricity.SuspendLayout();
			panelGraphic.SuspendLayout();
			panelLogo.SuspendLayout();
			panelTitleBar.SuspendLayout();
			SuspendLayout();
			// 
			// statusStrip1
			// 
			statusStrip1.ImageScalingSize = new Size(20, 20);
			statusStrip1.Location = new Point(0, 570);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(800, 22);
			statusStrip1.TabIndex = 0;
			statusStrip1.Text = "statusStrip1";
			// 
			// panelMenu
			// 
			panelMenu.Controls.Add(panelElectricity);
			panelMenu.Controls.Add(btnElectricity);
			panelMenu.Controls.Add(panelGraphic);
			panelMenu.Controls.Add(btnGraphic);
			panelMenu.Controls.Add(panelLogo);
			panelMenu.Dock = DockStyle.Left;
			panelMenu.Location = new Point(0, 0);
			panelMenu.Name = "panelMenu";
			panelMenu.Size = new Size(250, 570);
			panelMenu.TabIndex = 1;
			// 
			// panelElectricity
			// 
			panelElectricity.Controls.Add(btnDocumentsToPrint);
			panelElectricity.Controls.Add(btnIndicator);
			panelElectricity.Controls.Add(btnInsulation);
			panelElectricity.Dock = DockStyle.Top;
			panelElectricity.Location = new Point(0, 340);
			panelElectricity.Name = "panelElectricity";
			panelElectricity.Size = new Size(250, 150);
			panelElectricity.TabIndex = 6;
			// 
			// btnDocumentsToPrint
			// 
			btnDocumentsToPrint.Dock = DockStyle.Top;
			btnDocumentsToPrint.FlatAppearance.BorderSize = 0;
			btnDocumentsToPrint.FlatAppearance.MouseOverBackColor = Color.IndianRed;
			btnDocumentsToPrint.FlatStyle = FlatStyle.Flat;
			btnDocumentsToPrint.Font = new Font("Segoe UI", 9F);
			btnDocumentsToPrint.Location = new Point(0, 100);
			btnDocumentsToPrint.Name = "btnDocumentsToPrint";
			btnDocumentsToPrint.Padding = new Padding(60, 0, 0, 0);
			btnDocumentsToPrint.Size = new Size(250, 50);
			btnDocumentsToPrint.TabIndex = 6;
			btnDocumentsToPrint.Text = "Dokumenty do druku";
			btnDocumentsToPrint.TextAlign = ContentAlignment.MiddleLeft;
			btnDocumentsToPrint.UseVisualStyleBackColor = true;
			btnDocumentsToPrint.Click += btnDocumentsToPrint_Click;
			// 
			// btnIndicator
			// 
			btnIndicator.Dock = DockStyle.Top;
			btnIndicator.FlatAppearance.BorderSize = 0;
			btnIndicator.FlatAppearance.MouseOverBackColor = Color.IndianRed;
			btnIndicator.FlatStyle = FlatStyle.Flat;
			btnIndicator.Font = new Font("Segoe UI", 9F);
			btnIndicator.Location = new Point(0, 50);
			btnIndicator.Name = "btnIndicator";
			btnIndicator.Padding = new Padding(60, 0, 0, 0);
			btnIndicator.Size = new Size(250, 50);
			btnIndicator.TabIndex = 5;
			btnIndicator.Text = "Badanie urządzeń zabezpieczonych wyłącznikiem różnicowo-prądowym";
			btnIndicator.TextAlign = ContentAlignment.MiddleLeft;
			btnIndicator.UseVisualStyleBackColor = true;
			btnIndicator.Click += btnIndicator_Click;
			// 
			// btnInsulation
			// 
			btnInsulation.Dock = DockStyle.Top;
			btnInsulation.FlatAppearance.BorderSize = 0;
			btnInsulation.FlatAppearance.MouseOverBackColor = Color.IndianRed;
			btnInsulation.FlatStyle = FlatStyle.Flat;
			btnInsulation.Font = new Font("Segoe UI", 9F);
			btnInsulation.Location = new Point(0, 0);
			btnInsulation.Name = "btnInsulation";
			btnInsulation.Padding = new Padding(60, 0, 0, 0);
			btnInsulation.Size = new Size(250, 50);
			btnInsulation.TabIndex = 4;
			btnInsulation.Text = "Pomiar rezystancji izolacji kabli i przewodów";
			btnInsulation.TextAlign = ContentAlignment.MiddleLeft;
			btnInsulation.UseVisualStyleBackColor = true;
			btnInsulation.Click += btnInsulation_Click;
			// 
			// btnElectricity
			// 
			btnElectricity.Dock = DockStyle.Top;
			btnElectricity.FlatAppearance.BorderSize = 0;
			btnElectricity.FlatAppearance.MouseOverBackColor = Color.IndianRed;
			btnElectricity.FlatStyle = FlatStyle.Flat;
			btnElectricity.Font = new Font("Segoe UI", 9F);
			btnElectricity.Location = new Point(0, 290);
			btnElectricity.Name = "btnElectricity";
			btnElectricity.Padding = new Padding(40, 0, 0, 0);
			btnElectricity.Size = new Size(250, 50);
			btnElectricity.TabIndex = 5;
			btnElectricity.Text = "Pomiary elektryczne";
			btnElectricity.TextAlign = ContentAlignment.MiddleLeft;
			btnElectricity.UseVisualStyleBackColor = true;
			btnElectricity.Click += btnElectricity_Click;
			// 
			// panelGraphic
			// 
			panelGraphic.Controls.Add(btnCorespondency);
			panelGraphic.Controls.Add(btnInsertFileToPdf);
			panelGraphic.Controls.Add(btnNumerator);
			panelGraphic.Dock = DockStyle.Top;
			panelGraphic.Location = new Point(0, 140);
			panelGraphic.Name = "panelGraphic";
			panelGraphic.Size = new Size(250, 150);
			panelGraphic.TabIndex = 4;
			// 
			// btnCorespondency
			// 
			btnCorespondency.Dock = DockStyle.Top;
			btnCorespondency.FlatAppearance.BorderSize = 0;
			btnCorespondency.FlatAppearance.MouseOverBackColor = Color.IndianRed;
			btnCorespondency.FlatStyle = FlatStyle.Flat;
			btnCorespondency.Font = new Font("Segoe UI", 9F);
			btnCorespondency.Location = new Point(0, 100);
			btnCorespondency.Name = "btnCorespondency";
			btnCorespondency.Padding = new Padding(60, 0, 0, 0);
			btnCorespondency.Size = new Size(250, 50);
			btnCorespondency.TabIndex = 6;
			btnCorespondency.Text = "Korespondencja seryjna";
			btnCorespondency.TextAlign = ContentAlignment.MiddleLeft;
			btnCorespondency.UseVisualStyleBackColor = true;
			// 
			// btnInsertFileToPdf
			// 
			btnInsertFileToPdf.Dock = DockStyle.Top;
			btnInsertFileToPdf.FlatAppearance.BorderSize = 0;
			btnInsertFileToPdf.FlatAppearance.MouseOverBackColor = Color.IndianRed;
			btnInsertFileToPdf.FlatStyle = FlatStyle.Flat;
			btnInsertFileToPdf.Font = new Font("Segoe UI", 9F);
			btnInsertFileToPdf.Location = new Point(0, 50);
			btnInsertFileToPdf.Name = "btnInsertFileToPdf";
			btnInsertFileToPdf.Padding = new Padding(60, 0, 0, 0);
			btnInsertFileToPdf.Size = new Size(250, 50);
			btnInsertFileToPdf.TabIndex = 5;
			btnInsertFileToPdf.Text = "Wstaw plik do PDF";
			btnInsertFileToPdf.TextAlign = ContentAlignment.MiddleLeft;
			btnInsertFileToPdf.UseVisualStyleBackColor = true;
			// 
			// btnNumerator
			// 
			btnNumerator.Dock = DockStyle.Top;
			btnNumerator.FlatAppearance.BorderSize = 0;
			btnNumerator.FlatAppearance.MouseOverBackColor = Color.IndianRed;
			btnNumerator.FlatStyle = FlatStyle.Flat;
			btnNumerator.Font = new Font("Segoe UI", 9F);
			btnNumerator.Location = new Point(0, 0);
			btnNumerator.Name = "btnNumerator";
			btnNumerator.Padding = new Padding(60, 0, 0, 0);
			btnNumerator.Size = new Size(250, 50);
			btnNumerator.TabIndex = 4;
			btnNumerator.Text = "Numerator";
			btnNumerator.TextAlign = ContentAlignment.MiddleLeft;
			btnNumerator.UseVisualStyleBackColor = true;
			// 
			// btnGraphic
			// 
			btnGraphic.Dock = DockStyle.Top;
			btnGraphic.FlatAppearance.BorderSize = 0;
			btnGraphic.FlatAppearance.MouseOverBackColor = Color.IndianRed;
			btnGraphic.FlatStyle = FlatStyle.Flat;
			btnGraphic.Font = new Font("Segoe UI", 9F);
			btnGraphic.Location = new Point(0, 90);
			btnGraphic.Name = "btnGraphic";
			btnGraphic.Padding = new Padding(40, 0, 0, 0);
			btnGraphic.Size = new Size(250, 50);
			btnGraphic.TabIndex = 3;
			btnGraphic.Text = "Grafika i obróbka plików";
			btnGraphic.TextAlign = ContentAlignment.MiddleLeft;
			btnGraphic.UseVisualStyleBackColor = true;
			btnGraphic.Click += btnGraphic_Click;
			// 
			// panelLogo
			// 
			panelLogo.BorderStyle = BorderStyle.FixedSingle;
			panelLogo.Controls.Add(btnMenu);
			panelLogo.Dock = DockStyle.Top;
			panelLogo.Location = new Point(0, 0);
			panelLogo.Name = "panelLogo";
			panelLogo.Size = new Size(250, 90);
			panelLogo.TabIndex = 2;
			// 
			// btnMenu
			// 
			btnMenu.Dock = DockStyle.Right;
			btnMenu.FlatAppearance.BorderSize = 0;
			btnMenu.FlatAppearance.MouseOverBackColor = Color.IndianRed;
			btnMenu.FlatStyle = FlatStyle.Flat;
			btnMenu.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
			btnMenu.Location = new Point(180, 0);
			btnMenu.Name = "btnMenu";
			btnMenu.Size = new Size(68, 88);
			btnMenu.TabIndex = 0;
			btnMenu.Text = "≣";
			btnMenu.UseVisualStyleBackColor = true;
			btnMenu.Click += btnMenu_Click;
			// 
			// panelTitleBar
			// 
			panelTitleBar.Controls.Add(btnClose);
			panelTitleBar.Controls.Add(btnMaximize);
			panelTitleBar.Controls.Add(btnMinimize);
			panelTitleBar.Controls.Add(lblDateTime);
			panelTitleBar.Controls.Add(lblChildFormTitle);
			panelTitleBar.Dock = DockStyle.Top;
			panelTitleBar.Location = new Point(250, 0);
			panelTitleBar.Name = "panelTitleBar";
			panelTitleBar.Size = new Size(550, 90);
			panelTitleBar.TabIndex = 2;
			panelTitleBar.MouseDown += panelTitleBar_MouseDown;
			// 
			// btnClose
			// 
			btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatAppearance.MouseOverBackColor = Color.IndianRed;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.Location = new Point(520, 0);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(30, 30);
			btnClose.TabIndex = 4;
			btnClose.Text = "✕";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnMaximize
			// 
			btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnMaximize.FlatAppearance.BorderSize = 0;
			btnMaximize.FlatAppearance.MouseOverBackColor = Color.IndianRed;
			btnMaximize.FlatStyle = FlatStyle.Flat;
			btnMaximize.Location = new Point(490, 0);
			btnMaximize.Name = "btnMaximize";
			btnMaximize.Size = new Size(30, 30);
			btnMaximize.TabIndex = 3;
			btnMaximize.Text = "▢";
			btnMaximize.UseVisualStyleBackColor = true;
			btnMaximize.Click += btnMaximize_Click;
			// 
			// btnMinimize
			// 
			btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnMinimize.FlatAppearance.BorderSize = 0;
			btnMinimize.FlatAppearance.MouseOverBackColor = Color.IndianRed;
			btnMinimize.FlatStyle = FlatStyle.Flat;
			btnMinimize.Location = new Point(460, 0);
			btnMinimize.Name = "btnMinimize";
			btnMinimize.Size = new Size(30, 30);
			btnMinimize.TabIndex = 2;
			btnMinimize.Text = "—";
			btnMinimize.UseVisualStyleBackColor = true;
			btnMinimize.Click += btnMinimize_Click;
			// 
			// lblDateTime
			// 
			lblDateTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			lblDateTime.Location = new Point(380, 40);
			lblDateTime.Name = "lblDateTime";
			lblDateTime.Size = new Size(160, 40);
			lblDateTime.TabIndex = 1;
			lblDateTime.Text = "lblDateTime";
			lblDateTime.TextAlign = ContentAlignment.BottomRight;
			lblDateTime.MouseDown += lblDateTime_MouseDown;
			// 
			// lblChildFormTitle
			// 
			lblChildFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblChildFormTitle.AutoSize = true;
			lblChildFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
			lblChildFormTitle.Location = new Point(70, 22);
			lblChildFormTitle.Name = "lblChildFormTitle";
			lblChildFormTitle.Size = new Size(273, 46);
			lblChildFormTitle.TabIndex = 0;
			lblChildFormTitle.Text = "Crack-IT System";
			lblChildFormTitle.TextAlign = ContentAlignment.MiddleLeft;
			lblChildFormTitle.MouseDown += lblChildFormTitle_MouseDown;
			// 
			// panelDesktop
			// 
			panelDesktop.Dock = DockStyle.Fill;
			panelDesktop.Location = new Point(250, 90);
			panelDesktop.Name = "panelDesktop";
			panelDesktop.Size = new Size(550, 480);
			panelDesktop.TabIndex = 2;
			panelDesktop.ControlRemoved += panelDesktop_ControlRemoved;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(120F, 120F);
			AutoScaleMode = AutoScaleMode.Dpi;
			ClientSize = new Size(800, 592);
			Controls.Add(panelDesktop);
			Controls.Add(panelTitleBar);
			Controls.Add(panelMenu);
			Controls.Add(statusStrip1);
			Name = "FormMain";
			Text = "FormMain";
			FormClosing += FormMain_FormClosing;
			Load += FormMain_Load;
			Resize += FormMain_Resize;
			panelMenu.ResumeLayout(false);
			panelElectricity.ResumeLayout(false);
			panelGraphic.ResumeLayout(false);
			panelLogo.ResumeLayout(false);
			panelTitleBar.ResumeLayout(false);
			panelTitleBar.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private StatusStrip statusStrip1;
		private Panel panelMenu;
		private Panel panelLogo;
		private Panel panelTitleBar;
		private Panel panelDesktop;
		private Button btnMenu;
		private Panel panelElectricity;
		private Button btnElectricity;
		private Panel panelGraphic;
		private Button btnGraphic;
		private Label lblDateTime;
		private Label lblChildFormTitle;
		private Button btnDocumentsToPrint;
		private Button btnIndicator;
		private Button btnInsulation;
		private Button btnCorespondency;
		private Button btnInsertFileToPdf;
		private Button btnNumerator;
		private Button btnMinimize;
		private Button btnClose;
		private Button btnMaximize;
	}
}