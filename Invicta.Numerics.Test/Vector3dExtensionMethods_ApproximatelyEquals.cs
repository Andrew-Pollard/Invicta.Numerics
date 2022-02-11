using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3dExtensionMethods_ApproximatelyEquals {

		[TestMethod]
		public void IdenticalVectors_AreEqual() {
			Assert.IsTrue(Vector3d.One.ApproximatelyEquals(Vector3d.One, epsilon: 0.01d));
		}

		[TestMethod]
		public void DifferentVectors_AreNotEqual() {
			Assert.IsFalse(Vector3d.Zero.ApproximatelyEquals(Vector3d.One, epsilon: 0.01d));
		}

		[TestMethod]
		public void LowEpsilon_CorrectlyInfluencesResult() {
			Assert.IsFalse(Vector3d.Zero.ApproximatelyEquals(Vector3d.UnitX, epsilon: 0.01d));
		}

		[TestMethod]
		public void HighEpsilon_CorrectlyInfluencesResult() {
			Assert.IsTrue(Vector3d.Zero.ApproximatelyEquals(Vector3d.UnitX, epsilon: 1.1d));
		}
	}
}
