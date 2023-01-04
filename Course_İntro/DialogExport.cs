using Course_İntro.Models.Entities;
using System.Text.Json;
using System.Xml.Serialization;


namespace Course_İntro
{

    public partial class DialogExport : Form
    {

        List<Student> _studentList;



        public DialogExport(List<Student> listStudents)
        {
            InitializeComponent();
            _studentList = listStudents;

        }
        private void button_Xml_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "StudentList.xml");
            using (FileStream stream = File.Create(filePath))
            {
                xmlSerializer.Serialize(stream, _studentList);
            }
            MessageBox.Show("save done");
            this.Close();
        }

        private void button_Json_Click(object sender, EventArgs e)
        {            
            string Json = JsonSerializer.Serialize(_studentList);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "studentList.json");
            File.WriteAllText(filePath, Json);
            MessageBox.Show("save done");
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
