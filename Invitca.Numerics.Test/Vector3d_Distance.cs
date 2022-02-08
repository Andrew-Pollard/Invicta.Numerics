﻿using System;
using System.Numerics;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Invicta.Numerics.Test {

	[TestClass]
	public class Vector3d_Distance {

		[TestMethod]
		public void Distance_ProducesExpectedValue() {
			var @float = Vector3.Distance(new Vector3(1.0f, 2.0f, 3.0f), new Vector3(4.0f, 5.0f, 6.0f));
			var @double = Vector3d.Distance(new Vector3d(1.0f, 2.0f, 3.0f), new Vector3d(4.0f, 5.0f, 6.0f));

			Assert.IsTrue(Math.Abs(@float - @double) < 1e-3);
		}
	}
}
