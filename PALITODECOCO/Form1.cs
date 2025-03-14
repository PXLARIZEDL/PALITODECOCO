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
 
        
            dataGridView1.ReadOnly = true;  // Hace que toda la tabla sea de solo lectura
            dataGridView1.AllowUserToAddRows = false; // Evita que se agreguen filas manualmente
        

        }

        private void TXT_NOMBRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            // Verifica si alg�n campo est� vac�o
            if (string.IsNullOrWhiteSpace(TXT_NOMBRE.Text) ||
                string.IsNullOrWhiteSpace(TXT_APELLIDO.Text) ||
                string.IsNullOrWhiteSpace(TXT_EDAD.Text) ||
                cbCargo.SelectedItem == null ||
                string.IsNullOrWhiteSpace(TXT_SUELDO.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si edad y sueldo son valores num�ricos
            if (!int.TryParse(TXT_EDAD.Text, out int edad) || !decimal.TryParse(TXT_SUELDO.Text, out decimal sueldo))
            {
                MessageBox.Show("Edad y sueldo deben ser valores num�ricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crea un nuevo empleado seg�n el cargo seleccionado
            Empleado empleado = cbCargo.SelectedItem.ToString() == "Administrador"
                ? new Administrativo(TXT_NOMBRE.Text, TXT_APELLIDO.Text, edad, cbCargo.SelectedItem.ToString(), sueldo)
                : new Tecnico(TXT_NOMBRE.Text, TXT_APELLIDO.Text, edad, cbCargo.SelectedItem.ToString(), sueldo);

            // Agrega el nuevo empleado a la lista
            empleados.Add(empleado);

            // Muestra un mensaje de �xito
            MessageBox.Show("Empleado registrado de forma correcta", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualiza el DataGridView
            RefrescarLista();
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indice = dataGridView1.SelectedRows[0].Index;
                if (indice >= 0 && indice < empleados.Count)
                {
                    empleados.RemoveAt(indice);
                    MessageBox.Show("Empleado eliminado correctamente.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarLista();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            

        }
        }
        private void RefrescarLista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     

            // Evitar edici�n en la tabla
            dataGridView1.ReadOnly = true;
       
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
