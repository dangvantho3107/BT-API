﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace bai_tap_api_2.Controllers
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Lop")]
        public string Lop { get; set; }
        [DataMember(Name = "NamSinh")]
        public string NamSinh { get; set; }
    }
}