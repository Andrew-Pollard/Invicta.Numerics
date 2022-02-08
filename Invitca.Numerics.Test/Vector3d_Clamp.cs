using System.Numerics;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Clamp {

		[TestMethod]
		public void Clamp_ProducesExpectedValue() {
			var Vectorf = Vector3.Clamp(new Vector3(0.0f, 2.0f, 7.0f), new Vector3(1.0f, 2.0f, 3.0f), new Vector3(4.0f, 5.0f, 6.0f));
			var Vectord = Vector3d.Clamp(new Vector3d(0.0d, 2.0d, 7.0d), new Vector3d(1.0d, 2.0d, 3.0d), new Vector3d(4.0d, 5.0d, 6.0d));

			Assert.IsTrue(Vectord.ApproximatelyEquals(Vectorf, 0.01));
		}
	}
}
