using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.Repository.Concrete;
using Test.Repository.Factory;

namespace ASPNetWebAPIEmployeeDemo.Controllers
{
    public class EventController : ApiController
    {
        IEvents _repository;
       public EventController(IEvents repository)
       {
            _repository = repository;
       }
       public void Post()
        {

        }
    }
}
