﻿using System;
using System.Numerics;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_LengthSquared {

		[TestMethod]
		public void LengthSquared_ProducesExpectedValue() {
			var @float = new Vector3(1.0f, 2.0f, 3.0f).LengthSquared();
			var @double = new Vector3d(1.0d, 2.0d, 3.0d).LengthSquared();

			Assert.IsTrue(Math.Abs(@float - @double) < 1e-3);
		}
	}
}
