
namespace Parcial2_ap1_20180240.UI.Reguistro
{
    partial class rProyecto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rProyecto));
            this.BuscarButton = new System.Windows.Forms.Button();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProyectoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.RemoverFilaButton = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.TiempoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RequerimientosTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TipoTareaComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.TiempoTotalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoIdNumericUpDown)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(74, 26);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(82, 23);
            this.BuscarButton.TabIndex = 17;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(12, 111);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(568, 49);
            this.DescripcionTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripcion del Proyecto";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd / MM / yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(12, 68);
            this.FechaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(98, 23);
            this.FechaDateTimePicker.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Proyecto Id";
            // 
            // ProyectoIdNumericUpDown
            // 
            this.ProyectoIdNumericUpDown.Location = new System.Drawing.Point(12, 26);
            this.ProyectoIdNumericUpDown.Name = "ProyectoIdNumericUpDown";
            this.ProyectoIdNumericUpDown.Size = new System.Drawing.Size(56, 23);
            this.ProyectoIdNumericUpDown.TabIndex = 18;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.RemoverFilaButton);
            this.groupBox.Controls.Add(this.DataGridView);
            this.groupBox.Controls.Add(this.AgregarButton);
            this.groupBox.Controls.Add(this.TiempoTextBox);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.RequerimientosTextBox);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.TipoTareaComboBox);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Location = new System.Drawing.Point(12, 165);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(568, 288);
            this.groupBox.TabIndex = 19;
            this.groupBox.TabStop = false;
            // 
            // RemoverFilaButton
            // 
            this.RemoverFilaButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverFilaButton.Image")));
            this.RemoverFilaButton.Location = new System.Drawing.Point(6, 259);
            this.RemoverFilaButton.Name = "RemoverFilaButton";
            this.RemoverFilaButton.Size = new System.Drawing.Size(102, 27);
            this.RemoverFilaButton.TabIndex = 17;
            this.RemoverFilaButton.Text = "Remover Fila";
            this.RemoverFilaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoverFilaButton.UseVisualStyleBackColor = true;
            this.RemoverFilaButton.Click += new System.EventHandler(this.RemoverFilaButton_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(6, 66);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 25;
            this.DataGridView.Size = new System.Drawing.Size(556, 188);
            this.DataGridView.TabIndex = 16;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.Location = new System.Drawing.Point(483, 36);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(79, 24);
            this.AgregarButton.TabIndex = 15;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // TiempoTextBox
            // 
            this.TiempoTextBox.Location = new System.Drawing.Point(360, 37);
            this.TiempoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TiempoTextBox.Name = "TiempoTextBox";
            this.TiempoTextBox.Size = new System.Drawing.Size(115, 23);
            this.TiempoTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tiempo (Minutos)";
            // 
            // RequerimientosTextBox
            // 
            this.RequerimientosTextBox.Location = new System.Drawing.Point(114, 37);
            this.RequerimientosTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RequerimientosTextBox.Name = "RequerimientosTextBox";
            this.RequerimientosTextBox.Size = new System.Drawing.Size(240, 23);
            this.RequerimientosTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Requerimientos de la Tarea";
            // 
            // TipoTareaComboBox
            // 
            this.TipoTareaComboBox.FormattingEnabled = true;
            this.TipoTareaComboBox.Location = new System.Drawing.Point(6, 37);
            this.TipoTareaComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TipoTareaComboBox.Name = "TipoTareaComboBox";
            this.TipoTareaComboBox.Size = new System.Drawing.Size(102, 23);
            this.TipoTareaComboBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tipo de Tarea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Detalle de Tarea Realisada";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.Location = new System.Drawing.Point(199, 458);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(85, 33);
            this.EliminarButton.TabIndex = 22;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.Location = new System.Drawing.Point(18, 458);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(78, 33);
            this.NuevoButton.TabIndex = 0;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.Location = new System.Drawing.Point(102, 459);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(91, 32);
            this.GuardarButton.TabIndex = 21;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // TiempoTotalTextBox
            // 
            this.TiempoTotalTextBox.Location = new System.Drawing.Point(424, 458);
            this.TiempoTotalTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TiempoTotalTextBox.Name = "TiempoTotalTextBox";
            this.TiempoTotalTextBox.Size = new System.Drawing.Size(150, 23);
            this.TiempoTotalTextBox.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tiempo Total";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // rProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 509);
            this.Controls.Add(this.TiempoTotalTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.ProyectoIdNumericUpDown);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rProyecto";
            this.Text = "Registro de Proyecto";
            this.Load += new System.EventHandler(this.rProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoIdNumericUpDown)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ProyectoIdNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button RemoverFilaButton;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.TextBox TiempoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RequerimientosTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TipoTareaComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox TiempoTotalTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}