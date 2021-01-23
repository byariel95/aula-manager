
namespace aula.management.UI
{
    partial class TeacherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.cmbgender = new MetroFramework.Controls.MetroComboBox();
            this.txtlastname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.btnsave = new MetroFramework.Controls.MetroButton();
            this.btnedit = new MetroFramework.Controls.MetroButton();
            this.btndelete = new MetroFramework.Controls.MetroButton();
            this.ids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.CustomButton.Image = null;
            this.txtname.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.txtname.CustomButton.Name = "";
            this.txtname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtname.CustomButton.TabIndex = 1;
            this.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtname.CustomButton.UseSelectable = true;
            this.txtname.CustomButton.Visible = false;
            this.txtname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(62, 116);
            this.txtname.MaxLength = 32767;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PromptText = "Jose Miguel";
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.ShortcutsEnabled = true;
            this.txtname.Size = new System.Drawing.Size(306, 23);
            this.txtname.Style = MetroFramework.MetroColorStyle.Green;
            this.txtname.TabIndex = 0;
            this.txtname.UseSelectable = true;
            this.txtname.UseStyleColors = true;
            this.txtname.WaterMark = "Jose Miguel";
            this.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.ItemHeight = 24;
            this.cmbgender.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Indefinido"});
            this.cmbgender.Location = new System.Drawing.Point(62, 179);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(306, 30);
            this.cmbgender.Style = MetroFramework.MetroColorStyle.Green;
            this.cmbgender.TabIndex = 1;
            this.cmbgender.UseSelectable = true;
            this.cmbgender.UseStyleColors = true;
            // 
            // txtlastname
            // 
            // 
            // 
            // 
            this.txtlastname.CustomButton.Image = null;
            this.txtlastname.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.txtlastname.CustomButton.Name = "";
            this.txtlastname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtlastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtlastname.CustomButton.TabIndex = 1;
            this.txtlastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtlastname.CustomButton.UseSelectable = true;
            this.txtlastname.CustomButton.Visible = false;
            this.txtlastname.Lines = new string[0];
            this.txtlastname.Location = new System.Drawing.Point(388, 116);
            this.txtlastname.MaxLength = 32767;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.PasswordChar = '\0';
            this.txtlastname.PromptText = "Perez Arreaga";
            this.txtlastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtlastname.SelectedText = "";
            this.txtlastname.SelectionLength = 0;
            this.txtlastname.SelectionStart = 0;
            this.txtlastname.ShortcutsEnabled = true;
            this.txtlastname.Size = new System.Drawing.Size(306, 23);
            this.txtlastname.Style = MetroFramework.MetroColorStyle.Green;
            this.txtlastname.TabIndex = 2;
            this.txtlastname.UseSelectable = true;
            this.txtlastname.UseStyleColors = true;
            this.txtlastname.WaterMark = "Perez Arreaga";
            this.txtlastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtlastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nombres";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(388, 91);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Apellidos";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(62, 156);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 20);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Genero";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ids,
            this.nombre,
            this.apellido,
            this.generos});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(62, 243);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(632, 168);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroGrid1.TabIndex = 6;
            this.metroGrid1.UseStyleColors = true;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(62, 456);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(124, 45);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseSelectable = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(312, 456);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(124, 45);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "Editar";
            this.btnedit.UseSelectable = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(570, 456);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(124, 45);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseSelectable = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // ids
            // 
            this.ids.DataPropertyName = "Id";
            this.ids.HeaderText = "Codigo";
            this.ids.MinimumWidth = 6;
            this.ids.Name = "ids";
            this.ids.ReadOnly = true;
            this.ids.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Name";
            this.nombre.HeaderText = "Nombres";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "LastName";
            this.apellido.HeaderText = "Apellidos";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 125;
            // 
            // generos
            // 
            this.generos.DataPropertyName = "Gender";
            this.generos.HeaderText = "Genero";
            this.generos.MinimumWidth = 6;
            this.generos.Name = "generos";
            this.generos.ReadOnly = true;
            this.generos.Width = 125;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 536);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.txtname);
            this.Name = "TeacherForm";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtname;
        private MetroFramework.Controls.MetroComboBox cmbgender;
        private MetroFramework.Controls.MetroTextBox txtlastname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnsave;
        private MetroFramework.Controls.MetroButton btnedit;
        private MetroFramework.Controls.MetroButton btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ids;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn generos;
    }
}