using System;
using Newtonsoft.Json;

namespace LAB4_Bai7
{
    public class Food
    {
        public int id { get; set; }
        
        [JsonProperty("ten_mon_an")]
        public string ten_mon_an { get; set; } = string.Empty;
        
        [JsonProperty("nguoi_tao")]
        public string nguoi_tao { get; set; } = string.Empty;
        
        [JsonProperty("ngay_tao")]
        public string ngay_tao { get; set; } = string.Empty;
    }
}
