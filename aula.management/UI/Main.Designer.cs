
namespace aula.management
{
    partial class Main
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
            this.Teacherbtn = new MetroFramework.Controls.MetroTile();
            this.Studentbtn = new MetroFramework.Controls.MetroTile();
            this.Gradebtn = new MetroFramework.Controls.MetroTile();
            this.Assignmentbtn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Teacherbtn
            // 
            this.Teacherbtn.ActiveControl = null;
            this.Teacherbtn.Location = new System.Drawing.Point(193, 142);
            this.Teacherbtn.Name = "Teacherbtn";
            this.Teacherbtn.Size = new System.Drawing.Size(248, 145);
            this.Teacherbtn.Style = MetroFramework.MetroColorStyle.Lime;
            this.Teacherbtn.TabIndex = 0;
            this.Teacherbtn.Text = "Profesores";
            this.Teacherbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Teacherbtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Teacherbtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Teacherbtn.UseSelectable = true;
            this.Teacherbtn.Click += new System.EventHandler(this.Teacherbtn_Click);
            // 
            // Studentbtn
            // 
            this.Studentbtn.ActiveControl = null;
            this.Studentbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Studentbtn.Location = new System.Drawing.Point(556, 142);
            this.Studentbtn.Name = "Studentbtn";
            this.Studentbtn.Size = new System.Drawing.Size(232, 145);
            this.Studentbtn.Style = MetroFramework.MetroColorStyle.Teal;
            this.Studentbtn.TabIndex = 1;
            this.Studentbtn.Text = "Estudiantes";
            this.Studentbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Studentbtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Studentbtn.UseSelectable = true;
            // 
            // Gradebtn
            // 
            this.Gradebtn.ActiveControl = null;
            this.Gradebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Gradebtn.Location = new System.Drawing.Point(193, 367);
            this.Gradebtn.Name = "Gradebtn";
            this.Gradebtn.Size = new System.Drawing.Size(248, 147);
            this.Gradebtn.TabIndex = 2;
            this.Gradebtn.Text = "Grados";
            this.Gradebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Gradebtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Gradebtn.UseSelectable = true;
            this.Gradebtn.Click += new System.EventHandler(this.Gradebtn_Click);
            // 
            // Assignmentbtn
            // 
            this.Assignmentbtn.ActiveControl = null;
            this.Assignmentbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Assignmentbtn.Location = new System.Drawing.Point(556, 367);
            this.Assignmentbtn.Name = "Assignmentbtn";
            this.Assignmentbtn.Size = new System.Drawing.Size(232, 147);
            this.Assignmentbtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Assignmentbtn.TabIndex = 3;
            this.Assignmentbtn.Text = "Asignaciones";
            this.Assignmentbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Assignmentbtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Assignmentbtn.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 602);
            this.Controls.Add(this.Assignmentbtn);
            this.Controls.Add(this.Gradebtn);
            this.Controls.Add(this.Studentbtn);
            this.Controls.Add(this.Teacherbtn);
            this.Name = "Main";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile Teacherbtn;
        private MetroFramework.Controls.MetroTile Studentbtn;
        private MetroFramework.Controls.MetroTile Gradebtn;
        private MetroFramework.Controls.MetroTile Assignmentbtn;
    }
}

