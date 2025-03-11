# โปรแกรมบันทึกข้อมูลนักศึกษา

- ชื่อ: นายโสภณวิชญ์
- รหัสนักศึกษา [673450209-9]  

โปรแกรมได้ใช้หลักการเขียนโปรแกรมตามหลักการเขียนโปรแกรมเชิงวัตถุอย่างไรบ้าง
**ใช้หลักการ OOP 4 ข้อดังนี้
   1. Encapsulation
   ตัวอย่างในโค้ดนี้ :
คลาส Student และ Advisor มี fields (ตัวแปร) ที่กำหนดค่าภายในคลาส และสามารถเข้าถึงข้อมูลผ่านพร็อพเพอร์ตี้หรือเมธอดเท่านั้น
นักศึกษาถูกเก็บใน List<Student> และอาจารย์ที่ปรึกษาถูกเก็บใน List<Advisor> ภายใน Form1 ซึ่งช่วยป้องกันการเข้าถึงข้อมูลโดยตรงจากภายนอก
   2.  Abstraction (การซ่อนรายละเอียดที่ไม่จำเป็น)
   ตัวอย่างในโค้ดนี้ :
คลาส Student และ Advisor ซ่อนการทำงานภายใน เช่น วิธีเก็บข้อมูล และให้เข้าถึงข้อมูลผ่านพร็อพเพอร์ตี้แทน
เมธอด UpdateStudentList(), UpdateStudentDisplay() ใน Form1 ซ่อนรายละเอียดการอัปเดต UI เพื่อให้โปรแกรมอ่านง่าย
   3. Inheritance 
   ตัวอย่างในโค้ดนี้ :
โปรแกรมนี้ยังไม่ได้ใช้ Inheritance โดยตรง แต่สามารถปรับปรุงให้รองรับการสืบทอดได้ เช่น
สามารถสร้าง Person เป็นคลาสแม่ และให้ Student กับ Advisor สืบทอดไป
  4. Polymorphism 
   ตัวอย่างในโค้ดนี้สามารถนำ Polymorphism มาใช้ในโปรแกรมนี้ :
สร้าง เมธอดแสดงข้อมูลนักศึกษาและอาจารย์ ที่ใช้การ Override
สามารถใช้ interface หรือ abstract class เพื่อให้คลาส Student และ Advisor มีเมธอด GetDetails() ที่แตกต่างกัน

  
**Class Diagram
  +--------------------------------------------------+
|                    Form1                         |
+--------------------------------------------------+
| - students: List<Student>                        |
| - advisors: List<Advisor>                        |
+--------------------------------------------------+
| + Form1()                                       |
| + LoadAdvisors(): void                          |
| + button1_Click(sender, e): void                |
| + button2_Click(sender, e): void                |
| + UpdateStudentList(): void                     |
| + lstStudents_SelectedIndexChanged_1(sender, e): void |
| + UpdateStudentDisplay(student: Student): void  |
| + btnShowAdvisorsAndStudents_Click(sender, e): void |
+--------------------------------------------------+
                  | 1..*      
                  |                         
                  v                         
+--------------------------------------------------+
|                  Student                         |
+--------------------------------------------------+
| - Name: string                                   |
| - Major: string                                  |
| - ID: string                                    |
| - Grade: double                                  |
| - Advisor: Advisor                              |
+--------------------------------------------------+
| + Student(name: string, major: string, id: string, grade: double, advisor: Advisor) |
+--------------------------------------------------+
                  | 1                         
                  |                         
                  v                         
+--------------------------------------------------+
|                  Advisor                         |
+--------------------------------------------------+
| - Name: string                                   |
| - Major: string                                  |
+--------------------------------------------------+
| + Advisor(name: string, major: string)          |
+--------------------------------------------------+
