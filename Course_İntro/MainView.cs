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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Reflection;

namespace Course_İntro
{
    public partial class MainView : Form
    {

        private List<Student> _studentList = new List<Student>();
        private List<Teacher> _teacherList = new List<Teacher>();

        private int _indexToEdit = -1;

        
        public MainView()
        {
            InitializeComponent();
            UploadJsonOnStartUp();
            comboBox_gender.DataSource = Enum.GetNames(typeof(Gender));
            
        }


        private void UploadJsonOnStartUp()
        {
            string pathToJson = System.Reflection.Assembly.GetAssembly(typeof(Program)).Location;
            string theJsonDirectory = Path.GetDirectoryName(pathToJson);
            string jsonPath = Path.Combine(theJsonDirectory, "Resources", "Json");
            string jsonListInSystem = Path.Combine(jsonPath, "studentList.json");
            using (StreamReader jsonReader = new StreamReader(jsonListInSystem))
            {
                string jsonFileList = jsonReader.ReadToEnd();
                List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonFileList);
                _studentList.AddRange(students);
                RefreshListView();               
            }
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

        private void RefreshListView() 
        {
            listView_students.Items.Clear();

            for (int i = 0; i < _studentList.Count; i++)
            {
                Student student = _studentList[i];
                listView_students.Items.Add(student.FullName);                
            }

        }

        private void RefreshListViewTeacher() 
        {
            listView_Teacher.Items.Clear();

            for (int i = 0; i < _teacherList.Count; i++)
            {
                Teacher teacher = _teacherList[i];
                listView_Teacher.Items.Add(teacher.FullName);
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
            if (imageIn == null)
            {
                return null;
            }
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

        private Teacher CreateTeacher() 
        {
            Gender selectedGender = ExtractGender();
            byte[] pictureBytes = ImageToByteArray(pictureBox_Student.Image);
            Teacher teacherNew;
            if (selectedGender != Gender.Female)
                teacherNew = new Teacher(textBox_firstName.Text, textBox_lastName.Text, selectedGender, pictureBytes);
            else
                teacherNew = new Teacher(textBox_firstName.Text, textBox_lastName.Text, textBox_maidenName.Text, pictureBytes);

            return teacherNew;
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
            Student student = _studentList[selectdIndex];//hata
           
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

        private void button_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Json files (*.json)|*.json|XML files (*.xml)|*.xml";
            DialogResult  selectedFile = openFile.ShowDialog();
           
            string filePath = openFile.FileName;
            string fileExtension = Path.GetExtension(filePath);

            if (fileExtension.Equals(".json"))
            {
                string json = File.ReadAllText(filePath);
                List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);
                listView_students.Items.Clear();
                foreach (Student student in students)
                {
                    listView_students.Items.Add(student.FullName);
                }
            }
            else if (fileExtension.Equals(".xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                StreamReader reader = new StreamReader(filePath);
                List<Student> students = (List<Student>)serializer.Deserialize(reader);
                reader.Close();
                listView_students.Items.Clear();
                foreach (Student student in students)
                {
                    listView_students.Items.Add(student.FullName);
                }
            }

        }

        private void button_addPerson_Click(object sender, EventArgs e)
        {
            if (!CheckIfTextBoxesAreFilled()) return;

            bool isStudent = radioButton_student.Checked;

            Gender gender = ExtractGender();

            string fullPath = System.Reflection.Assembly.GetAssembly(typeof(Program)).Location;
            string theDirectory = Path.GetDirectoryName(fullPath);
            string imagePath = Path.Combine(theDirectory, "Resources", "Image");
            string imageFemale = Path.Combine(imagePath, "femaleavatar.png");
            string imageOtherGender = Path.Combine(imagePath, "otheravatar.png");

            switch (gender)
            {
                case Gender.Male:
                    pictureBox_Student.Image = Properties.Resources.maleavatar;
                    break;

                case Gender.Female:
                    pictureBox_Student.Image = Image.FromFile(imageFemale);
                    break;

                default:
                case Gender.Other:
                    pictureBox_Student.Image = Image.FromFile(imageOtherGender);
                    break;    
            }

            if (isStudent)
            {
                Student studentNew = CreateStudent();
                _studentList.Add(studentNew);
                RefreshListView();
            }
            else
            {
                Teacher teacherNew = CreateTeacher();
                _teacherList.Add(teacherNew);
                RefreshListViewTeacher();
            }

            EmptyTextBoxes();
            pictureBox_Student.Image = null;          
        } 
      
    }
}
