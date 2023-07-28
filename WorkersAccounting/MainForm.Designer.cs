namespace WorkersAccounting
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.Workers = new System.Windows.Forms.TabPage();
			this.SearchWorkerTB = new System.Windows.Forms.TextBox();
			this.SearchLabel = new System.Windows.Forms.Label();
			this.DepartmentsCB = new System.Windows.Forms.ComboBox();
			this.DepartmentsLabel = new System.Windows.Forms.Label();
			this.CreateWorkerButton = new System.Windows.Forms.Button();
			this.WorkersGrid = new System.Windows.Forms.DataGridView();
			this.contextMenuStripWorkers = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DeleteWorker = new System.Windows.Forms.ToolStripMenuItem();
			this.Departments = new System.Windows.Forms.TabPage();
			this.SearchDepartmentTB = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.CreateDepartmentButton = new System.Windows.Forms.Button();
			this.DepartmentsGrid = new System.Windows.Forms.DataGridView();
			this.contextMenuStripDepartments = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DeleteDepartment = new System.Windows.Forms.ToolStripMenuItem();
			this.Statistics = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.StatisticsDepartmentCB = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PeriodCalendar = new System.Windows.Forms.MonthCalendar();
			this.ClearCalendar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.EmolyedLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.DismissedLabel = new System.Windows.Forms.Label();
			this.ImportButton = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.Workers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WorkersGrid)).BeginInit();
			this.contextMenuStripWorkers.SuspendLayout();
			this.Departments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DepartmentsGrid)).BeginInit();
			this.contextMenuStripDepartments.SuspendLayout();
			this.Statistics.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.Workers);
			this.tabControl.Controls.Add(this.Departments);
			this.tabControl.Controls.Add(this.Statistics);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1455, 731);
			this.tabControl.TabIndex = 0;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// Workers
			// 
			this.Workers.Controls.Add(this.ImportButton);
			this.Workers.Controls.Add(this.SearchWorkerTB);
			this.Workers.Controls.Add(this.SearchLabel);
			this.Workers.Controls.Add(this.DepartmentsCB);
			this.Workers.Controls.Add(this.DepartmentsLabel);
			this.Workers.Controls.Add(this.CreateWorkerButton);
			this.Workers.Controls.Add(this.WorkersGrid);
			this.Workers.Location = new System.Drawing.Point(4, 25);
			this.Workers.Name = "Workers";
			this.Workers.Padding = new System.Windows.Forms.Padding(3);
			this.Workers.Size = new System.Drawing.Size(1447, 702);
			this.Workers.TabIndex = 0;
			this.Workers.Text = "Сотрудники";
			this.Workers.UseVisualStyleBackColor = true;
			// 
			// SearchWorkerTB
			// 
			this.SearchWorkerTB.Location = new System.Drawing.Point(1220, 8);
			this.SearchWorkerTB.Name = "SearchWorkerTB";
			this.SearchWorkerTB.Size = new System.Drawing.Size(221, 22);
			this.SearchWorkerTB.TabIndex = 5;
			this.SearchWorkerTB.TextChanged += new System.EventHandler(this.SearchWorkerTB_TextChanged);
			// 
			// SearchLabel
			// 
			this.SearchLabel.AutoSize = true;
			this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.SearchLabel.Location = new System.Drawing.Point(1158, 10);
			this.SearchLabel.Name = "SearchLabel";
			this.SearchLabel.Size = new System.Drawing.Size(56, 18);
			this.SearchLabel.TabIndex = 4;
			this.SearchLabel.Text = "Поиск:";
			// 
			// DepartmentsCB
			// 
			this.DepartmentsCB.FormattingEnabled = true;
			this.DepartmentsCB.Location = new System.Drawing.Point(641, 8);
			this.DepartmentsCB.Name = "DepartmentsCB";
			this.DepartmentsCB.Size = new System.Drawing.Size(221, 24);
			this.DepartmentsCB.TabIndex = 3;
			this.DepartmentsCB.SelectedIndexChanged += new System.EventHandler(this.DepartmentsCB_SelectedIndexChanged);
			// 
			// DepartmentsLabel
			// 
			this.DepartmentsLabel.AutoSize = true;
			this.DepartmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.DepartmentsLabel.Location = new System.Drawing.Point(512, 10);
			this.DepartmentsLabel.Name = "DepartmentsLabel";
			this.DepartmentsLabel.Size = new System.Drawing.Size(123, 18);
			this.DepartmentsLabel.TabIndex = 2;
			this.DepartmentsLabel.Text = "Подразделение:";
			// 
			// CreateWorkerButton
			// 
			this.CreateWorkerButton.Location = new System.Drawing.Point(6, 6);
			this.CreateWorkerButton.Name = "CreateWorkerButton";
			this.CreateWorkerButton.Size = new System.Drawing.Size(98, 27);
			this.CreateWorkerButton.TabIndex = 1;
			this.CreateWorkerButton.Text = "Создать";
			this.CreateWorkerButton.UseVisualStyleBackColor = true;
			this.CreateWorkerButton.Click += new System.EventHandler(this.CreateWorkerButton_Click);
			// 
			// WorkersGrid
			// 
			this.WorkersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.WorkersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.WorkersGrid.ContextMenuStrip = this.contextMenuStripWorkers;
			this.WorkersGrid.Location = new System.Drawing.Point(6, 39);
			this.WorkersGrid.MultiSelect = false;
			this.WorkersGrid.Name = "WorkersGrid";
			this.WorkersGrid.ReadOnly = true;
			this.WorkersGrid.RowHeadersWidth = 51;
			this.WorkersGrid.RowTemplate.Height = 24;
			this.WorkersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.WorkersGrid.Size = new System.Drawing.Size(1435, 657);
			this.WorkersGrid.TabIndex = 0;
			// 
			// contextMenuStripWorkers
			// 
			this.contextMenuStripWorkers.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStripWorkers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteWorker});
			this.contextMenuStripWorkers.Name = "contextMenuStrip1";
			this.contextMenuStripWorkers.Size = new System.Drawing.Size(135, 28);
			// 
			// DeleteWorker
			// 
			this.DeleteWorker.Name = "DeleteWorker";
			this.DeleteWorker.Size = new System.Drawing.Size(134, 24);
			this.DeleteWorker.Text = "Удалить";
			this.DeleteWorker.Click += new System.EventHandler(this.DeleteWorker_Click);
			// 
			// Departments
			// 
			this.Departments.Controls.Add(this.SearchDepartmentTB);
			this.Departments.Controls.Add(this.label1);
			this.Departments.Controls.Add(this.CreateDepartmentButton);
			this.Departments.Controls.Add(this.DepartmentsGrid);
			this.Departments.Location = new System.Drawing.Point(4, 25);
			this.Departments.Name = "Departments";
			this.Departments.Padding = new System.Windows.Forms.Padding(3);
			this.Departments.Size = new System.Drawing.Size(1447, 702);
			this.Departments.TabIndex = 1;
			this.Departments.Text = "Подразделения";
			this.Departments.UseVisualStyleBackColor = true;
			// 
			// SearchDepartmentTB
			// 
			this.SearchDepartmentTB.Location = new System.Drawing.Point(1220, 8);
			this.SearchDepartmentTB.Name = "SearchDepartmentTB";
			this.SearchDepartmentTB.Size = new System.Drawing.Size(221, 22);
			this.SearchDepartmentTB.TabIndex = 7;
			this.SearchDepartmentTB.TextChanged += new System.EventHandler(this.SearchDepartmentTB_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label1.Location = new System.Drawing.Point(1158, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 18);
			this.label1.TabIndex = 6;
			this.label1.Text = "Поиск:";
			// 
			// CreateDepartmentButton
			// 
			this.CreateDepartmentButton.Location = new System.Drawing.Point(6, 6);
			this.CreateDepartmentButton.Name = "CreateDepartmentButton";
			this.CreateDepartmentButton.Size = new System.Drawing.Size(98, 27);
			this.CreateDepartmentButton.TabIndex = 2;
			this.CreateDepartmentButton.Text = "Создать";
			this.CreateDepartmentButton.UseVisualStyleBackColor = true;
			this.CreateDepartmentButton.Click += new System.EventHandler(this.CreateDepartmentButton_Click);
			// 
			// DepartmentsGrid
			// 
			this.DepartmentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DepartmentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DepartmentsGrid.ContextMenuStrip = this.contextMenuStripDepartments;
			this.DepartmentsGrid.Location = new System.Drawing.Point(6, 39);
			this.DepartmentsGrid.MultiSelect = false;
			this.DepartmentsGrid.Name = "DepartmentsGrid";
			this.DepartmentsGrid.ReadOnly = true;
			this.DepartmentsGrid.RowHeadersWidth = 51;
			this.DepartmentsGrid.RowTemplate.Height = 24;
			this.DepartmentsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DepartmentsGrid.Size = new System.Drawing.Size(1435, 657);
			this.DepartmentsGrid.TabIndex = 1;
			// 
			// contextMenuStripDepartments
			// 
			this.contextMenuStripDepartments.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStripDepartments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteDepartment});
			this.contextMenuStripDepartments.Name = "contextMenuStrip1";
			this.contextMenuStripDepartments.Size = new System.Drawing.Size(135, 28);
			// 
			// DeleteDepartment
			// 
			this.DeleteDepartment.Name = "DeleteDepartment";
			this.DeleteDepartment.Size = new System.Drawing.Size(134, 24);
			this.DeleteDepartment.Text = "Удалить";
			this.DeleteDepartment.Click += new System.EventHandler(this.DeleteDepartment_Click);
			// 
			// Statistics
			// 
			this.Statistics.Controls.Add(this.DismissedLabel);
			this.Statistics.Controls.Add(this.label5);
			this.Statistics.Controls.Add(this.EmolyedLabel);
			this.Statistics.Controls.Add(this.label4);
			this.Statistics.Controls.Add(this.ClearCalendar);
			this.Statistics.Controls.Add(this.PeriodCalendar);
			this.Statistics.Controls.Add(this.label3);
			this.Statistics.Controls.Add(this.StatisticsDepartmentCB);
			this.Statistics.Controls.Add(this.label2);
			this.Statistics.Location = new System.Drawing.Point(4, 25);
			this.Statistics.Name = "Statistics";
			this.Statistics.Padding = new System.Windows.Forms.Padding(3);
			this.Statistics.Size = new System.Drawing.Size(1447, 702);
			this.Statistics.TabIndex = 2;
			this.Statistics.Text = "Статистика";
			this.Statistics.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label2.Location = new System.Drawing.Point(15, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Подразделение:";
			// 
			// StatisticsDepartmentCB
			// 
			this.StatisticsDepartmentCB.FormattingEnabled = true;
			this.StatisticsDepartmentCB.Location = new System.Drawing.Point(145, 16);
			this.StatisticsDepartmentCB.Name = "StatisticsDepartmentCB";
			this.StatisticsDepartmentCB.Size = new System.Drawing.Size(192, 24);
			this.StatisticsDepartmentCB.TabIndex = 1;
			this.StatisticsDepartmentCB.SelectedIndexChanged += new System.EventHandler(this.StatisticsDepartmentCB_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label3.Location = new System.Drawing.Point(68, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Период:";
			// 
			// PeriodCalendar
			// 
			this.PeriodCalendar.Location = new System.Drawing.Point(145, 52);
			this.PeriodCalendar.MaxSelectionCount = 2147483647;
			this.PeriodCalendar.Name = "PeriodCalendar";
			this.PeriodCalendar.TabIndex = 3;
			this.PeriodCalendar.Tag = "NoDate";
			this.PeriodCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.PeriodCalendar_DateChanged);
			// 
			// ClearCalendar
			// 
			this.ClearCalendar.Location = new System.Drawing.Point(145, 272);
			this.ClearCalendar.Name = "ClearCalendar";
			this.ClearCalendar.Size = new System.Drawing.Size(192, 28);
			this.ClearCalendar.TabIndex = 4;
			this.ClearCalendar.Text = "Сбросить календарь";
			this.ClearCalendar.UseVisualStyleBackColor = true;
			this.ClearCalendar.Click += new System.EventHandler(this.ClearCalendar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label4.Location = new System.Drawing.Point(374, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(202, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Устроено на работу:";
			// 
			// EmolyedLabel
			// 
			this.EmolyedLabel.AutoSize = true;
			this.EmolyedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.EmolyedLabel.Location = new System.Drawing.Point(582, 16);
			this.EmolyedLabel.Name = "EmolyedLabel";
			this.EmolyedLabel.Size = new System.Drawing.Size(0, 25);
			this.EmolyedLabel.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label5.Location = new System.Drawing.Point(480, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "Уволено:";
			// 
			// DismissedLabel
			// 
			this.DismissedLabel.AutoSize = true;
			this.DismissedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.DismissedLabel.Location = new System.Drawing.Point(582, 52);
			this.DismissedLabel.Name = "DismissedLabel";
			this.DismissedLabel.Size = new System.Drawing.Size(0, 25);
			this.DismissedLabel.TabIndex = 8;
			// 
			// ImportButton
			// 
			this.ImportButton.Location = new System.Drawing.Point(110, 6);
			this.ImportButton.Name = "ImportButton";
			this.ImportButton.Size = new System.Drawing.Size(98, 27);
			this.ImportButton.TabIndex = 6;
			this.ImportButton.Text = "Импорт";
			this.ImportButton.UseVisualStyleBackColor = true;
			this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1479, 755);
			this.Controls.Add(this.tabControl);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Учёт сотрудников";
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.tabControl.ResumeLayout(false);
			this.Workers.ResumeLayout(false);
			this.Workers.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.WorkersGrid)).EndInit();
			this.contextMenuStripWorkers.ResumeLayout(false);
			this.Departments.ResumeLayout(false);
			this.Departments.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DepartmentsGrid)).EndInit();
			this.contextMenuStripDepartments.ResumeLayout(false);
			this.Statistics.ResumeLayout(false);
			this.Statistics.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage Workers;
		private System.Windows.Forms.TabPage Departments;
		private System.Windows.Forms.TabPage Statistics;
		private System.Windows.Forms.DataGridView WorkersGrid;
		private System.Windows.Forms.Button CreateWorkerButton;
		private System.Windows.Forms.ComboBox DepartmentsCB;
		private System.Windows.Forms.Label DepartmentsLabel;
		private System.Windows.Forms.TextBox SearchWorkerTB;
		private System.Windows.Forms.Label SearchLabel;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripWorkers;
		private System.Windows.Forms.ToolStripMenuItem DeleteWorker;
		private System.Windows.Forms.DataGridView DepartmentsGrid;
		private System.Windows.Forms.Button CreateDepartmentButton;
		private System.Windows.Forms.TextBox SearchDepartmentTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripDepartments;
		private System.Windows.Forms.ToolStripMenuItem DeleteDepartment;
		private System.Windows.Forms.MonthCalendar PeriodCalendar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox StatisticsDepartmentCB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ClearCalendar;
		private System.Windows.Forms.Label DismissedLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label EmolyedLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button ImportButton;
	}
}

