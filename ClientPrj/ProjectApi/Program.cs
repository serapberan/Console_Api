using System;
using System.Net.Http;

namespace ProjectApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Api ve Console Uygulaması");
            
            HttpClient client = new HttpClient(); //Apiye istek atmayı sağlayan sınıf
            var response = client.GetAsync("https://localhost:44392/api/clients");  //İstekte bulanacağimiz URL adresini belirtiyoruz
            response.Wait(); //bekleme 

            if (response.IsCompleted) //Apiden gelen bilgileri al string formata çevir ve consola yaz 
            {
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var values = result.Content.ReadAsStringAsync(); 
                    values.Wait();
                    Console.WriteLine("Apiden gelen bilgi: " + values.Result);
                    Console.ReadLine();
                }
            }
            
        }
    }
}
