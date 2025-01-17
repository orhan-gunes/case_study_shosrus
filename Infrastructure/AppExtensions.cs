﻿using Newtonsoft.Json;
using shopsruscase.Domain;
using shopsruscase.Domain.Entityes;

namespace shopsruscase.Infrastructure
{
    public static class AppExtensions
    {
        

        public static int TryParseInt(this object input) { 
             string? poo= input.ToString();
            int data = 0;
            int.TryParse(poo,out data);
            return data;    
        }


        public static decimal TryParseDecimal(this object input)
        {
            string? poo = input.ToString();
            decimal data = 0;
            decimal.TryParse(poo, out data);
            return data;
        }

        public static bool TryParseBool(this object input)
        {
            string? poo = input.ToString();
            bool data = false;
            bool.TryParse(poo, out data);
            return data;
        }

        public static string ToJson(this object input) 
        {
          return JsonConvert.SerializeObject(input);
        }

        public static T? ToModel<T>(this string input)
        {
            return JsonConvert.DeserializeObject<T>(input.ToString());
        }


    }
}
