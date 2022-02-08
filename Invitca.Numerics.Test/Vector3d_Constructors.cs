using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Constructors {

		[TestMethod]
		public void SingleValueConstructor_CreatesExpectedValues() {
			var Vector = new Vector3d(1.0d);

			Assert.IsTrue(
				Vector.X == 1.0d &&
				Vector.Y == 1.0d &&
				Vector.Z == 1.0d
			);
		}

		[TestMethod]
		public void TripleValueConstructor_CreatesExpectedValues() {
			var Vector = new Vector3d(1.0d, 2.0d, 3.0d);

			Assert.IsTrue(
				Vector.X == 1.0d &&
				Vector.Y == 2.0d &&
				Vector.Z == 3.0d
			);
		}
	}
}
