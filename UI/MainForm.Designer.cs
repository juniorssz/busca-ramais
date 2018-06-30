namespace UI
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl_1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_contatos = new MetroFramework.Controls.MetroTabPage();
            this.grid_contatos = new MetroFramework.Controls.MetroGrid();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.tab_sobre = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tabControl_1.SuspendLayout();
            this.tab_contatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_contatos)).BeginInit();
            this.tab_sobre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_1
            // 
            this.tabControl_1.Controls.Add(this.tab_contatos);
            this.tabControl_1.Controls.Add(this.tab_sobre);
            this.tabControl_1.Location = new System.Drawing.Point(27, 74);
            this.tabControl_1.Name = "tabControl_1";
            this.tabControl_1.SelectedIndex = 0;
            this.tabControl_1.Size = new System.Drawing.Size(847, 503);
            this.tabControl_1.TabIndex = 3;
            this.tabControl_1.UseSelectable = true;
            // 
            // tab_contatos
            // 
            this.tab_contatos.Controls.Add(this.grid_contatos);
            this.tab_contatos.Controls.Add(this.txt_search);
            this.tab_contatos.HorizontalScrollbarBarColor = true;
            this.tab_contatos.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_contatos.HorizontalScrollbarSize = 10;
            this.tab_contatos.Location = new System.Drawing.Point(4, 38);
            this.tab_contatos.Name = "tab_contatos";
            this.tab_contatos.Size = new System.Drawing.Size(839, 461);
            this.tab_contatos.TabIndex = 0;
            this.tab_contatos.Text = "Contatos";
            this.tab_contatos.VerticalScrollbarBarColor = true;
            this.tab_contatos.VerticalScrollbarHighlightOnWheel = false;
            this.tab_contatos.VerticalScrollbarSize = 10;
            // 
            // grid_contatos
            // 
            this.grid_contatos.AllowUserToResizeRows = false;
            this.grid_contatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grid_contatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_contatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_contatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_contatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_contatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_contatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_contatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_contatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_contatos.EnableHeadersVisualStyles = false;
            this.grid_contatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_contatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_contatos.Location = new System.Drawing.Point(19, 85);
            this.grid_contatos.Name = "grid_contatos";
            this.grid_contatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_contatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_contatos.RowHeadersWidth = 20;
            this.grid_contatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_contatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid_contatos.Size = new System.Drawing.Size(800, 370);
            this.grid_contatos.TabIndex = 0;
            this.grid_contatos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_contatos_DataBindingComplete);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_search.CustomButton.Image = null;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(374, 1);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.CustomButton.Visible = false;
            this.txt_search.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(218, 32);
            this.txt_search.MaxLength = 32767;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(402, 29);
            this.txt_search.TabIndex = 1;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // tab_sobre
            // 
            this.tab_sobre.Controls.Add(this.metroLabel9);
            this.tab_sobre.Controls.Add(this.metroLabel8);
            this.tab_sobre.Controls.Add(this.metroLabel7);
            this.tab_sobre.Controls.Add(this.metroLabel1);
            this.tab_sobre.Controls.Add(this.metroLabel3);
            this.tab_sobre.Controls.Add(this.metroLabel2);
            this.tab_sobre.HorizontalScrollbarBarColor = true;
            this.tab_sobre.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_sobre.HorizontalScrollbarSize = 10;
            this.tab_sobre.Location = new System.Drawing.Point(4, 38);
            this.tab_sobre.Name = "tab_sobre";
            this.tab_sobre.Size = new System.Drawing.Size(839, 461);
            this.tab_sobre.TabIndex = 1;
            this.tab_sobre.Text = "Sobre";
            this.tab_sobre.VerticalScrollbarBarColor = true;
            this.tab_sobre.VerticalScrollbarHighlightOnWheel = false;
            this.tab_sobre.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(55, 424);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(52, 15);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "1.0 beta";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(4, 424);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(45, 15);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Versão:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(112, 441);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(109, 15);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "A. Júnior e D. Saad";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(4, 441);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 15);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Desenvolvido por:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(112, 115);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(614, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Encontre o contato desejado a partir de qualquer informação conhecida ou lembrada" +
    " no momento.";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(162, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(507, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "O Busca Ramais é um software de uso corporativo para busca rápida de contatos.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackMaxSize = 100;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tabControl_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "Busca Ramais";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl_1.ResumeLayout(false);
            this.tab_contatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_contatos)).EndInit();
            this.tab_sobre.ResumeLayout(false);
            this.tab_sobre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl_1;
        private MetroFramework.Controls.MetroTabPage tab_sobre;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTabPage tab_contatos;
        private MetroFramework.Controls.MetroGrid grid_contatos;
        private MetroFramework.Controls.MetroTextBox txt_search;
    }
}

