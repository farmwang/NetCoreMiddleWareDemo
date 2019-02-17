using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMiddleWarw.MiddleWare
{
    public class UACOptions
    {
        public string Name { get; set; }

        public string EncryptKey { get; set; }

        public int ExpiredSecond { get; set; }
    }
}
