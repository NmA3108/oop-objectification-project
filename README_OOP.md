# Giải thích OOP trong project TestMVC

## 1. Tổng quát hóa model

Project sử dụng `BaseModel` làm lớp cha chung cho các model trong hệ thống.

`BaseModel` chứa các thuộc tính dùng chung:

- `Id`
- `CreatedAt`
- `UpdatedAt`

Các model như `Product`, `Order`, `Cart`, `Category`, `User` kế thừa từ `BaseModel`.

## 2. Đặc thù hóa

`User` là lớp cha tổng quát cho các loại người dùng.

Các lớp con gồm:

- `Customer`
- `Seller`
- `Admin`

Mỗi lớp con có thêm thuộc tính và cách xử lý riêng.

## 3. Trừu tượng bán phần

Các lớp abstract như `BaseModel`, `User`, `Payment` là trừu tượng bán phần.

Chúng có thể chứa thuộc tính hoặc phương thức đã cài đặt, đồng thời cho phép lớp con kế thừa và mở rộng.

## 4. Trừu tượng hoàn toàn

`ICrudService<T>` là interface, dùng để định nghĩa các thao tác CRUD chung mà không cài đặt chi tiết.

Các thao tác gồm:

- `GetAll()`
- `GetById(int id)`
- `Create(T item)`
- `Update(T item)`
- `Delete(int id)`

## 5. CRUD và generic

`InMemoryCrudService<T>` cài đặt CRUD tổng quát cho mọi model kế thừa `BaseModel`.

`ProductService` kế thừa `InMemoryCrudService<Product>` để tái sử dụng CRUD và bổ sung chức năng riêng là `Search()`.

## 6. Chức năng đã demo

- Hiển thị danh sách sản phẩm.
- Tìm kiếm sản phẩm.
- Xem chi tiết sản phẩm.
- Thêm sản phẩm.
- Sửa sản phẩm.
- Xóa sản phẩm.
- Đăng nhập giả lập.
