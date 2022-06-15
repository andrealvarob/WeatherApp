using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Models
{
    class UserData
    {
        public String name { get; set; }
        public String password { get; set; }
        public String email { get; set; }

        public UserData(String name, String password, String email)
        {
            this.name = name;
            this.password = password;
            this.email = email;
        }
    }
}
