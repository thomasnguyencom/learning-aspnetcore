using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Omgtitb.Learning.AspNetCore.AppModel
{
    public class Pose
    {
        public string Name { get; set; }
        
        public Pose(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException(nameof(name));
            
            Name = name;
        }
    }
}
