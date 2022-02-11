using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Equals {

		[TestMethod]
		public void IEquatableEqualsWithSameObject_ReturnsTrue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);

			Assert.IsTrue(A.Equals(A));
		}

		[TestMethod]
		public void IEquatableEqualsWithIdenticalVectors_ReturnsTrue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = new Vector3d(1.0d, 2.0d, 3.0d);

			Assert.IsTrue(A.Equals(B));
		}

		[TestMethod]
		public void IEquatableEqualsWithDifferentVectors_ReturnsFalse() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = new Vector3d(4.0d, 5.0d, 6.0d);

			Assert.IsFalse(A.Equals(B));
		}


		[TestMethod]
		public void EqualsWithSameObject_ReturnsTrue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);

			Assert.IsTrue(A.Equals((object) A));
		}

		[TestMethod]
		public void EqualsWithIdenticalVectors_ReturnsTrue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = (object) new Vector3d(1.0d, 2.0d, 3.0d);

			Assert.IsTrue(A.Equals(B));
		}

		[TestMethod]
		public void EqualsWithDifferentVectors_ReturnsFalse() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = (object) new Vector3d(4.0d, 5.0d, 6.0d);

			Assert.IsFalse(A.Equals(B));
		}
	}
}
