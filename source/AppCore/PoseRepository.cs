using Omgtitb.Learning.AspNetCore.AppModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Omgtitb.Learning.AspNetCore.AppCore
{
    //CRUD
    public interface IPoseRepository
    {
        IEnumerable<Pose> Get();

        Pose Get(int id);

        Pose Add(Pose pose);

        void Update(Pose pose);

        void Delete(string id);
    }

    public class PoseRepository : IPoseRepository
    {
        public PoseRepository()
        {
            // TODO
        }

        public IEnumerable<Pose> Get()
        {
            return new Pose[] { new Pose(1, "Warrior One"), new Pose(2, "Warrior Two") };
        }

        public Pose Get(int id)
        {
            return new Pose(1, "Warrior One");
        }

        public Pose Add(Pose pose)
        {
            throw new NotImplementedException();
        }

        public void Update(Pose pose)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
