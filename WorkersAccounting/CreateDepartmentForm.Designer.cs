namespace WorkersAccounting
{
	partial class CreateDepartmentForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CreateButton = new System.Windows.Forms.Button();
			this.StatusCB = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.NameTB = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.HeadDepartmentCB = new System.Windows.Forms.ComboBox();
			this.DirectorCB = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// CreateButton
			// 
			this.CreateButton.Location = new System.Drawing.Point(304, 186);
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.Size = new System.Drawing.Size(83, 26);
			this.CreateButton.TabIndex = 38;
			this.CreateButton.Text = "Создать";
			this.CreateButton.UseVisualStyleBackColor = true;
			this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// StatusCB
			// 
			this.StatusCB.FormattingEnabled = true;
			this.StatusCB.Items.AddRange(new object[] {
            "Действующая",
            "Закрытая"});
			this.StatusCB.Location = new System.Drawing.Point(254, 136);
			this.StatusCB.Name = "StatusCB";
			this.StatusCB.Size = new System.Drawing.Size(230, 24);
			this.StatusCB.TabIndex = 35;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(118, 139);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(130, 16);
			this.label8.TabIndex = 34;
			this.label8.Text = "Состояние записи:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(144, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 16);
			this.label3.TabIndex = 24;
			this.label3.Text = "Руководитель:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(68, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 16);
			this.label2.TabIndex = 22;
			this.label2.Text = "Головное подразделение:";
			// 
			// NameTB
			// 
			this.NameTB.Location = new System.Drawing.Point(254, 50);
			this.NameTB.Name = "NameTB";
			this.NameTB.Size = new System.Drawing.Size(230, 22);
			this.NameTB.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(139, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 16);
			this.label1.TabIndex = 20;
			this.label1.Text = "Наименование:";
			// 
			// HeadDepartmentCB
			// 
			this.HeadDepartmentCB.FormattingEnabled = true;
			this.HeadDepartmentCB.Location = new System.Drawing.Point(254, 78);
			this.HeadDepartmentCB.Name = "HeadDepartmentCB";
			this.HeadDepartmentCB.Size = new System.Drawing.Size(230, 24);
			this.HeadDepartmentCB.TabIndex = 40;
			// 
			// DirectorCB
			// 
			this.DirectorCB.FormattingEnabled = true;
			this.DirectorCB.Items.AddRange(new object[] {
            "Действующая",
            "Закрытая"});
			this.DirectorCB.Location = new System.Drawing.Point(254, 106);
			this.DirectorCB.Name = "DirectorCB";
			this.DirectorCB.Size = new System.Drawing.Size(230, 24);
			this.DirectorCB.TabIndex = 41;
			// 
			// CreateDepartmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 263);
			this.Controls.Add(this.DirectorCB);
			this.Controls.Add(this.HeadDepartmentCB);
			this.Controls.Add(this.CreateButton);
			this.Controls.Add(this.StatusCB);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NameTB);
			this.Controls.Add(this.label1);
			this.Name = "CreateDepartmentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Создание подразделения";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button CreateButton;
		private System.Windows.Forms.ComboBox StatusCB;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox NameTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox HeadDepartmentCB;
		private System.Windows.Forms.ComboBox DirectorCB;
	}
}