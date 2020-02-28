using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BlazorUI.Helpers
{
    public static class LocalStorageHelper
    {
        public static async Task SetLocalStorageItem(this ILocalStorageService localStorage, string key, dynamic data)
        {
            await localStorage.SetItemAsync(key, data);
        }

        public static async Task RemoveLocalStorageItem(this ILocalStorageService localStorage, string key)
        {
            var contains = await localStorage.ContainKeyAsync(key);
            if (contains)
            {
                await localStorage.RemoveItemAsync(key);
            }
        }

        public static async Task<T> GetLocalStorageItem<T>(this ILocalStorageService localStorage, string key)
        {
            var contains = await localStorage.ContainKeyAsync(key);
            if (contains)
            {
                try
                {
                    var ls = await localStorage.GetItemAsync<T>(key);

                    return ls ?? default(T);
                } catch(Exception ex)
                {
                    return default(T);
                }
            }

            return default(T);
        }
    }
}
