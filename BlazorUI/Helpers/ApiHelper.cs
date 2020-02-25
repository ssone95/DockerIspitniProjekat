using Domain.Responses;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorUI.Helpers
{
    public class ApiHelper
    {
        HttpClient client;
        public ApiHelper(HttpClient _client)
        {
            client = _client;
        }
        public async Task<BaseResponse<T>> Get<T>(string route = "")
        {
            BaseResponse<T> response = new BaseResponse<T>();
            try
            {
                var httpResult = await client.GetAsync(route);

                if (httpResult.IsSuccessStatusCode)
                {
                    using (HttpContent content = httpResult.Content)
                    {
                        var responseString = await content.ReadAsStringAsync();
                        response = JsonConvert.DeserializeObject<BaseResponse<T>>(responseString);
                    }
                }
                else
                {
                    response.StatusCode = httpResult.StatusCode;
                    response.Message = httpResult.ReasonPhrase;
                    response.Success = false;
                }

                return response;
            } catch(Exception ex)
            {
                response = new BaseResponse<T>();
                response.Result = default(T);
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<BaseResponse<T>> Post<T>(string route = "", dynamic data = null)
        {
            BaseResponse<T> response = new BaseResponse<T>();
            try
            {
                var dataString = JsonConvert.SerializeObject(data);
                var contentToSend = new StringContent(dataString, System.Text.Encoding.UTF8, "application/json");

                var httpResult = await client.PostAsync($"{route}", contentToSend);
                if (httpResult.IsSuccessStatusCode)
                {
                    if (httpResult.IsSuccessStatusCode)
                    {
                        using (HttpContent content = httpResult.Content)
                        {
                            var responseString = await content.ReadAsStringAsync();
                            response = JsonConvert.DeserializeObject<BaseResponse<T>>(responseString);
                        }
                    }
                    else
                    {
                        response.StatusCode = httpResult.StatusCode;
                        response.Message = httpResult.ReasonPhrase;
                        response.Success = false;
                    }
                }

                return response;
            }
            catch (Exception ex)
            {
                response = new BaseResponse<T>();
                response.Result = default(T);
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
