using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Products;
using Domain.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Repository.Abstractions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        IUnitOfWork unitOfWork;
        public ProductController(IServiceProvider provider)
        {
            unitOfWork = provider.GetRequiredService<IUnitOfWork>();
        }

        [HttpGet("{id}")]
        //public async Task<JsonResult> GetProductTypes(bool? mainTypes = null, int? parentId = null, string filterString = null)
        public async Task<JsonResult> GetProduct(int Id)
        {
            BaseResponse<Product> response = new BaseResponse<Product>();
            try
            {
                response.Result = await unitOfWork.GetProductRepository().GetProduct(Id);
            }
            catch (Exception ex)
            {
                response = new BaseResponse<Product>();
                response.Result = null;
                response.Success = false;
                response.Message = ex.Message;
            }
            JsonResult res = Json(response);
            return res;
        }

        //[HttpGet("List/{mainTypes}/{parentId}/{filterString}")]
        [HttpPost("List")]
        //public async Task<JsonResult> GetProductTypes(bool? mainTypes = null, int? parentId = null, string filterString = null)
        public async Task<JsonResult> GetProducts([FromBody]ProductFilterDTO filter)
        {
            BaseResponse<List<Product>> response = new BaseResponse<List<Product>>();
            try
            {
                response.Result = await unitOfWork.GetProductRepository().GetProducts(filter);
            }
            catch (Exception ex)
            {
                response = new BaseResponse<List<Product>>();
                response.Result = null;
                response.Success = false;
                response.Message = ex.Message;
            }
            JsonResult res = Json(response);
            return res;
        }
    }
}