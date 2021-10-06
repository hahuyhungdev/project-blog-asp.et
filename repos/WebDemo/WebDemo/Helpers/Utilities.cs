using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebDemo.Helpers
{
    public static class Utilities
    {
        public static int PAGE_SIZE = 20;
        public static string SEOUrl(string url)
        {
            url = url.ToLower().Trim();
            url = Regex.Replace(url, "áàạảãâấầậẩẫăắằặẳẵ", "a");
            url = Regex.Replace(url, "éèẹẻẽêếềệểễ", "e");
            url = Regex.Replace(url, "óòọỏõôốồộổỗơớờợởỡ", "o");
            url = Regex.Replace(url, "úùụủũưứừựửữ", "u");
            url = Regex.Replace(url, "íìịỉĩ", "i");
            url = Regex.Replace(url, "ýỳỵỷỹ", "y");
            url = Regex.Replace(url, "đ", "d");
            //url = Regex.Replace(url, "[^a-z0-9-]", "");
            // url = Regex.Replace(url, "(-)+", "-");

            url = Regex.Replace(url.Trim(), @"[^0-9a-z-\s]", "").Trim();
            url = Regex.Replace(url.Trim(), @"\s+", "-");
            url = Regex.Replace(url, @"\s", "-");
            while (true)
            {
                if (url.IndexOf("--") != -1)
                {
                    url = url.Replace("-", "-");
                }
                else
                {
                    break;
                }
            }
            return url;
        }
        public static string GetRandomKey(int length = 5)
        {
            //chuỗi mẫu (pattern)
            string pattern = @"0123456789zxcvbnmasdfghjklqwertyuiop[]{}:~!@#$%^&*()+";
            Random rd = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                sb.Append(pattern[rd.Next(0, pattern.Length)]);
            }

            return sb.ToString();
        }
        public static async Task<string> UploadFile(Microsoft.AspNetCore.Http.IFormFile file, string sDirectory, string newname = null)
        {
            try
            {
                if (newname == null) newname = file.FileName;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", sDirectory);
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                var supportedTypes = new[] { "jpg", "jpeg", "png", "gif" };
                var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);
                if (!supportedTypes.Contains(fileExt.ToLower())) // Khác các file định nghĩa
                {
                    return null;
                }
                else
                {
                    string fullPath = path + "//" + newname;
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    return newname;
                }
            }
            catch
            {
                return null;
            }
        }

       
    }

}
