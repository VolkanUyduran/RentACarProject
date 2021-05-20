using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapDatabaseContext context=new ReCapDatabaseContext())
            {
                var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cst in context.Customers
                             on r.CustomerId equals cst.CustomerId
                             join u in context.JwtUsers
                             on cst.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 
                                 Id = r.Id,
                                 BrandName = b.BrandName,
                                 FirstName = u.FirstName,
                                 Lastname = u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate=r.ReturnDate
                                 
                             };
                return result.ToList();
            }
        }
    }
}
