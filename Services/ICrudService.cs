using TestMVC.Models;

namespace TestMVC.Services;

// Interface là trừu tượng hoàn toàn: chỉ định nghĩa chức năng, không cài đặt chi tiết.
// Đây là CRUD tổng quát cho mọi model kế thừa BaseModel.
public interface ICrudService<T> where T : BaseModel
{
    List<T> GetAll();

    T? GetById(int id);

    void Create(T item);

    void Update(T item);

    void Delete(int id);
}
