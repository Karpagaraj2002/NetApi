using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommerceDAL;
using EcommerceDAL.DAL;
using Microsoft.Extensions.Configuration;
using static EcommerceDAL.DAL.Model;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public String ConnStr = "";
        Service obj = null;
        public MainController(IConfiguration configuration)
        {
            _configuration = configuration;

            ConnStr = _configuration.GetConnectionString("DefaultConnection");
            obj = new Service(configuration);
        }

        [HttpGet]
        public AllOrderDetail allgetorder()
        {
            AllOrderDetail objResponse = new AllOrderDetail();

            objResponse = obj.allGetOrder();

            return objResponse;

        }




        
    }

    
}
