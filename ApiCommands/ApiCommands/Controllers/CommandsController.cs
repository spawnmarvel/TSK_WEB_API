using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiCommands.Controllers
{
    [RoutePrefix("api/commands")]
    public class CommandsController : ApiController
    {

        [Route("GetData")]
        public string GetData()
        {
            string res = "Fetching all data...";
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

        //http://localhost:56777/api/commands/getdata
        //http://localhost:56777/api/commands/getnodeb
        //http://localhost:56777/api/commands/getnodea
        //http://localhost:56777/api/commands/100

    }
}
