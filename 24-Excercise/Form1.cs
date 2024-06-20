using System.Net;
using static _24_Excercise.Personnel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System;

namespace _24_Excercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        List<Personnel> personnels = new List<Personnel>();
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            byte keyValue = Convert.ToByte(e.KeyChar);

            if (keyValue >= 65 && keyValue <= 90 || keyValue >= 97 && keyValue <= 122 || keyValue == 8 || keyValue == 32)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        private void mtxtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            mtxtMobileNumber.Mask = "";
            byte keyValue = Convert.ToByte(e.KeyChar);
            if (keyValue >= 48 && keyValue <= 57 || keyValue == 8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        private void txtWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            byte keyValue = Convert.ToByte(e.KeyChar);
            if (keyValue >= 48 && keyValue <= 57 || keyValue == 8 || keyValue == 46)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        ReactorEngineer reactorEngineer;
        Accountant accountant;
        TurbineEngineer turbineEngineer;
        SoftwareDeveloper softwareDeveloper;
        HumanResources humanResources;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.IsValidEmail() || !txtTRIDNo.Text.IDNoChecker() || !mtxtMobileNumber.Text.MobileNumberChecker() || txtName.Text == null || txtSurname.Text == null || txtWage.Text == null || txtAddress.Text == null || dateTimePicker1.Value.Date == DateTime.Now || dateTimePicker2.Value.Date == DateTime.Now || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Try again...");
            }
            else
            {
                try
                {
                    Title titl = new Title();
                    switch (titl = GetEnumValueFromAnnotation(comboBox1.SelectedItem.ToString()))
                    {
                        case Title.Accountant:
                            {
                                accountant = new Accountant(txtName.Text, txtSurname.Text, dateTimePicker1.Value.Date)
                                {
                                    PersonnelID = Guid.NewGuid(),
                                    MobileNumber = mtxtMobileNumber.Text,
                                    Email = txtEmail.Text,
                                    Address = txtAddress.Text,
                                    StartDate = dateTimePicker2.Value.Date,
                                    Wage = Convert.ToDecimal(txtWage.Text),
                                    IDNo = txtTRIDNo.Text,
                                    Title = Title.Accountant
                                };
                                txtPersonnelID.Text = accountant.PersonnelID.ToString();
                                personnels.Add(accountant);
                                break;
                            }
                        case Title.SoftwareDeveloper:
                            {
                                softwareDeveloper = new SoftwareDeveloper()
                                {
                                    Name = txtName.Text,
                                    Surname = txtSurname.Text,
                                    PersonnelID = Guid.NewGuid(),
                                    Birthdate = dateTimePicker1.Value.Date,
                                    MobileNumber = mtxtMobileNumber.Text,
                                    Email = txtEmail.Text,
                                    Address = txtAddress.Text,
                                    StartDate = dateTimePicker2.Value.Date,
                                    Wage = Convert.ToDecimal(txtWage.Text),
                                    IDNo = txtTRIDNo.Text,
                                    Title = Title.SoftwareDeveloper
                                };
                                txtPersonnelID.Text = softwareDeveloper.PersonnelID.ToString();
                                personnels.Add(softwareDeveloper);
                                break;
                            }
                        case Title.HumanResources:
                            {
                                humanResources = new HumanResources()
                                {
                                    Name = txtName.Text,
                                    Surname = txtSurname.Text,
                                    PersonnelID = Guid.NewGuid(),
                                    Birthdate = dateTimePicker1.Value.Date,
                                    MobileNumber = mtxtMobileNumber.Text,
                                    Email = txtEmail.Text,
                                    Address = txtAddress.Text,
                                    StartDate = dateTimePicker2.Value.Date,
                                    Wage = Convert.ToDecimal(txtWage.Text),
                                    IDNo = txtTRIDNo.Text,
                                    Title = Title.HumanResources
                                };
                                txtPersonnelID.Text = humanResources.PersonnelID.ToString();
                                personnels.Add(humanResources);
                                break;
                            }
                        case Title.TurbineEngineer:
                            {
                                turbineEngineer = new TurbineEngineer()
                                {
                                    Name = txtName.Text,
                                    Surname = txtSurname.Text,
                                    PersonnelID = Guid.NewGuid(),
                                    Birthdate = dateTimePicker1.Value.Date,
                                    MobileNumber = mtxtMobileNumber.Text,
                                    Email = txtEmail.Text,
                                    Address = txtAddress.Text,
                                    StartDate = dateTimePicker2.Value.Date,
                                    Wage = Convert.ToDecimal(txtWage.Text),
                                    IDNo = txtTRIDNo.Text,
                                    Title = Title.TurbineEngineer
                                };
                                txtPersonnelID.Text = turbineEngineer.PersonnelID.ToString();
                                personnels.Add(turbineEngineer);
                                break;
                            }
                        case Title.ReactorEngineer:
                            {
                                reactorEngineer = new ReactorEngineer()
                                {
                                    Name = txtName.Text,
                                    Surname = txtSurname.Text,
                                    PersonnelID = Guid.NewGuid(),
                                    Birthdate = dateTimePicker1.Value.Date,
                                    MobileNumber = mtxtMobileNumber.Text,
                                    Email = txtEmail.Text,
                                    Address = txtAddress.Text,
                                    StartDate = dateTimePicker2.Value.Date,
                                    Wage = Convert.ToDecimal(txtWage.Text),
                                    IDNo = txtTRIDNo.Text,
                                    Title = Title.ReactorEngineer
                                };
                                txtPersonnelID.Text = reactorEngineer.PersonnelID.ToString();
                                personnels.Add(reactorEngineer);
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (!CheckForNullProperties(accountant) || !CheckForNullProperties(softwareDeveloper) || !CheckForNullProperties(humanResources) || !CheckForNullProperties(reactorEngineer) || !CheckForNullProperties(turbineEngineer))
                {
                    listView1.Items.Clear();
                    foreach (var item in personnels)
                    {
                        ListViewItem lv1 = new ListViewItem();
                        lv1.Text = item.PersonnelID.ToString();
                        lv1.SubItems.Add(item.Name);
                        lv1.SubItems.Add(item.Surname);
                        lv1.SubItems.Add(item.Birthdate.ToString());
                        lv1.SubItems.Add(item.MobileNumber);
                        lv1.SubItems.Add(item.Email);
                        lv1.SubItems.Add(item.Address);
                        lv1.SubItems.Add(item.StartDate.ToString());
                        lv1.SubItems.Add(item.Title.ToString());
                        lv1.SubItems.Add(item.Wage.ToString());
                        lv1.SubItems.Add(item.IDNo);
                        lv1.SubItems.Add(item.Sex.ToString());
                        listView1.Items.Add(lv1);
                    }
                }
                else
                    MessageBox.Show("One of the columns wasn't properly filled");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Title value in Enum.GetValues(typeof(Title)))
            {
                FieldInfo fieldInfo = typeof(Title).GetField(value.ToString());
                DisplayAttribute[] displayAttributes = (DisplayAttribute[])fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false);

                if (displayAttributes.Length > 0 && !string.IsNullOrWhiteSpace(displayAttributes[0].Name))
                {
                    comboBox1.Items.Add(displayAttributes[0].Name);
                }
                else
                {
                    comboBox1.Items.Add(value.ToString());
                }
            }
            foreach (Sex value in Enum.GetValues(typeof(Sex)))
            {
                FieldInfo fieldInfo = typeof(Sex).GetField(value.ToString());
                DisplayAttribute[] displayAttributes = (DisplayAttribute[])fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false);

                if (displayAttributes.Length > 0 && !string.IsNullOrWhiteSpace(displayAttributes[0].Name))
                {
                    comboBox2.Items.Add(displayAttributes[0].Name);
                }
                else
                {
                    comboBox2.Items.Add(value.ToString());
                }
            }
        }
        public static Title GetEnumValueFromAnnotation(string annotation)
        {
            foreach (Title value in Enum.GetValues(typeof(Title)))
            {
                string enumName = Enum.GetName(typeof(Title), value);
                MemberInfo memInfo = typeof(Title).GetField(enumName);
                var displayAttribute = memInfo.GetCustomAttribute<System.ComponentModel.DataAnnotations.DisplayAttribute>();
                if (displayAttribute != null && displayAttribute.Name == annotation)
                {
                    return value;
                }
            }
            throw new ArgumentException("No enum value found with the given annotation.", nameof(annotation));
        }
        static bool CheckForNullProperties(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            PropertyInfo[] properties = obj.GetType().GetProperties();


            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(obj);
                if (value == null)
                    return true;
            }
            return false;
        }
    }
}
