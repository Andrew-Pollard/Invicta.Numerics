namespace Invicta.Numerics {

	/// <summary>
	/// Generally useful extensions not contained in the original <see cref="System.Numerics.Vector3"/> interface
	/// that <see cref="Vector3d"/> was based on.
	/// </summary>
	public static class Vector3dExtensionMethods {

		/// <summary>
		/// Returns if two vectors are within epsilon of each other.
		/// </summary>
		/// <param name="left">The first vector.</param>
		/// <param name="right">The second vector.</param>
		/// <param name="epsilon">The distance threshold between vectors.</param>
		/// <returns>If the two vectors are within epsilon of each other.</returns>
		public static bool ApproximatelyEquals(this Vector3d left, Vector3d right, double epsilon) {
			return Vector3d.Distance(left, right) < epsilon;
		}


		/// <summary>
		/// Returns if the vector contains one or more <see cref="double.NaN"/> values.
		/// </summary>
		/// <param name="vec">The vector to examine.</param>
		/// <returns>If the vector contains one or more <see cref="double.NaN"/> values.</returns>
		public static bool HasNaN(this Vector3d vec) {
			return double.IsNaN(vec.X) || double.IsNaN(vec.Y) || double.IsNaN(vec.Z);
		}


		/// <summary>
		/// Returns if the vector contains one or more <see cref="double.PositiveInfinity"/> or <see cref="double.NegativeInfinity"/> values.
		/// </summary>
		/// <param name="vec">The vector to examine.</param>
		/// <returns>If the vector contains one or more <see cref="double.PositiveInfinity"/> or <see cref="double.NegativeInfinity"/> values.</returns>
		public static bool HasInfinity(this Vector3d vec) {
			return double.IsInfinity(vec.X) || double.IsInfinity(vec.Y) || double.IsInfinity(vec.Z);
		}
	}
}