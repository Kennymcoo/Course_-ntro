using Course_İntro.Models.Entities;
using Course_İntro.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_İntro
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();

            // Student student1 = new Student("Can Ata", "Elmacıoğlu", Gender.Male);
            // //  Student student2 = new Student("Atahan", "Elmacıoğlu");
            // // MessageBox.Show( student1.Id+": "+ student1.FirstName + " " + student1.LastName);
            //// MessageBox.Show(student1.Id + ": " + student1.FullName+ " " + student1.MaidenName + " " + student1.Gender);         
            // Student student3 = new Student("İlknur", "Elmacıoğlu", "İpekkesen");        
            // MessageBox.Show(student3.Id + ": " + student3.FullName  + student3.Gender);
            comboBox_gender.DataSource = Enum.GetNames(typeof(Gender));

        }
        //ödev 1= isim soyisim boş olamaz kontrolü
        //ödev 2 = bundan sonra gelen veriler ile bir tane student oluştur ve daha sonra masage box ile göster






        private void ComboBox_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            string selectedValue = (string)cmb.SelectedValue;

            Enum.TryParse(selectedValue, out Gender selectedGender);

            switch (selectedGender)
            {
                case Gender.Female:
                    textBox_maidenName.Enabled = true;
                    break;

                default:
                case Gender.Male:
                case Gender.Other:
                    textBox_maidenName.Enabled = false;
                    break;

            }
        }


        private void Button_addStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_firstName.Text))
            {
                MessageBox.Show("You need to enter a name");
                return;
            }

            if (string.IsNullOrEmpty(textBox_lastName.Text))
            {
                MessageBox.Show("You need to enter a surname");
                return;
            }
            
            string selectedValue = (string)comboBox_gender.SelectedValue;
            Enum.TryParse(selectedValue, out Gender selectedGender);

            Student studentNew;
            if (selectedGender != Gender.Female)
            {
                studentNew = new Student(textBox_firstName.Text, textBox_lastName.Text, selectedGender);
            }
            else
            {
                studentNew = new Student(textBox_firstName.Text, textBox_lastName.Text, textBox_maidenName.Text);
            }

            MessageBox.Show(studentNew.Id + ": " + studentNew.FullName + studentNew.Gender);
        }
    }
}
