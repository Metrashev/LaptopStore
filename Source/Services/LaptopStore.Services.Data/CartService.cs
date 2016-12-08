using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaptopStore.Data.Models;
using LaptopStore.Data.Common;
using LaptopStore.Data;
using System.Web;

namespace LaptopStore.Services.Data
{
    public class CartService : ICartService
    {
        //private readonly IDbRepository<Cart> carts;

        //public CartService(IDbRepository<Cart> carts)
        //{
        //    this.carts = carts;
        //}

        //public const string CartSessionKey = "CartId";

        //public string GetCartId(HttpContextBase context)
        //{
        //    if (context.Session[CartSessionKey] == null)
        //    {
        //        if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
        //        {
        //            context.Session[CartSessionKey] = context.User.Identity.Name;
        //        }
        //        else
        //        {
        //            // Generate a new random GUID using System.Guid class
        //            Guid tempCartId = Guid.NewGuid();

        //            // Send tempCartId back to client as a cookie
        //            context.Session[CartSessionKey] = tempCartId.ToString();
        //        }
        //    }

        //    return context.Session[CartSessionKey].ToString();
        //}

        //public IQueryable<Cart> GetAll()
        //{
        //    return this.carts.All();
        //}

        //public Cart Find(object id)
        //{
        //    return this.carts.Find(id);
        //}

        //public void Add(Cart entity)
        //{
        //    this.carts.Add(entity);
        //    this.carts.SaveChanges();
        //}

        //public void Delete(object id)
        //{
        //    this.carts.Delete(id);
        //    this.carts.SaveChanges();
        //}

        //public void SaveChanges()
        //{
        //    this.carts.SaveChanges();
        //}
    }
}
