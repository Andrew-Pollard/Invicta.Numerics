using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Multiply {

		[TestMethod]
		public void MultiplyByVector_ProducesExpectedValue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = new Vector3d(4.0d, 5.0d, 6.0d);

			var C = Vector3d.Multiply(A, B);

			Assert.IsTrue(
				C.X == 1.0d * 4.0d &&
				C.Y == 2.0d * 5.0d &&
				C.Z == 3.0d * 6.0d
			);
		}

		[TestMethod]
		public void MultiplyByScalar_ProducesExpectedValue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = 4.0d;

			var C = Vector3d.Multiply(A, B);

			Assert.IsTrue(
				C.X == 1.0d * 4.0d &&
				C.Y == 2.0d * 4.0d &&
				C.Z == 3.0d * 4.0d
			);
		}

		[TestMethod]
		public void MultiplyByScalarReverse_ProducesExpectedValue() {
			var A = 4.0d;
			var B = new Vector3d(1.0d, 2.0d, 3.0d);

			var C = Vector3d.Multiply(A, B);

			Assert.IsTrue(
				C.X == 4.0d * 1.0d &&
				C.Y == 4.0d * 2.0d &&
				C.Z == 4.0d * 3.0d
			);
		}
	}
}
