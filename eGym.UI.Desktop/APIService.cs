﻿using eGym.BLL.Models;
using Flurl.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Globalization;
using System.Text;

namespace eGym.UI.Desktop
{
    public class APIService
    {
        private string _resource = null;
        public string _endpoint = "https://localhost:7220/";

        public static string Username = null;
        public static string Password = null;
        public static EmployeeDTO currentUser;

        public APIService(string resource)
        {
            _resource = resource;
        } 

        public async Task<T> Login<T>(object request, string path = "")
        {
            try
            {
                var query = "";
                if (request != null)
                {
                    query = await request.ToQueryString();
                }

                var result = await $"{_endpoint}{_resource}{path}?{query}".PostAsync().ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Post<T>(object request)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}".WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task Get(string path)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}/{path}".WithBasicAuth(Username, Password).GetAsync();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return default;
            }
        }

        public async Task<T> Get<T>(object search = null, string path = "")
        {
            var query = "";
            if (search != null)
            {
                query = await search.ToQueryString();
            }

            var list = await $"{_endpoint}{_resource}{path}?{query}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return list;
        }

        public async Task<T> GetById<T>(object id)
        {
            var result = await $"{_endpoint}{_resource}/{id}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Put<T>(object id, object request)
        {
            var result = await $"{_endpoint}{_resource}?id={id}".WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();

            return result;
        }

        public async Task Delete(object id)
        {
            var query =  await id.ToQueryString();

            var result = await $"{_endpoint}{_resource}?{query}".WithBasicAuth(Username, Password).DeleteAsync();
        }
    }
}
