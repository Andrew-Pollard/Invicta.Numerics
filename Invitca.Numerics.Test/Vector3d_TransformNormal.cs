using System.Numerics;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_TransformNormal {

		[TestMethod]
		public void TransformNormal_ProducesExpectedValue() {
			var Matrix = Matrix4x4.CreatePerspectiveFieldOfView(1.57f, 1.78f, 0.1f, 1000.0f);

			var Vectorf = Vector3.TransformNormal(new Vector3(1.0f, 2.0f, 3.0f), Matrix);
			var Vectord = Vector3d.TransformNormal(new Vector3d(1.0d, 2.0d, 3.0d), Matrix);

			Assert.IsTrue(Vectord.ApproximatelyEquals(Vectorf, 0.01));
		}
	}
}
