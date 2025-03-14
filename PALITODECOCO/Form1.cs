namespace PALITODECOCO
{
    public partial class Form1 : Form
    {
        private List<Empleado> empleados = new List<Empleado>();

        public Form1()
        {
            InitializeComponent();
            cbCargo.Items.AddRange(new string[] { "Tecnico", "Administrador" }); // Agrega las opciones al ComboBox
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TXT_NOMBRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            // Verifica si algún campo está vacío
            if (string.IsNullOrWhiteSpace(TXT_NOMBRE.Text) ||
                string.IsNullOrWhiteSpace(TXT_APELLIDO.Text) ||
                string.IsNullOrWhiteSpace(TXT_EDAD.Text) ||
                cbCargo.SelectedItem == null ||
                string.IsNullOrWhiteSpace(TXT_SUELDO.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si edad y sueldo son valores numéricos
            if (!int.TryParse(TXT_EDAD.Text, out int edad) || !decimal.TryParse(TXT_SUELDO.Text, out decimal sueldo))
            {
                MessageBox.Show("Edad y sueldo deben ser valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crea un nuevo empleado según el cargo seleccionado
            Empleado empleado = cbCargo.SelectedItem.ToString() == "Administrador"
                ? new Administrativo(TXT_NOMBRE.Text, TXT_APELLIDO.Text, edad, cbCargo.SelectedItem.ToString(), sueldo)
                : new Tecnico(TXT_NOMBRE.Text, TXT_APELLIDO.Text, edad, cbCargo.SelectedItem.ToString(), sueldo);

            // Agrega el nuevo empleado a la lista
            empleados.Add(empleado);

            // Muestra un mensaje de éxito
            MessageBox.Show("Empleado registrado de forma correcta", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualiza el DataGridView
            RefrescarLista();
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indice = dataGridView1.SelectedRows[0].Index; // Obtiene el índice
                empleados.RemoveAt(indice); // Elimina el empleado de la lista

                MessageBox.Show("Empleado borrado de forma correcta", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarLista(); // Actualiza el DataGridView
            }
        }
        private void RefrescarLista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados;

            // Evitar edición en la tabla
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }
    }

}
// Clase base "Empleado"
public class Empleado
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public string Cargo { get; set; }
    public decimal Sueldo { get; set; }

    public Empleado(string nombre, string apellido, int edad, string cargo, decimal sueldo)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Cargo = cargo;
        Sueldo = sueldo;
    }
}

// Clase "Administrativo" que hereda de "Empleado"
public class Administrativo : Empleado
{
    public Administrativo(string nombre, string apellido, int edad, string cargo, decimal sueldo)
        : base(nombre, apellido, edad, cargo, sueldo) { }
}

// Clase "Tecnico" que hereda de "Empleado"
public class Tecnico : Empleado
{
    public Tecnico(string nombre, string apellido, int edad, string cargo, decimal sueldo)
        : base(nombre, apellido, edad, cargo, sueldo) { }
}
