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
            advisors.Add(new Advisor("��.����� ������ҧ����", "�Է�ҡ�ä���������"));
            advisors.Add(new Advisor("��.���Դ �ԪԵ�ѡ����", "��Ե��ʵ��"));
            advisors.Add(new Advisor("��.�þ� �������", "���ԡ��"));
            advisors.Add(new Advisor("��.�����Ԫ�� ��дʹ�", "���ǡ���俿��"));
            advisors.Add(new Advisor("��.��� ��������", "����Է��"));

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
                MessageBox.Show("��سҡ�͡�ô�繵���Ţ");
                return;
            }

            if (cmbAdvisor.SelectedIndex == -1)
            {
                MessageBox.Show("��س����͡�Ҩ�������֡��");
                return;
            }

            string advisorName = cmbAdvisor.SelectedItem.ToString();
            Advisor selectedAdvisor = advisors.FirstOrDefault(a => a.Name == advisorName);

            Student newStudent = new Student(name, major, id, grade, selectedAdvisor);
            students.Add(newStudent);

            UpdateStudentDisplay(newStudent);
            UpdateStudentList();
            MessageBox.Show("�����ѡ�֡�����º��������");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("����չѡ�֡����к�");
                return;
            }

            Student topStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();
            Student lowestStudent = students.OrderBy(s => s.Grade).FirstOrDefault();
            double averageGrade = students.Average(s => s.Grade);

            MessageBox.Show($"�ѡ�֡�ҷ�����ô�٧�ش��� {topStudent.Name} ���ô {topStudent.Grade}\n" +
                            $"�ѡ�֡�ҷ�����ô����ش��� {lowestStudent.Name} ���ô {lowestStudent.Grade}\n" +
                            $"��ṹ����¢ͧ�ѡ�֡�ҷ�������� {averageGrade:F2}");
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
                MessageBox.Show("����բ������Ҩ������к�");
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
                    advisorDetails.AppendLine($"{advisor.Name} ({advisor.Major}): ����չѡ�֡��������ô���");
                }
            }

            MessageBox.Show(advisorDetails.ToString());
        }


    }
}