using PharmaHub.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace PharmaHub.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);

        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Delivery> Deliveries { get; }
        IGenericRepository<Manufacturer> Manufacturers { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<PaymentMethod> PaymentMethods { get; }
        IGenericRepository<Prescription> Prescriptions { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<ProductPrescription> ProductPrescriptions { get; }
        IGenericRepository<Staff> StaffMembers { get; }


    }
}