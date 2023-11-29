using Laboratorium8.Models;

namespace Laboratorium8.Data
{
    public interface IFoxesRepository
    {
        void Add(Fox f);
        Fox Get(int id);
        IEnumerable<Fox> GetAll();
        void Update(int id, Fox f);
        Boolean Loves(int id);
        Boolean Hates(int id);
    }
}
