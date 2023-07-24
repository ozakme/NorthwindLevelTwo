using Entities.DomainModels;

namespace MvcWebUI.Helpers
{
    public interface ICartSessionHelper
    {
        public Cart GetCart(string key);
        public void SetCart(string key, Cart cart);
        public void Clear();

    }
}
