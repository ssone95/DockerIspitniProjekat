using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Domain.DTO;
using Domain.Products;
using Domain.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Repository.Abstractions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : Controller
    {
        IUnitOfWork unitOfWork;
        public ProductTypeController(IServiceProvider provider)
        {
            unitOfWork = provider.GetRequiredService<IUnitOfWork>();
        }

        [HttpPost]
        public async Task<JsonResult> Create([FromBody]ProductType product)
        {
            BaseResponse<ProductType> response = new BaseResponse<ProductType>();
            try
            {
                product = await unitOfWork.GetProductTypeRepository().Create(product);

                await unitOfWork.Save();

                response.Result = product;
            } catch(Exception ex)
            {
                response = new BaseResponse<ProductType>();
                response.Result = null;
                response.Success = false;
                response.Message = ex.Message;
            }

            JsonResult res = Json(response);
            return res;
        }

        [HttpPut("{id}")]
        public async Task<JsonResult> Update([FromBody]ProductType product)
        {
            BaseResponse<ProductType> response = new BaseResponse<ProductType>();
            try
            {
                product = await unitOfWork.GetProductTypeRepository().Create(product);

                await unitOfWork.Save();

                response.Result = product;
            }
            catch (Exception ex)
            {
                response = new BaseResponse<ProductType>();
                response.Result = null;
                response.Success = false;
                response.Message = ex.Message;
            }

            JsonResult res = Json(response);
            return res;
        }

        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(int id)
        {
            BaseResponse<ProductType> response = new BaseResponse<ProductType>();
            try
            {
                var product = await unitOfWork.GetProductTypeRepository().Delete(id);

                await unitOfWork.Save();

                response.Result = product;
            }
            catch (Exception ex)
            {
                response = new BaseResponse<ProductType>();
                response.Result = null;
                response.Success = false;
                response.Message = ex.Message;
            }

            JsonResult res = Json(response);
            return res;
        }


        [HttpGet("{id}")]
        public async Task<JsonResult> Get(int id)
        {
            BaseResponse<ProductType> response = new BaseResponse<ProductType>();
            try
            {
                var product = await unitOfWork.GetProductTypeRepository().GetProductType(id);

                await unitOfWork.Save();

                response.Result = product;
            }
            catch (Exception ex)
            {
                response = new BaseResponse<ProductType>();
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
        public async Task<JsonResult> GetProductTypes([FromBody]ProductTypeFilterDTO filter)
        {
            BaseResponse<List<ProductType>> response = new BaseResponse<List<ProductType>>();
            try
            {
                response.Result = await unitOfWork.GetProductTypeRepository().GetProductTypes(mainTypes: filter?.MainTypes, parentId: filter?.ParentTypeId, filterString: filter?.FilterString);
            } catch(Exception ex)
            {
                response = new BaseResponse<List<ProductType>>();
                response.Result = null;
                response.Success = false;
                response.Message = ex.Message;
            }
            JsonResult res = Json(response);
            return res;
        } 
    }
}