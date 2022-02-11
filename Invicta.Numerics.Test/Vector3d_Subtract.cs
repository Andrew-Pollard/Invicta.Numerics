using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Subtract {

		[TestMethod]
		public void Subtract_ProducesExpectedValue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = new Vector3d(4.0d, 5.0d, 6.0d);

			var C = Vector3d.Subtract(A, B);

			Assert.IsTrue(
				C.X == 1.0d - 4.0d &&
				C.Y == 2.0d - 5.0d &&
				C.Z == 3.0d - 6.0d
			);
		}
	}
}
