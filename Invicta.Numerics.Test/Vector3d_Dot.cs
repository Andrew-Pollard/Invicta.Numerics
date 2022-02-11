using System;
using System.Numerics;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Dot {

		[TestMethod]
		public void Dot_ProducesExpectedValue() {
			var @float = Vector3.Dot(new Vector3(1.0f, 2.0f, 3.0f), new Vector3(4.0f, 5.0f, 6.0f));
			var @double = Vector3d.Dot(new Vector3d(1.0d, 2.0d, 3.0d), new Vector3d(4.0d, 5.0d, 6.0d));

			Assert.IsTrue(Math.Abs(@float - @double) < 1e-3);
		}
	}
}
