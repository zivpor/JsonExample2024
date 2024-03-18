using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonExample2024.Models
{
    public class MyStudent:Student
    {
        [JsonPropertyName("Wow")]
        public string KushKush {  get; set; }   
        

    }
}
    