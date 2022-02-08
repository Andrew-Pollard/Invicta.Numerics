using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_CopyTo {

		[TestMethod]
		public void CopyToWithNullArray_ThrowsNullReferenceException() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
			Assert.ThrowsException<NullReferenceException>(() => A.CopyTo(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
		}

		[TestMethod]
		public void CopyToWithNegativeIndex_ThrowsArgumentOutOfRangeException() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);

			double[] Array = new double[3];

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => A.CopyTo(Array, -1));
		}

		[TestMethod]
		public void CopyToWithOutOfBoundsIndex_ThrowsArgumentOutOfRangeException() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);

			double[] Array = new double[3];

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => A.CopyTo(Array, 4));
		}

		[TestMethod]
		public void CopyToWithTooSmallArray_ThrowsArgumentOutOfRangeException() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);

			double[] Array = System.Array.Empty<double>();

			Assert.ThrowsException<ArgumentOutOfRangeException>(() => A.CopyTo(Array));
		}

		[TestMethod]
		public void CopyToWithGoodParameters_CopiesAsExpected() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);

			double[] Array = new double[4];

			A.CopyTo(Array, 1);

			Assert.IsTrue(
				Array[1] == A.X &&
				Array[2] == A.Y &&
				Array[3] == A.Z
			);
		}
	}
}
