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
            var pose = new Pose(1, "Warrior One");

            Assert.AreEqual("Warrior One", pose.Name);
            Assert.AreEqual("[1] Warrior One", pose.ToString());
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void should_not_create_for_Pose_null_Name()
        {
            var pose = new Pose(0, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void should_create_Pose_for_empty_Name()
        {
            var pose = new Pose(0, string.Empty);
        }

        [TestMethod]
        public void should_compare_equal_Poses()
        {
            var pose1 = new Pose(1, "Warrior One");
            var pose2 = new Pose(1, "Warrior One");

            Assert.IsTrue(pose1.Equals(pose2));
            Assert.IsTrue(pose2.Equals(pose1));
        }

        [TestMethod]
        public void should_compare_Poses_different_Id()
        {
            var pose1 = new Pose(1, "Warrior One");
            var pose2 = new Pose(2, "Warrior One");

            Assert.IsFalse(pose1.Equals(pose2));
            Assert.IsFalse(pose2.Equals(pose1));
        }

        [TestMethod]
        public void should_compare_Poses_different_Name()
        {
            var pose1 = new Pose(1, "Warrior One");
            var pose2 = new Pose(1, "Warrior Two");

            Assert.IsFalse(pose1.Equals(pose2));
            Assert.IsFalse(pose2.Equals(pose1));
        }
    }
}
