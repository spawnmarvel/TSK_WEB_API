using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiCommands.Models;

namespace ApiCommands.Controllers
{
    [RoutePrefix("api/commands")]
    public class CommandsController : ApiController
    {

        [Route("GetData")]
        public string GetData()
        {
            string res = "";
            List<Item> l = new List<Item>();
            Item a = new Item(1, "TAG 1", 2, "Process");
            Item b = new Item(2, "TAG 2", 2, "Calculate");
            l.Add(a);
            l.Add(b);
            foreach (Item i in l)
            {
                res += i.ToString();
            }
            return res;
        }

        [Route("GetNodeB")]
        public string GetNodeB()
        {
            return "B node data....";
        }
        [Route("GetNodeA")]
        public string GetNodeA()
        {
            return "A node data....";
        }
        [Route("{id:int}")]
        public string GetDataById(int id)
        {
            return "Get data by id " + id;
        }


    }
}
