namespace PALITODECOCO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTN_ELIMINAR = new Button();
            BTN_GUARDAR = new Button();
            dataGridView1 = new DataGridView();
            LBL_CARGO = new Label();
            cbCargo = new ComboBox();
            TXT_EDAD = new TextBox();
            TXT_APELLIDO = new TextBox();
            TXT_SUELDO = new TextBox();
            TXT_NOMBRE = new TextBox();
            LBL_SUELDO = new Label();
            LBL_EDAD = new Label();
            LBL_APELLIDO = new Label();
            LBL_NOMBRE = new Label();
            LBL_TITULO = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.Location = new Point(454, 475);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new Size(104, 32);
            BTN_ELIMINAR.TabIndex = 25;
            BTN_ELIMINAR.Text = "ELIMINAR";
            BTN_ELIMINAR.UseVisualStyleBackColor = true;
            BTN_ELIMINAR.Click += BTN_ELIMINAR_Click;
            // 
            // BTN_GUARDAR
            // 
            BTN_GUARDAR.Location = new Point(282, 475);
            BTN_GUARDAR.Name = "BTN_GUARDAR";
            BTN_GUARDAR.Size = new Size(104, 32);
            BTN_GUARDAR.TabIndex = 24;
            BTN_GUARDAR.Text = "GUARDAR";
            BTN_GUARDAR.UseVisualStyleBackColor = true;
            BTN_GUARDAR.Click += BTN_GUARDAR_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(665, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(716, 387);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // LBL_CARGO
            // 
            LBL_CARGO.AutoSize = true;
            LBL_CARGO.Location = new Point(261, 413);
            LBL_CARGO.Name = "LBL_CARGO";
            LBL_CARGO.Size = new Size(47, 15);
            LBL_CARGO.TabIndex = 22;
            LBL_CARGO.Text = "CARGO";
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(364, 413);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(121, 23);
            cbCargo.TabIndex = 21;
            // 
            // TXT_EDAD
            // 
            TXT_EDAD.Location = new Point(364, 296);
            TXT_EDAD.Name = "TXT_EDAD";
            TXT_EDAD.Size = new Size(134, 23);
            TXT_EDAD.TabIndex = 20;
            // 
            // TXT_APELLIDO
            // 
            TXT_APELLIDO.Location = new Point(364, 235);
            TXT_APELLIDO.Name = "TXT_APELLIDO";
            TXT_APELLIDO.Size = new Size(134, 23);
            TXT_APELLIDO.TabIndex = 19;
            // 
            // TXT_SUELDO
            // 
            TXT_SUELDO.Location = new Point(364, 347);
            TXT_SUELDO.Name = "TXT_SUELDO";
            TXT_SUELDO.Size = new Size(134, 23);
            TXT_SUELDO.TabIndex = 18;
            // 
            // TXT_NOMBRE
            // 
            TXT_NOMBRE.Location = new Point(364, 184);
            TXT_NOMBRE.Name = "TXT_NOMBRE";
            TXT_NOMBRE.Size = new Size(134, 23);
            TXT_NOMBRE.TabIndex = 17;
            TXT_NOMBRE.TextChanged += TXT_NOMBRE_TextChanged;
            // 
            // LBL_SUELDO
            // 
            LBL_SUELDO.AutoSize = true;
            LBL_SUELDO.Location = new Point(261, 347);
            LBL_SUELDO.Name = "LBL_SUELDO";
            LBL_SUELDO.Size = new Size(50, 15);
            LBL_SUELDO.TabIndex = 16;
            LBL_SUELDO.Text = "SUELDO";
            // 
            // LBL_EDAD
            // 
            LBL_EDAD.AutoSize = true;
            LBL_EDAD.Location = new Point(261, 296);
            LBL_EDAD.Name = "LBL_EDAD";
            LBL_EDAD.Size = new Size(37, 15);
            LBL_EDAD.TabIndex = 15;
            LBL_EDAD.Text = "EDAD";
            // 
            // LBL_APELLIDO
            // 
            LBL_APELLIDO.AutoSize = true;
            LBL_APELLIDO.Location = new Point(261, 238);
            LBL_APELLIDO.Name = "LBL_APELLIDO";
            LBL_APELLIDO.Size = new Size(60, 15);
            LBL_APELLIDO.TabIndex = 14;
            LBL_APELLIDO.Text = "APELLIDO";
            // 
            // LBL_NOMBRE
            // 
            LBL_NOMBRE.AutoSize = true;
            LBL_NOMBRE.Location = new Point(261, 184);
            LBL_NOMBRE.Name = "LBL_NOMBRE";
            LBL_NOMBRE.RightToLeft = RightToLeft.Yes;
            LBL_NOMBRE.Size = new Size(56, 15);
            LBL_NOMBRE.TabIndex = 13;
            LBL_NOMBRE.Text = "NOMBRE";
            // 
            // LBL_TITULO
            // 
            LBL_TITULO.AutoSize = true;
            LBL_TITULO.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_TITULO.Location = new Point(423, 93);
            LBL_TITULO.Name = "LBL_TITULO";
            LBL_TITULO.RightToLeft = RightToLeft.Yes;
            LBL_TITULO.Size = new Size(459, 45);
            LBL_TITULO.TabIndex = 26;
            LBL_TITULO.Text = "EL MEJOR SISTEMA DEL PAIS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 691);
            Controls.Add(LBL_TITULO);
            Controls.Add(BTN_ELIMINAR);
            Controls.Add(BTN_GUARDAR);
            Controls.Add(dataGridView1);
            Controls.Add(LBL_CARGO);
            Controls.Add(cbCargo);
            Controls.Add(TXT_EDAD);
            Controls.Add(TXT_APELLIDO);
            Controls.Add(TXT_SUELDO);
            Controls.Add(TXT_NOMBRE);
            Controls.Add(LBL_SUELDO);
            Controls.Add(LBL_EDAD);
            Controls.Add(LBL_APELLIDO);
            Controls.Add(LBL_NOMBRE);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_ELIMINAR;
        private Button BTN_GUARDAR;
        private DataGridView dataGridView1;
        private Label LBL_CARGO;
        private ComboBox cbCargo;
        private TextBox TXT_EDAD;
        private TextBox TXT_APELLIDO;
        private TextBox TXT_SUELDO;
        private TextBox TXT_NOMBRE;
        private Label LBL_SUELDO;
        private Label LBL_EDAD;
        private Label LBL_APELLIDO;
        private Label LBL_NOMBRE;
        private Label LBL_TITULO;
    }
}
