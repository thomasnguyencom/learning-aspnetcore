using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Omgtitb.Learning.AspNetCore.AppModel
{
    public class Pose
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Pose()
        {
            Id = 0;
            Name = string.Empty;
        }

        public Pose(int id, string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException(nameof(name));

            Id = id;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            var pose = obj as Pose;
            return pose != null &&
                   Id == pose.Id &&
                   Name == pose.Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1}", Id, Name);
        }
    }
}
