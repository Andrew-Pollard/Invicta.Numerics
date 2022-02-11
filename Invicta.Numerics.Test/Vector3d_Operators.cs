using System;
using System.Numerics;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Operators {

		[TestMethod]
		public void AdditionOperator_ProducesExpectedValue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = new Vector3d(4.0d, 5.0d, 6.0d);

			Assert.IsTrue(
				(A + B).X == 1.0d + 4.0d &&
				(A + B).Y == 2.0d + 5.0d &&
				(A + B).Z == 3.0d + 6.0d
			);
		}


		[TestMethod]
		public void SubtractionOperator_ProducesExpectedValue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = new Vector3d(4.0d, 5.0d, 6.0d);

			Assert.IsTrue(
				(A - B).X == 1.0d - 4.0d &&
				(A - B).Y == 2.0d - 5.0d &&
				(A - B).Z == 3.0d - 6.0d
			);
		}


		[TestMethod]
		public void MultiplicationOperatorWithVector_ProducesExpectedValue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = new Vector3d(4.0d, 5.0d, 6.0d);

			Assert.IsTrue(
				(A * B).X == 1.0d * 4.0d &&
				(A * B).Y == 2.0d * 5.0d &&
				(A * B).Z == 3.0d * 6.0d
			);
		}

		[TestMethod]
		public void MultiplicationOperatorWithScalar_ProducesExpectedValue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = 4.0d;

			Assert.IsTrue(
				(A * B).X == 1.0d * 4.0d &&
				(A * B).Y == 2.0d * 4.0d &&
				(A * B).Z == 3.0d * 4.0d
			);
		}

		[TestMethod]
		public void MultiplicationOperatorWithScalarReverse_ProducesExpectedValue() {
			var A = 4.0d;
			var B = new Vector3d(1.0d, 2.0d, 3.0d);

			Assert.IsTrue(
				(A * B).X == 4.0d * 1.0d &&
				(A * B).Y == 4.0d * 2.0d &&
				(A * B).Z == 4.0d * 3.0d
			);
		}


		[TestMethod]
		public void DivisionOperatorWithVector_ProducesExpectedValue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = new Vector3d(4.0d, 5.0d, 6.0d);

			Assert.IsTrue(
				(A / B).X == 1.0d / 4.0d &&
				(A / B).Y == 2.0d / 5.0d &&
				(A / B).Z == 3.0d / 6.0d
			);
		}

		[TestMethod]
		public void DivisionOperatorWithScalar_ProducesExpectedValue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = 4.0d;

			Assert.IsTrue(
				(A / B).X == 1.0d / 4.0d &&
				(A / B).Y == 2.0d / 4.0d &&
				(A / B).Z == 3.0d / 4.0d
			);
		}


		[TestMethod]
		public void NegationOperatorWithScalar_ProducesExpectedValue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);

			Assert.IsTrue(
				(-A).X == -1.0d &&
				(-A).Y == -2.0d &&
				(-A).Z == -3.0d
			);
		}


		[TestMethod]
		public void EqualityOperatorWithIdenticalVectors_ReturnsTrue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = new Vector3d(1.0d, 2.0d, 3.0d);

			Assert.IsTrue(A == B);
		}

		[TestMethod]
		public void EqualityOperatorWithDifferentVectors_ReturnsFalse() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = new Vector3d(4.0d, 5.0d, 6.0d);

			Assert.IsFalse(A == B);
		}


		[TestMethod]
		public void InequalityOperatorWithIdenticalVectors_ReturnsFalse() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = new Vector3d(1.0d, 2.0d, 3.0d);

			Assert.IsFalse(A != B);
		}

		[TestMethod]
		public void InequalityOperatorWithDifferentVectors_ReturnsTrue() {
			var A = new Vector3d(1.0d, 2.0d, 3.0d);
			var B = new Vector3d(4.0d, 5.0d, 6.0d);

			Assert.IsTrue(A != B);
		}


		[TestMethod]
		public void ImplicitCastFromVector3ToVector3d_ProducesExpectedValue() {
			Vector3 Vectorf = new(1.0f, 2.0f, 3.0f);

			Vector3d Vectord = Vectorf;

			Assert.IsTrue(
				Math.Abs(Vectorf.X - Vectord.X) < 1e-3 &&
				Math.Abs(Vectorf.Y - Vectord.Y) < 1e-3 &&
				Math.Abs(Vectorf.Z - Vectord.Z) < 1e-3
			);
		}

		[TestMethod]
		public void ExplicitCastFromVector3dToVector3_ProducesExpectedValue() {
			Vector3d Vectord = new(1.0d, 2.0d, 3.0d);

			Vector3 Vectorf = (Vector3) Vectord;

			Assert.IsTrue(
				Math.Abs(Vectorf.X - Vectord.X) < 1e-3 &&
				Math.Abs(Vectorf.Y - Vectord.Y) < 1e-3 &&
				Math.Abs(Vectorf.Z - Vectord.Z) < 1e-3
			);
		}
	}
}
