using static _20_OOPEnumPersonnel.Personnel;

namespace _20_OOPEnumPersonnel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues<Units>())
            {
                comboBox1.Items.Add(item);
            }
        }
        string savedNames = "";
        string savedUnits = "";
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + " " + comboBox1.SelectedItem);
            Personnel person = new Personnel();
            savedNames += textBox1.Text + " ";
            savedUnits += comboBox1.SelectedItem.ToString() + " ";
            string[] namearrays = savedNames.Split();
            string[] unitarrays = savedUnits.Split();
            person.NameSurname = savedNames;
            person.PersonnelUnits = savedUnits;
            for (int i = 0; i < namearrays.Length; i++)
            {
                MessageBox.Show(namearrays[i] + " " + unitarrays[i]);
            }
        }
    }
}
