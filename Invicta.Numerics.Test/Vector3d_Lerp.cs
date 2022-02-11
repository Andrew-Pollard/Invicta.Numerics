using System.Numerics;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Lerp {

		[TestMethod]
		public void Lerp_ProducesExpectedValue() {
			var Vectorf = Vector3.Lerp(new Vector3(1.0f, 2.0f, 3.0f), new Vector3(4.0f, 5.0f, 6.0f), 0.5f);
			var Vectord = Vector3d.Lerp(new Vector3d(1.0d, 2.0d, 3.0d), new Vector3d(4.0d, 5.0d, 6.0d), 0.5d);

			Assert.IsTrue(Vectord.ApproximatelyEquals(Vectorf, 0.01));
		}
	}
}
