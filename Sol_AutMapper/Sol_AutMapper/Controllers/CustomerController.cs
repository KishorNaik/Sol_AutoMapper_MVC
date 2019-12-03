using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sol_AutMapper.EF;
using Sol_AutMapper.Models;

namespace Sol_AutMapper.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMapper mapper = null;

        public CustomerController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var customerModel = new CustomerModel()
            {
                FirstName = "Kishor",
                LastName = "Naik",
                Address=new AddressModel()
                {
                    City="Thane",
                    State="Maharashtra",
                    Street="Kalwa"
                }
                
            };

            var customerTableObj = mapper.Map<CustomerTable>(customerModel);

            var customerTable = new CustomerTable()
            {
                FirstName = "Kishor",
                LastName = "Naik",
                City = "Thane",
                State = "Maharashtra",
                Street = "Kalwa"
            };

            var customerModelObj = mapper.Map<CustomerModel>(customerTable);


            return View();
        }
    }
}