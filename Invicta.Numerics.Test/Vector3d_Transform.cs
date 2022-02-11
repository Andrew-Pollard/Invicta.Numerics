using System.Numerics;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Transform {

		[TestMethod]
		public void TransformWithMatrix_ProducesExpectedValue() {
			var Matrix = Matrix4x4.CreatePerspectiveFieldOfView(1.57f, 1.78f, 0.1f, 1000.0f);

			var Vectorf = Vector3.Transform(new Vector3(1.0f, 2.0f, 3.0f), Matrix);
			var Vectord = Vector3d.Transform(new Vector3d(1.0d, 2.0d, 3.0d), Matrix);

			Assert.IsTrue(Vectord.ApproximatelyEquals(Vectorf, 0.01));
		}

		[TestMethod]
		public void TransformWithQuaternion_ProducesExpectedValue() {
			var Quat = Quaternion.CreateFromYawPitchRoll(30.0f, 60.0f, 90.0f);

			var Vectorf = Vector3.Transform(new Vector3(1.0f, 2.0f, 3.0f), Quat);
			var Vectord = Vector3d.Transform(new Vector3d(1.0d, 2.0d, 3.0d), Quat);

			Assert.IsTrue(Vectord.ApproximatelyEquals(Vectorf, 0.01));
		}
	}
}
