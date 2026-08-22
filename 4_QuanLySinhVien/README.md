1.totalStudents phải là static vì nó dùng để đếm tổng số Student được tạo ra, nên tất cả các đối tượng phải dùng chung một biến.
2.FindTopStudent là static vì nó làm việc với mảng Student được truyền vào, không thuộc riêng một Student nào. Còn GetClassification() cần lấy score của từng Student nên phải là instance method.
3.Không thể gọi student1.GetTotalStudents() vì GetTotalStudents() là static. Cách đúng là Student.GetTotalStudents(). Gọi qua object sẽ bị lỗi khi biên dịch.
4.Student.GetTotalStudents() gọi static method thông qua class, còn gọi qua instance là không hợp lệ. Vì vậy, nên gọi static method bằng tên class.
