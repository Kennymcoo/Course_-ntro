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

        List<Student> _studentList = new List<Student>();

        int _indexToEdit = -1;
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


        //öğrenci eklendikten sonra yeni öğrenciyi hazır hale getir (textboxlar deful olsun)
        //buttonları işlevleri


        //6-export ile json xml seçilebilsin ve masaütüne kaydetebilesin

        public MainView(DialogExport dialogExport) 
        {
            InitializeComponent();
            _mainView = this;
        }
        public static MainView _mainView;

        public void addListViewItem(string value) 
        {
            listView_students.Items.Add(value);
        }


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

        private bool CheckIfTextBoxesAreFilled()
        {
            if (string.IsNullOrEmpty(textBox_firstName.Text))
            {
                MessageBox.Show("You need to enter a name");
                return false;
            }

            if (string.IsNullOrEmpty(textBox_lastName.Text))
            {
                MessageBox.Show("You need to enter a surname");
                return false;
            }
            return true;
        }
        private void Button_addStudent_Click(object sender, EventArgs e)
        {
            
            if (!CheckIfTextBoxesAreFilled()) return;

            if (pictureBox_Student.Image == null)
            {
                MessageBox.Show("need a picture");
                return;
            }
           
            Student studentNew = CreateStudent();
            _studentList.Add(studentNew);
            RefreshListView();
            EmptyTextBoxes();
            pictureBox_Student.Image = null;
        }

        private void RefreshListView() 
        {
            listView_students.Items.Clear();

            for (int i = 0; i < _studentList.Count; i++)
            {
                Student student = _studentList[i];
                listView_students.Items.Add(student.FullName);
            }

        }
        private void EmptyTextBoxes()
        {
            string emptyText = string.Empty;
            textBox_firstName.Text = emptyText;
            textBox_lastName.Text = emptyText;
            textBox_maidenName.Text = emptyText;
            comboBox_gender.SelectedIndex = 0;
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private Student CreateStudent()
        {
            Gender selectedGender = ExtractGender();
            byte[] pictureBytes = ImageToByteArray(pictureBox_Student.Image);
            Student studentNew;
            if (selectedGender != Gender.Female)
                studentNew = new Student(textBox_firstName.Text, textBox_lastName.Text, selectedGender , pictureBytes);
            else
                studentNew = new Student(textBox_firstName.Text, textBox_lastName.Text, textBox_maidenName.Text, pictureBytes);

            return studentNew;
        }

        private Gender ExtractGender()
        {
            string selectedValue = (string)comboBox_gender.SelectedValue;
            Enum.TryParse(selectedValue, out Gender selectedGender);
            return selectedGender;
        }

        private void Button_deleted_Click(object sender, EventArgs e)
        {

            if (listView_students.SelectedIndices.Count == 0)
            {
                MessageBox.Show("You need to select a student");
                return;
            }
            int selectdIndex = listView_students.SelectedIndices[0];

            _studentList.RemoveAt(selectdIndex);
            RefreshListView();
        }

        private void Button_show_Click(object sender, EventArgs e)
        {

            if (listView_students.SelectedIndices.Count == 0)
            {
                MessageBox.Show("You need to select a student");
                return;
            }
            int selectdIndex = listView_students.SelectedIndices[0];
            Student student = _studentList[selectdIndex];
           
            MessageBox.Show(student.FullName );

        }

        private void Button_edit_Click(object sender, EventArgs e)
        {
            if (listView_students.SelectedIndices.Count == 0)
            {
                MessageBox.Show("You need to select a student");
                return;
            }
            _indexToEdit = listView_students.SelectedIndices[0];
            Student student = _studentList[_indexToEdit];

            textBox_firstName.Text = student.FirstName;
            textBox_lastName.Text = student.LastName;
            textBox_maidenName.Text = student.MaidenName;
            switch (student.Gender)
            {
                case Gender.Male:
                    comboBox_gender.SelectedIndex = 0;
                    break;
                case Gender.Female:
                    comboBox_gender.SelectedIndex = 1;
                    break;
                case Gender.Other:
                    comboBox_gender.SelectedIndex = 2;
                    break;               
            }
            pictureBox_Student.Image = byteArrayToImage(student.Picture);
        }

        private void Button_saveAfterEdit_Click(object sender, EventArgs e)
        {
            if (_indexToEdit == -1) return;

            if (!CheckIfTextBoxesAreFilled()) return;

            Student editedStudent = CreateStudent();
            _studentList[_indexToEdit] = editedStudent;
            RefreshListView();
            EmptyTextBoxes();
            _indexToEdit = -1;
        }


        private void button_addPhoto_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files | *.jpg; *.jpeg; *.png";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            
            if (result == DialogResult.OK) // Test result.
            {
                pictureBox_Student.Image = new Bitmap(openFileDialog1.FileName);
                string file = openFileDialog1.FileName;
            }
        }

        private void button_deletePhoto_Click(object sender, EventArgs e)
        {
            pictureBox_Student.Image = null;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        
        private void Button_Export(object sender, EventArgs e)
        {
           DialogExport dialogExport = new DialogExport(_studentList);
           dialogExport.ShowDialog();
            
        }
    }
}
