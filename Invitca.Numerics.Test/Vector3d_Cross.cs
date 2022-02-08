using System.Numerics;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Cross {

		[TestMethod]
		public void Cross_ProducesExpectedValue() {
			var Vectorf = Vector3.Cross(new Vector3(1.0f, 2.0f, 3.0f), new Vector3(4.0f, 5.0f, 6.0f));
			var Vectord = Vector3d.Cross(new Vector3d(1.0d, 2.0d, 3.0d), new Vector3d(4.0d, 5.0d, 6.0d));

			Assert.IsTrue(Vectord.ApproximatelyEquals(Vectorf, 0.01));
		}
	}
}
