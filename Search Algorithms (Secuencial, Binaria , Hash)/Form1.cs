namespace Search_Algorithms__Secuencial__Binaria___Hash_
{
    public partial class Form1 : Form
    {
        private HASH_Table hashTable;
        public Form1()
        {
            InitializeComponent();
            hashTable = new HASH_Table(); // Instanciar la tabla hash
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int key = Math.Abs(txtKey.Text.GetHashCode()) % 10;// Usamos GetHashCode() para la clave (correo)
            string value = txtValue.Text;

            // Insertar en la tabla hash
            hashTable.Insert(key, value);
            MessageBox.Show("Usuario insertado o actualizado.");
            lstAlumnos.Items.Add(key + " " + value);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(TxtSearchId.Text);
            // Buscar en la tabla hash
            string result = hashTable.Search(key);
            if (result != null)
            {
                MessageBox.Show("Usuario encontrado " + result);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void BtnSequentialAndBinary_Click(object sender, EventArgs e)
        {
            Secuencial_Binary secuencial_Binary = new Secuencial_Binary();
            secuencial_Binary.Show();
        }
    }
}
