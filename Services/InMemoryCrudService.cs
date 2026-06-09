using TestMVC.Models;

namespace TestMVC.Services;

// Lớp này cài đặt CRUD tổng quát bằng danh sách trong bộ nhớ.
// Các service cụ thể có thể kế thừa lại để tránh viết trùng code.
public class InMemoryCrudService<T> : ICrudService<T> where T : BaseModel
{
    protected readonly List<T> Items = new();

    public virtual List<T> GetAll()
    {
        return Items;
    }

    public virtual T? GetById(int id)
    {
        return Items.FirstOrDefault(item => item.Id == id);
    }

    public virtual void Create(T item)
    {
        item.Id = Items.Count == 0 ? 1 : Items.Max(x => x.Id) + 1;
        item.CreatedAt = DateTime.Now;
        item.UpdatedAt = DateTime.Now;

        Items.Add(item);
    }

    public virtual void Update(T item)
    {
        var oldItem = GetById(item.Id);

        if (oldItem == null)
        {
            return;
        }

        var index = Items.IndexOf(oldItem);
        item.CreatedAt = oldItem.CreatedAt;
        item.UpdatedAt = DateTime.Now;

        Items[index] = item;
    }

    public virtual void Delete(int id)
    {
        var item = GetById(id);

        if (item != null)
        {
            Items.Remove(item);
        }
    }
}
