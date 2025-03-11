using System.Text;

namespace Quiz2
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();

        public Form1()
        {
            InitializeComponent();
            LoadAdvisors();
            UpdateStudentList();
        }

        private void LoadAdvisors()
        {
            advisors.Add(new Advisor("ดร.สมศรี หมีอย่างเหม็น", "วิทยาการคอมพิวเตอร์"));
            advisors.Add(new Advisor("ดร.สมจิด พิชิตจักรวาล", "คณิตศาสตร์"));
            advisors.Add(new Advisor("ดร.วรพล แซ่ไม่มี", "ฟิสิกส์"));
            advisors.Add(new Advisor("ดร.โสภณวิชญ์ กระดอดี", "วิศวกรรมไฟฟ้า"));
            advisors.Add(new Advisor("ดร.พชร พิมพ์ไหล", "ชีววิทยา"));

            cmbAdvisor.Items.AddRange(advisors.Select(a => a.Name).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = tbid.Text;
            string name = tbname.Text;
            string major = tbmajor.Text;
            double grade;

            if (!double.TryParse(tbgrade.Text, out grade))
            {
                MessageBox.Show("กรุณากรอกเกรดเป็นตัวเลข");
                return;
            }

            if (cmbAdvisor.SelectedIndex == -1)
            {
                MessageBox.Show("กรุณาเลือกอาจารย์ที่ปรึกษา");
                return;
            }

            string advisorName = cmbAdvisor.SelectedItem.ToString();
            Advisor selectedAdvisor = advisors.FirstOrDefault(a => a.Name == advisorName);

            Student newStudent = new Student(name, major, id, grade, selectedAdvisor);
            students.Add(newStudent);

            UpdateStudentDisplay(newStudent);
            UpdateStudentList();
            MessageBox.Show("เพิ่มนักศึกษาเรียบร้อยแล้ว");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("ไม่มีนักศึกษาในระบบ");
                return;
            }

            Student topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
            Student lowestStudent = students.OrderBy(s => s.Grade).FirstOrDefault();
            double averageGrade = students.Average(s => s.Grade);

            MessageBox.Show($"นักศึกษาที่ได้เกรดสูงสุดคือ {topStudent.Name} ได้เกรด {topStudent.Grade}\n" +
                            $"นักศึกษาที่ได้เกรดต่ำสุดคือ {lowestStudent.Name} ได้เกรด {lowestStudent.Grade}\n" +
                            $"คะแนนเฉลี่ยของนักศึกษาทั้งหมดคือ {averageGrade:F2}");
        }

        private void UpdateStudentList()
        {
            lstStudents.Items.Clear();
            foreach (var student in students)
            {
                lstStudents.Items.Add(student.Name);
            }
        }

        private void lstStudents_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                return;
            }

            Student selectedStudent = students[lstStudents.SelectedIndex];
            UpdateStudentDisplay(selectedStudent);
        }

        private void UpdateStudentDisplay(Student student)
        {
            lbid.Text = student.ID;
            lbname.Text = student.Name;
            lbmajor.Text = student.Major;
            lbgrade.Text = student.Grade.ToString();
            lbadvisor.Text = student.Advisor.Name;
        }

        private void btnShowAdvisorsAndStudents_Click(object sender, EventArgs e)
        {
            if (advisors.Count == 0)
            {
                MessageBox.Show("ไม่มีข้อมูลอาจารย์ในระบบ");
                return;
            }

            StringBuilder advisorDetails = new StringBuilder();

            foreach (var advisor in advisors)
            {
                var advisorStudents = students.Where(s => s.Advisor == advisor).ToList();

                if (advisorStudents.Any())
                {
                    advisorDetails.AppendLine($"{advisor.Name} ({advisor.Major}):");
                    foreach (var student in advisorStudents)
                    {
                        advisorDetails.AppendLine($"  - {student.Name} ({student.ID})");
                    }
                }
                else
                {
                    advisorDetails.AppendLine($"{advisor.Name} ({advisor.Major}): ไม่มีนักศึกษาภายใต้การดูแล");
                }
            }

            MessageBox.Show(advisorDetails.ToString());
        }


    }
}