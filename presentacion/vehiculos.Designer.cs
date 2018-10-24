namespace presentacion
{
    partial class vehiculos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.cmbmotor = new System.Windows.Forms.ComboBox();
            this.nudcosto = new System.Windows.Forms.NumericUpDown();
            this.cmbtipovehiculo = new System.Windows.Forms.ComboBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtdescmotor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnelim = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.bntmodif = new System.Windows.Forms.Button();
            this.cmbcapacidad = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcosto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.Location = new System.Drawing.Point(15, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtmodelo
            // 
            this.txtmodelo.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtmodelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmodelo.Location = new System.Drawing.Point(182, 64);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(145, 15);
            this.txtmodelo.TabIndex = 0;
            this.txtmodelo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbmotor
            // 
            this.cmbmotor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbmotor.FormattingEnabled = true;
            this.cmbmotor.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "Electrico",
            "Hibrido",
            "Sin motor"});
            this.cmbmotor.Location = new System.Drawing.Point(461, 125);
            this.cmbmotor.Name = "cmbmotor";
            this.cmbmotor.Size = new System.Drawing.Size(121, 24);
            this.cmbmotor.TabIndex = 1;
            this.cmbmotor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nudcosto
            // 
            this.nudcosto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nudcosto.Location = new System.Drawing.Point(183, 121);
            this.nudcosto.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.nudcosto.Name = "nudcosto";
            this.nudcosto.Size = new System.Drawing.Size(120, 22);
            this.nudcosto.TabIndex = 2;
            this.nudcosto.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // cmbtipovehiculo
            // 
            this.cmbtipovehiculo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbtipovehiculo.FormattingEnabled = true;
            this.cmbtipovehiculo.Items.AddRange(new object[] {
            "Camion Refrigerado",
            "Camion Seco",
            "Furgon Refrigerado",
            "Furgon Seco",
            "Cabezal",
            "Pick-up",
            "Automovil"});
            this.cmbtipovehiculo.Location = new System.Drawing.Point(182, 232);
            this.cmbtipovehiculo.Name = "cmbtipovehiculo";
            this.cmbtipovehiculo.Size = new System.Drawing.Size(121, 24);
            this.cmbtipovehiculo.TabIndex = 1;
            this.cmbtipovehiculo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtplaca
            // 
            this.txtplaca.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtplaca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtplaca.Location = new System.Drawing.Point(460, 64);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(136, 15);
            this.txtplaca.TabIndex = 3;
            // 
            // txtdescmotor
            // 
            this.txtdescmotor.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtdescmotor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescmotor.Location = new System.Drawing.Point(459, 194);
            this.txtdescmotor.Name = "txtdescmotor";
            this.txtdescmotor.Size = new System.Drawing.Size(131, 15);
            this.txtdescmotor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(363, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Placa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(363, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo Motor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(351, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(26, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(26, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Vehiculo";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnagregar.Location = new System.Drawing.Point(646, 33);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(163, 44);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Agregar Vehiculo";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnelim
            // 
            this.btnelim.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnelim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnelim.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnelim.ForeColor = System.Drawing.SystemColors.Control;
            this.btnelim.Location = new System.Drawing.Point(646, 105);
            this.btnelim.Name = "btnelim";
            this.btnelim.Size = new System.Drawing.Size(163, 51);
            this.btnelim.TabIndex = 6;
            this.btnelim.Text = "Eliminar Vehiculo";
            this.btnelim.UseVisualStyleBackColor = false;
            this.btnelim.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnbuscar.Location = new System.Drawing.Point(646, 185);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(163, 48);
            this.btnbuscar.TabIndex = 6;
            this.btnbuscar.Text = "Buscar Vehiculo";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnmostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmostrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnmostrar.Location = new System.Drawing.Point(849, 105);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(168, 51);
            this.btnmostrar.TabIndex = 6;
            this.btnmostrar.Text = "Mostrar Todos";
            this.btnmostrar.UseVisualStyleBackColor = false;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsalir.Location = new System.Drawing.Point(849, 185);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(168, 48);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Cerrar";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // bntmodif
            // 
            this.bntmodif.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntmodif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntmodif.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntmodif.ForeColor = System.Drawing.SystemColors.Control;
            this.bntmodif.Location = new System.Drawing.Point(849, 33);
            this.bntmodif.Name = "bntmodif";
            this.bntmodif.Size = new System.Drawing.Size(168, 44);
            this.bntmodif.TabIndex = 6;
            this.bntmodif.Text = "Modificar Vehiculos";
            this.bntmodif.UseVisualStyleBackColor = false;
            this.bntmodif.Click += new System.EventHandler(this.button6_Click);
            // 
            // cmbcapacidad
            // 
            this.cmbcapacidad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmbcapacidad.FormattingEnabled = true;
            this.cmbcapacidad.Items.AddRange(new object[] {
            "5 toneladas",
            "8 toneladas",
            "12 toneladas",
            "35 toneladas"});
            this.cmbcapacidad.Location = new System.Drawing.Point(182, 165);
            this.cmbcapacidad.Name = "cmbcapacidad";
            this.cmbcapacidad.Size = new System.Drawing.Size(121, 24);
            this.cmbcapacidad.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.cmbcapacidad);
            this.groupBox1.Controls.Add(this.bntmodif);
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.btnmostrar);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.btnelim);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdescmotor);
            this.groupBox1.Controls.Add(this.txtplaca);
            this.groupBox1.Controls.Add(this.cmbtipovehiculo);
            this.groupBox1.Controls.Add(this.nudcosto);
            this.groupBox1.Controls.Add(this.cmbmotor);
            this.groupBox1.Controls.Add(this.txtmodelo);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1033, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Nuevo Vehiculo";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1027, 275);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 456;
            this.lineShape3.X2 = 581;
            this.lineShape3.Y1 = 191;
            this.lineShape3.Y2 = 191;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 458;
            this.lineShape2.X2 = 583;
            this.lineShape2.Y1 = 62;
            this.lineShape2.Y2 = 62;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 179;
            this.lineShape1.X2 = 325;
            this.lineShape1.Y1 = 65;
            this.lineShape1.Y2 = 65;
            // 
            // vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1048, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vehiculos";
            this.Text = "vehiculos";
            this.Load += new System.EventHandler(this.vehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcosto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.ComboBox cmbmotor;
        private System.Windows.Forms.NumericUpDown nudcosto;
        private System.Windows.Forms.ComboBox cmbtipovehiculo;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.TextBox txtdescmotor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnelim;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button bntmodif;
        private System.Windows.Forms.ComboBox cmbcapacidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}