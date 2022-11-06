namespace Vista
{
    partial class TicketsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.IdentidadClienteTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExistenciaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CodigoProductoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionProductoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.ISVTextBox = new System.Windows.Forms.TextBox();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaDateTimePicker);
            this.groupBox1.Controls.Add(this.UsuarioTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(959, 30);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(163, 31);
            this.FechaDateTimePicker.TabIndex = 3;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(102, 27);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(150, 31);
            this.UsuarioTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(896, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NombreClienteTextBox);
            this.groupBox2.Controls.Add(this.IdentidadClienteTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(19, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1146, 79);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(273, 33);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.ReadOnly = true;
            this.NombreClienteTextBox.Size = new System.Drawing.Size(241, 31);
            this.NombreClienteTextBox.TabIndex = 5;
            // 
            // IdentidadClienteTextBox
            // 
            this.IdentidadClienteTextBox.Location = new System.Drawing.Point(117, 33);
            this.IdentidadClienteTextBox.Mask = "####-####-#####";
            this.IdentidadClienteTextBox.Name = "IdentidadClienteTextBox";
            this.IdentidadClienteTextBox.Size = new System.Drawing.Size(150, 31);
            this.IdentidadClienteTextBox.TabIndex = 4;
            this.IdentidadClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadClienteTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Identidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ExistenciaTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.CantidadTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.CodigoProductoTextBox);
            this.groupBox3.Controls.Add(this.DescripcionProductoTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1146, 79);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Servicio";
            // 
            // ExistenciaTextBox
            // 
            this.ExistenciaTextBox.Location = new System.Drawing.Point(686, 36);
            this.ExistenciaTextBox.Name = "ExistenciaTextBox";
            this.ExistenciaTextBox.ReadOnly = true;
            this.ExistenciaTextBox.Size = new System.Drawing.Size(158, 31);
            this.ExistenciaTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(567, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Disponibilidad";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(979, 36);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(150, 31);
            this.CantidadTextBox.TabIndex = 8;
            this.CantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(889, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad";
            // 
            // CodigoProductoTextBox
            // 
            this.CodigoProductoTextBox.Location = new System.Drawing.Point(87, 31);
            this.CodigoProductoTextBox.Name = "CodigoProductoTextBox";
            this.CodigoProductoTextBox.Size = new System.Drawing.Size(150, 31);
            this.CodigoProductoTextBox.TabIndex = 6;
            this.CodigoProductoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoProductoTextBox_KeyPress);
            // 
            // DescripcionProductoTextBox
            // 
            this.DescripcionProductoTextBox.Location = new System.Drawing.Point(273, 33);
            this.DescripcionProductoTextBox.Name = "DescripcionProductoTextBox";
            this.DescripcionProductoTextBox.ReadOnly = true;
            this.DescripcionProductoTextBox.Size = new System.Drawing.Size(241, 31);
            this.DescripcionProductoTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo";
            // 
            // FacturaDataGridView
            // 
            this.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturaDataGridView.Location = new System.Drawing.Point(16, 296);
            this.FacturaDataGridView.Name = "FacturaDataGridView";
            this.FacturaDataGridView.RowHeadersWidth = 62;
            this.FacturaDataGridView.RowTemplate.Height = 33;
            this.FacturaDataGridView.Size = new System.Drawing.Size(1142, 245);
            this.FacturaDataGridView.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "ISV";
            // 
            // ISVTextBox
            // 
            this.ISVTextBox.Location = new System.Drawing.Point(109, 565);
            this.ISVTextBox.Name = "ISVTextBox";
            this.ISVTextBox.ReadOnly = true;
            this.ISVTextBox.Size = new System.Drawing.Size(150, 31);
            this.ISVTextBox.TabIndex = 9;
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Location = new System.Drawing.Point(109, 612);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(150, 31);
            this.DescuentoTextBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 612);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Descuento";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(109, 660);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(150, 31);
            this.SubTotalTextBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 660);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Sub Total";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(109, 708);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(150, 31);
            this.TotalTextBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 711);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(942, 582);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(199, 136);
            this.GuardarButton.TabIndex = 16;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 795);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ISVTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FacturaDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TicketsForm";
            this.Text = "FacturaForm";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker FechaDateTimePicker;
        private TextBox UsuarioTextBox;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox NombreClienteTextBox;
        private MaskedTextBox IdentidadClienteTextBox;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox ExistenciaTextBox;
        private Label label6;
        private TextBox CantidadTextBox;
        private Label label5;
        private TextBox CodigoProductoTextBox;
        private TextBox DescripcionProductoTextBox;
        private Label label3;
        private DataGridView FacturaDataGridView;
        private Label label7;
        private TextBox ISVTextBox;
        private TextBox DescuentoTextBox;
        private Label label8;
        private TextBox SubTotalTextBox;
        private Label label9;
        private TextBox TotalTextBox;
        private Label label10;
        private Button GuardarButton;
        private ErrorProvider errorProvider1;
    }
}