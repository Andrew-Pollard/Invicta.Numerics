using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_StaticProperties {

		[TestMethod]
		public void ZeroProperty_ContainsExpectedValues() {
			Assert.IsTrue(
				Vector3d.Zero.X == 0.0d &&
				Vector3d.Zero.Y == 0.0d &&
				Vector3d.Zero.Z == 0.0d
			);
		}

		[TestMethod]
		public void OneProperty_ContainsExpectedValues() {
			Assert.IsTrue(
				Vector3d.One.X == 1.0d &&
				Vector3d.One.Y == 1.0d &&
				Vector3d.One.Z == 1.0d
			);
		}

		[TestMethod]
		public void UnitXProperty_ContainsExpectedValues() {
			Assert.IsTrue(
				Vector3d.UnitX.X == 1.0d &&
				Vector3d.UnitX.Y == 0.0d &&
				Vector3d.UnitX.Z == 0.0d
			);
		}

		[TestMethod]
		public void UnitYProperty_ContainsExpectedValues() {
			Assert.IsTrue(
				Vector3d.UnitY.X == 0.0d &&
				Vector3d.UnitY.Y == 1.0d &&
				Vector3d.UnitY.Z == 0.0d
			);
		}

		[TestMethod]
		public void UnitZProperty_ContainsExpectedValues() {
			Assert.IsTrue(
				Vector3d.UnitZ.X == 0.0d &&
				Vector3d.UnitZ.Y == 0.0d &&
				Vector3d.UnitZ.Z == 1.0d
			);
		}
	}
}
