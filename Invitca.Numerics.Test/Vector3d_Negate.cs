using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Negate {

		[TestMethod]
		public void Negate_ProducesExpectedValue() {
			var A = Vector3d.Negate(new Vector3d(1.0d, 2.0d, 3.0d));

			Assert.IsTrue(
				A.X == -1.0d &&
				A.Y == -2.0d &&
				A.Z == -3.0d
			);
		}
	}
}
