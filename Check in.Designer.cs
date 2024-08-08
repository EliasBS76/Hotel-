namespace HOTEL
{
    partial class Check_in
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Dias = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtEdad = new TextBox();
            txtDias = new TextBox();
            txtTotal = new TextBox();
            cboH = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            btnadd = new Button();
            label8 = new Label();
            label9 = new Label();
            dataEntrada = new DateTimePicker();
            dataSalida = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(212, 239, 223);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(26, 78);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(212, 239, 223);
            label2.Location = new Point(68, 121);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(212, 239, 223);
            label3.Location = new Point(87, 161);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 200);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // Dias
            // 
            Dias.AutoSize = true;
            Dias.BackColor = Color.FromArgb(212, 239, 223);
            Dias.Location = new Point(91, 195);
            Dias.Name = "Dias";
            Dias.Size = new Size(29, 15);
            Dias.TabIndex = 4;
            Dias.Text = "Dias";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(212, 239, 223);
            label5.Location = new Point(25, 230);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 5;
            label5.Text = "Tipo de habitacion ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 247);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 6;
            label6.Text = " ";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(212, 239, 223);
            label7.Location = new Point(872, 411);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 7;
            label7.Text = "Total a pagar";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(157, 118);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 9;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(157, 158);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 10;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(157, 192);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(100, 23);
            txtDias.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(974, 411);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 13;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // cboH
            // 
            cboH.FormattingEnabled = true;
            cboH.Location = new Point(157, 227);
            cboH.Name = "cboH";
            cboH.Size = new Size(154, 23);
            cboH.TabIndex = 15;
            cboH.SelectedIndexChanged += cboH_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.GridColor = Color.FromArgb(128, 128, 255);
            dataGridView1.Location = new Point(327, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(792, 345);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Telefono";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Edad";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Dias";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Habitacion";
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Costo de renta";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Día de entrega";
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.HeaderText = "Día de Salida";
            Column8.Name = "Column8";
            Column8.Width = 150;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(212, 239, 223);
            btnadd.Location = new Point(114, 458);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 17;
            btnadd.Text = "Agregar";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(212, 239, 223);
            label8.Location = new Point(127, 271);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 20;
            label8.Text = "Dia de entrada";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(212, 239, 223);
            label9.Location = new Point(123, 351);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 21;
            label9.Text = "Fecha de salida";
            label9.Click += label9_Click;
            // 
            // dataEntrada
            // 
            dataEntrada.Location = new Point(57, 305);
            dataEntrada.Name = "dataEntrada";
            dataEntrada.Size = new Size(223, 23);
            dataEntrada.TabIndex = 22;
            // 
            // dataSalida
            // 
            dataSalida.Location = new Point(57, 389);
            dataSalida.Name = "dataSalida";
            dataSalida.Size = new Size(223, 23);
            dataSalida.TabIndex = 23;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(212, 239, 223);
            button3.Location = new Point(989, 458);
            button3.Name = "button3";
            button3.Size = new Size(104, 40);
            button3.TabIndex = 24;
            button3.Text = "Check Out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(212, 239, 223);
            button4.Location = new Point(842, 458);
            button4.Name = "button4";
            button4.Size = new Size(104, 40);
            button4.TabIndex = 25;
            button4.Text = "Consulta";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Check_in
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 64, 83);
            ClientSize = new Size(1131, 526);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataSalida);
            Controls.Add(dataEntrada);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnadd);
            Controls.Add(cboH);
            Controls.Add(txtTotal);
            Controls.Add(txtDias);
            Controls.Add(txtEdad);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Dias);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Check_in";
            Text = "Check_in";
            Load += Check_in_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Dias;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;

        public TextBox txtNombre;
        public TextBox txtTelefono;
        public TextBox txtEdad;
        public TextBox txtDias;
        public TextBox txtTotal;
        public ComboBox cboH;
        private Label label8;
        private DateTimePicker dataEntrada;
        private DateTimePicker dataSalida;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        public Button btnadd;
        public Label label9;
        private Button button3;
        private Button button4;
    }
}