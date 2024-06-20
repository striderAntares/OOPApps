using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace _23_SerializationStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = null;
            if (txtAverages.Text.Trim() == "" || txtMajor.Text.Trim() == "" || txtMobileNumber.Text.Trim() == "" || txtNameSurname.Text.Trim() == "" || txteMail.Text.Trim() == "" || dateTimePicker1.Value.Date == DateTime.Now)
            {
                MessageBox.Show("Can't be empty");
            }
            else
            {
                student = new Student()
                {
                    NameSurname = txtNameSurname.Text,
                    Major = txtMajor.Text,
                    MobileNumber = txtMobileNumber.Text,
                    Average = Convert.ToDouble(txtAverages.Text),
                    Email = txteMail.Text,
                    Birthdate = dateTimePicker1.Value.Date,
                    ID = Guid.NewGuid()

                };
            }
            try
            {
                if (student != null)
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Student));
                    FileStream stream = new FileStream(@"C:\Users\79153\Desktop\True Path\HS-15\OOP\OOPApps\23-SerializationStudent\Student.xml", FileMode.Create, FileAccess.Write);

                    using (stream) //using clears the code block from the RAM before the garbage collector
                    {
                        xml.Serialize(stream, student);
                        label8.Text = "Status: Object serialization successful";
                        label7.Text = student.ID.ToString();
                    }

                }
            }
            catch
            {
                label8.Text = "Status: Object serialization unsuccessful";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student incomingStudent = new Student();
            FileStream stream = new FileStream(@"C:\Users\79153\Desktop\True Path\HS-15\OOP\OOPApps\23-SerializationStudent\Student.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(Student));
            try
            {
                using (stream) //using clears the code block from the RAM before the garbage collector
                {
                    incomingStudent = (Student)xml.Deserialize(stream);
                    label8.Text = "Status: Object deserialization successful";
                    txtNameSurname.Text = incomingStudent.NameSurname;
                    txteMail.Text = incomingStudent.Email;
                    txtMajor.Text = incomingStudent.Major;
                    txtMobileNumber.Text = incomingStudent.MobileNumber;
                    txtAverages.Text = incomingStudent.Average.ToString();
                    dateTimePicker1.Value = incomingStudent.Birthdate;
                    label7.Text = incomingStudent.ID.ToString();
                }
            }
            catch
            {
                label8.Text = "Status: Object deserialization unsuccessful";
            }
        }
    }
}
