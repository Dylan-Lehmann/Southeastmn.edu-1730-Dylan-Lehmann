using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3C__Product_maintenence
{
    public class Software : Product
    {
        public string Version { get; set; } = "";
        public Software(string? code, string? description, decimal price, string version) : 
            base(code, description, price) => Version = version;

        public override string ToString() =>
        $"{base.ToString()}, Version {Version}";
        }
    }

