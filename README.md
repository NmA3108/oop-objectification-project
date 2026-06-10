# E-Commerce OOP System

## Giới thiệu

Đây là đồ án môn học với đề tài:

**"Phân tích và làm rõ tính đối tượng hóa trong OOP và ứng dụng"**

Đề tài xây dựng một hệ thống thương mại điện tử mẫu nhằm minh họa việc áp dụng các nguyên lý của lập trình hướng đối tượng (Object-Oriented Programming - OOP) trong phân tích, thiết kế và xây dựng phần mềm.

Hệ thống được phát triển bằng ASP.NET Core MVC và tập trung vào việc thể hiện các kỹ thuật tổng quát hóa, đặc thù hóa, đóng gói, kế thừa, trừu tượng và đa hình.

---

## Công nghệ sử dụng

* ASP.NET Core MVC
* C#
* Bootstrap 5
* PlantUML
* GitHub

---

## Chức năng đã xây dựng

### Quản lý tài khoản

* Đăng nhập hệ thống
* Kiểm tra thông tin đăng nhập

### Quản lý sản phẩm

* Hiển thị danh sách sản phẩm
* Tìm kiếm sản phẩm
* Xem chi tiết sản phẩm
* Thêm sản phẩm
* Chỉnh sửa sản phẩm
* Xóa sản phẩm

### Chức năng hỗ trợ

* Quản lý dữ liệu theo mô hình CRUD
* Mô hình hóa hệ thống bằng UML

---

## Áp dụng OOP trong hệ thống

### Đóng gói (Encapsulation)

Các thuộc tính và phương thức được quản lý thông qua các lớp Model.

### Kế thừa (Inheritance)

Các lớp Customer, Seller và Admin kế thừa từ lớp User.

### Trừu tượng (Abstraction)

Sử dụng BaseModel làm lớp cơ sở cho các đối tượng trong hệ thống.

### Đa hình (Polymorphism)

Các phương thức xử lý thanh toán được triển khai thông qua các lớp kế thừa từ Payment.

### Tổng quát hóa và đặc thù hóa

Hệ thống sử dụng các lớp cơ sở và lớp dẫn xuất để giảm sự trùng lặp mã nguồn và tăng khả năng mở rộng.

---

## Cấu trúc thư mục

```text
Controllers/
Models/
Views/
Services/
wwwroot/
```

---

## Kết quả đạt được

* Xây dựng thành công hệ thống thương mại điện tử mẫu.
* Hoàn thành chức năng CRUD sản phẩm.
* Áp dụng các nguyên lý của OOP trong thiết kế hệ thống.
* Xây dựng các biểu đồ UML phục vụ quá trình phân tích và thiết kế.

---

## Tác giả

Nguyễn Minh Ánh
MSSV: 23010718
Trường Đại học Phenikaa
Năm học: 2025 - 2026
