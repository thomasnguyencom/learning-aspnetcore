using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Omgtitb.Learning.AspNetCore.AppModel.Tests
{
    [TestClass]
    public class PoseTests
    {
        [TestMethod]
        public void should_create_Pose()
        {
            var pose = new Pose("Warrior One");

            Assert.AreEqual("Warrior One", pose.Name);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void should_not_create_for_Pose_null_Name()
        {
            var pose = new Pose(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void should_create_Pose_for_empty_Name()
        {
            var pose = new Pose(string.Empty);
        }
    }
}
