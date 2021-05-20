using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapDatabaseContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetailDtos(Expression<Func<Customer, bool>> filter = null)
        {
            using (ReCapDatabaseContext context = new ReCapDatabaseContext())
            {
                var result = from c in filter == null ? context.Customers : context.Customers.Where(filter)
                             join u in context.JwtUsers
                             on c.UserId equals u.Id

                             select new CustomerDetailDto
                             {
                                 CompanyName = c.CompanyName,
                                 CustomerId = c.CustomerId,
                                 Email = u.Email,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName



                             };
                return result.ToList();
            }
        }
    }
}
