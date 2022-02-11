using System.Numerics;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Normalize {

		[TestMethod]
		public void Normalize_ProducesExpectedValue() {
			var Vectorf = Vector3.Normalize(new Vector3(1.0f, 2.0f, 3.0f));
			var Vectord = Vector3d.Normalize(new Vector3d(1.0d, 2.0d, 3.0d));

			Assert.IsTrue(Vectord.ApproximatelyEquals(Vectorf, 0.01));
		}
	}
}
