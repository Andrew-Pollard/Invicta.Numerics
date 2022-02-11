using System.Numerics;


namespace Invicta.Numerics {

	/// <summary>
	/// A structure encapsulating three double precision floating point values.
	/// </summary>
	public struct Vector3d : IEquatable<Vector3d> {
		/// <summary>
		/// Returns the vector (0,0,0).
		/// </summary>
		public static Vector3d Zero => new();

		/// <summary>
		/// Returns the vector (1,1,1).
		/// </summary>
		public static Vector3d One => new(1.0d, 1.0d, 1.0d);

		/// <summary>
		/// Returns the vector (1,0,0).
		/// </summary>
		public static Vector3d UnitX => new(1.0d, 0.0d, 0.0d);
		/// <summary>
		/// Returns the vector (0,1,0).
		/// </summary>
		public static Vector3d UnitY => new(0.0d, 1.0d, 0.0d);
		/// <summary>
		/// Returns the vector (0,0,1).
		/// </summary>
		public static Vector3d UnitZ => new(0.0d, 0.0d, 1.0d);

		/// <summary>
		/// The X component of the vector.
		/// </summary>
		public double X;
		/// <summary>
		/// The Y component of the vector.
		/// </summary>
		public double Y;
		/// <summary>
		/// The Z component of the vector.
		/// </summary>
		public double Z;


		/// <summary>
		/// Constructs a vector whose elements are all the single specified value.
		/// </summary>
		/// <param name="value">The element to fill the vector with.</param>
		public Vector3d(double value) : this(value, value, value) { }

		/// <summary>
		/// Constructs a vector with the given individual elements.
		/// </summary>
		/// <param name="x">The X component.</param>
		/// <param name="y">The Y component.</param>
		/// <param name="z">The Z component.</param>
		public Vector3d(double x, double y, double z) {
			X = x;
			Y = y;
			Z = z;
		}

		/// <summary>
		/// Returns the dot product of two vectors.
		/// </summary>
		/// <param name="left">The first vector.</param>
		/// <param name="right">The second vector.</param>
		/// <returns>The dot product.</returns>
		public static double Dot(Vector3d left, Vector3d right) {
			return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
		}

		/// <summary>
		/// Returns a vector whose elements are the minimum of each of the pairs of elements in the two source vectors.
		/// </summary>
		/// <param name="left">The first source vector.</param>
		/// <param name="right">The second source vector.</param>
		/// <returns>The minimized vector.</returns>
		public static Vector3d Min(Vector3d left, Vector3d right) {
			return new Vector3d(
				left.X < right.X ? left.X : right.X,
				left.Y < right.Y ? left.Y : right.Y,
				left.Z < right.Z ? left.Z : right.Z
			);
		}

		/// <summary>
		/// Returns a vector whose elements are the maximum of each of the pairs of elements in the two source vectors.
		/// </summary>
		/// <param name="left">The first source vector.</param>
		/// <param name="right">The second source vector.</param>
		/// <returns>The maximized vector.</returns>
		public static Vector3d Max(Vector3d left, Vector3d right) {
			return new Vector3d(
				left.X > right.X ? left.X : right.X,
				left.Y > right.Y ? left.Y : right.Y,
				left.Z > right.Z ? left.Z : right.Z
			);
		}

		/// <summary>
		/// Returns a vector whose elements are the absolute values of each of the source vector's elements.
		/// </summary>
		/// <param name="vector">The source vector.</param>
		/// <returns>The absolute value vector.</returns>
		public static Vector3d Abs(Vector3d vector) {
			return new Vector3d(
				Math.Abs(vector.X),
				Math.Abs(vector.Y),
				Math.Abs(vector.Z)
			);
		}

		/// <summary>
		/// Returns a vector whose elements are the square root of each of the source vector's elements.
		/// </summary>
		/// <param name="vector">The source vector.</param>
		/// <returns>The square root vector.</returns>
		public static Vector3d SquareRoot(Vector3d vector) {
			return new Vector3d(
				Math.Sqrt(vector.X),
				Math.Sqrt(vector.Y),
				Math.Sqrt(vector.Z)
			);
		}


		/// <summary>
		/// Returns the length of the vector.
		/// </summary>
		/// <returns>The vector's length.</returns>
		public double Length() {
			return Math.Sqrt(X * X + Y * Y + Z * Z);
		}

		/// <summary>
		/// Returns the length of the vector squared. This operation is cheaper than Length().
		/// </summary>
		/// <returns>The vector's length squared.</returns>
		public double LengthSquared() {
			return X * X + Y * Y + Z * Z;
		}

		/// <summary>
		/// Returns the Euclidean distance between the two given points.
		/// </summary>
		/// <param name="left">The first point.</param>
		/// <param name="right">The second point.</param>
		/// <returns>The distance.</returns>
		public static double Distance(Vector3d left, Vector3d right) {
			double dx = left.X - right.X;
			double dy = left.Y - right.Y;
			double dz = left.Z - right.Z;

			return Math.Sqrt(dx * dx + dy * dy + dz * dz);
		}

		/// <summary>
		/// Returns the Euclidean distance squared between the two given points.
		/// </summary>
		/// <param name="left">The first point.</param>
		/// <param name="right">The second point.</param>
		/// <returns>The distance squared.</returns>
		public static double DistanceSquared(Vector3d left, Vector3d right) {
			double dx = left.X - right.X;
			double dy = left.Y - right.Y;
			double dz = left.Z - right.Z;

			return dx * dx + dy * dy + dz * dz;
		}

		/// <summary>
		/// Returns a vector with the same direction as the given vector, but with a length of 1.
		/// </summary>
		/// <param name="vector">The vector to normalize.</param>
		/// <returns>The normalized vector.</returns>
		public static Vector3d Normalize(Vector3d vector) {
			return vector / vector.Length();
		}

		/// <summary>
		/// Computes the cross product of two vectors.
		/// </summary>
		/// <param name="left">The first vector.</param>
		/// <param name="right">The second vector.</param>
		/// <returns>The cross product.</returns>
		public static Vector3d Cross(Vector3d left, Vector3d right) {
			return new Vector3d(
				left.Y * right.Z - left.Z * right.Y,
				left.Z * right.X - left.X * right.Z,
				left.X * right.Y - left.Y * right.X
			);
		}

		/// <summary>
		/// Returns the reflection of a vector off a surface that has the specified normal.
		/// </summary>
		/// <param name="vector">The source vector.</param>
		/// <param name="normal">The normal of the surface being reflected off.</param>
		/// <returns>The reflected vector.</returns>
		public static Vector3d Reflect(Vector3d vector, Vector3d normal) {
			return vector - (normal * Dot(vector, normal) * 2.0d);
		}

		/// <summary>
		/// Restricts a vector between a min and max value.
		/// </summary>
		/// <param name="vector">The source vector.</param>
		/// <param name="min">The minimum value.</param>
		/// <param name="max">The maximum value.</param>
		/// <returns>The restricted vector.</returns>
		public static Vector3d Clamp(Vector3d vector, Vector3d min, Vector3d max) {
			double x = vector.X;
			x = (x > max.X) ? max.X : x;
			x = (x < min.X) ? min.X : x;

			double y = vector.Y;
			y = (y > max.Y) ? max.Y : y;
			y = (y < min.Y) ? min.Y : y;

			double z = vector.Z;
			z = (z > max.Z) ? max.Z : z;
			z = (z < min.Z) ? min.Z : z;

			return new Vector3d(x, y, z);
		}

		/// <summary>
		/// Linearly interpolates between two vectors based on the given weighting.
		/// </summary>
		/// <param name="left">The first source vector.</param>
		/// <param name="right">The second source vector.</param>
		/// <param name="amount">Value between 0 and 1 indicating the weight of the second source vector.</param>
		/// <returns>The interpolated vector.</returns>
		public static Vector3d Lerp(Vector3d start, Vector3d end, double amount) {
			return new Vector3d(
				start.X + (end.X - start.X) * amount,
				start.Y + (end.Y - start.Y) * amount,
				start.Z + (end.Z - start.Z) * amount
			);
		}

		/// <summary>
		/// Transforms a vector by the given matrix.
		/// </summary>
		/// <param name="position">The source vector.</param>
		/// <param name="matrix">The transformation matrix.</param>
		/// <returns>The transformed vector.</returns>
		public static Vector3d Transform(Vector3d position, Matrix4x4 matrix) {
			return new Vector3d(
				position.X * matrix.M11 + position.Y * matrix.M21 + position.Z * matrix.M31 + matrix.M41,
				position.X * matrix.M12 + position.Y * matrix.M22 + position.Z * matrix.M32 + matrix.M42,
				position.X * matrix.M13 + position.Y * matrix.M23 + position.Z * matrix.M33 + matrix.M43
			);
		}

		/// <summary>
		/// Transforms a vector normal by the given matrix.
		/// </summary>
		/// <param name="normal">The source vector.</param>
		/// <param name="matrix">The transformation matrix.</param>
		/// <returns>The transformed vector.</returns>
		public static Vector3d TransformNormal(Vector3d normal, Matrix4x4 matrix) {
			return new Vector3d(
				normal.X * matrix.M11 + normal.Y * matrix.M21 + normal.Z * matrix.M31,
				normal.X * matrix.M12 + normal.Y * matrix.M22 + normal.Z * matrix.M32,
				normal.X * matrix.M13 + normal.Y * matrix.M23 + normal.Z * matrix.M33
			);
		}

		/// <summary>
		/// Transforms a vector by the given Quaternion rotation value.
		/// </summary>
		/// <param name="value">The source vector to be rotated.</param>
		/// <param name="rotation">The rotation to apply.</param>
		/// <returns>The transformed vector.</returns>
		public static Vector3d Transform(Vector3d value, Quaternion rotation) {
			float x2 = rotation.X + rotation.X;
			float y2 = rotation.Y + rotation.Y;
			float z2 = rotation.Z + rotation.Z;

			float wx2 = rotation.W * x2;
			float wy2 = rotation.W * y2;
			float wz2 = rotation.W * z2;
			float xx2 = rotation.X * x2;
			float xy2 = rotation.X * y2;
			float xz2 = rotation.X * z2;
			float yy2 = rotation.Y * y2;
			float yz2 = rotation.Y * z2;
			float zz2 = rotation.Z * z2;

			return new Vector3d(
				value.X * (1.0f - yy2 - zz2) + value.Y * (xy2 - wz2) + value.Z * (xz2 + wy2),
				value.X * (xy2 + wz2) + value.Y * (1.0f - xx2 - zz2) + value.Z * (yz2 - wx2),
				value.X * (xz2 - wy2) + value.Y * (yz2 + wx2) + value.Z * (1.0f - xx2 - yy2)
			);
		}

		/// <summary>
		/// Adds two vectors together.
		/// </summary>
		/// <param name="left">The first source vector.</param>
		/// <param name="right">The second source vector.</param>
		/// <returns>The summed vector.</returns>
		public static Vector3d Add(Vector3d left, Vector3d right) {
			return left + right;
		}

		/// <summary>
		/// Subtracts the second vector from the first.
		/// </summary>
		/// <param name="left">The first source vector.</param>
		/// <param name="right">The second source vector.</param>
		/// <returns>The difference vector.</returns>
		public static Vector3d Subtract(Vector3d left, Vector3d right) {
			return left - right;
		}

		/// <summary>
		/// Multiplies two vectors together.
		/// </summary>
		/// <param name="left">The first source vector.</param>
		/// <param name="right">The second source vector.</param>
		/// <returns>The product vector.</returns>
		public static Vector3d Multiply(Vector3d left, Vector3d right) {
			return left * right;
		}

		/// <summary>
		/// Multiplies a vector by the given scalar.
		/// </summary>
		/// <param name="left">The source vector.</param>
		/// <param name="right">The scalar value.</param>
		/// <returns>The scaled vector.</returns>
		public static Vector3d Multiply(Vector3d left, double right) {
			return left * right;
		}

		/// <summary>
		/// Multiplies a vector by the given scalar.
		/// </summary>
		/// <param name="left">The scalar value.</param>
		/// <param name="right">The source vector.</param>
		/// <returns>The scaled vector.</returns>
		public static Vector3d Multiply(double left, Vector3d right) {
			return left * right;
		}

		/// <summary>
		/// Divides the first vector by the second.
		/// </summary>
		/// <param name="left">The first source vector.</param>
		/// <param name="right">The second source vector.</param>
		/// <returns>The vector resulting from the division.</returns>
		public static Vector3d Divide(Vector3d left, Vector3d right) {
			return left / right;
		}

		/// <summary>
		/// Divides the vector by the given scalar.
		/// </summary>
		/// <param name="left">The source vector.</param>
		/// <param name="divisor">The scalar value.</param>
		/// <returns>The result of the division.</returns>
		public static Vector3d Divide(Vector3d left, double divisor) {
			return left / divisor;
		}

		/// <summary>
		/// Negates a given vector.
		/// </summary>
		/// <param name="value">The source vector.</param>
		/// <returns>The negated vector.</returns>
		public static Vector3d Negate(Vector3d value) {
			return -value;
		}

		/// <summary>
		/// Adds two vectors together.
		/// </summary>
		/// <param name="left">The first source vector.</param>
		/// <param name="right">The second source vector.</param>
		/// <returns>The summed vector.</returns>
		public static Vector3d operator +(Vector3d left, Vector3d right) {
			return new Vector3d(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
		}

		/// <summary>
		/// Subtracts the second vector from the first.
		/// </summary>
		/// <param name="left">The first source vector.</param>
		/// <param name="right">The second source vector.</param>
		/// <returns>The difference vector.</returns>
		public static Vector3d operator -(Vector3d left, Vector3d right) {
			return new Vector3d(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
		}

		/// <summary>
		/// Multiplies two vectors together.
		/// </summary>
		/// <param name="left">The first source vector.</param>
		/// <param name="right">The second source vector.</param>
		/// <returns>The product vector.</returns>
		public static Vector3d operator *(Vector3d left, Vector3d right) {
			return new Vector3d(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
		}

		/// <summary>
		/// Multiplies a vector by the given scalar.
		/// </summary>
		/// <param name="vector">The source vector.</param>
		/// <param name="scalar">The scalar value.</param>
		/// <returns>The scaled vector.</returns>
		public static Vector3d operator *(Vector3d vector, double scalar) {
			return new Vector3d(vector.X * scalar, vector.Y * scalar, vector.Z * scalar);
		}

		/// <summary>
		/// Multiplies a vector by the given scalar.
		/// </summary>
		/// <param name="scalar">The scalar value.</param>
		/// <param name="vector">The source vector.</param>
		/// <returns>The scaled vector.</returns>
		public static Vector3d operator *(double scalar, Vector3d vector) {
			return new Vector3d(vector.X * scalar, vector.Y * scalar, vector.Z * scalar);
		}

		/// <summary>
		/// Divides the first vector by the second.
		/// </summary>
		/// <param name="left">The first source vector.</param>
		/// <param name="right">The second source vector.</param>
		/// <returns>The vector resulting from the division.</returns>
		public static Vector3d operator /(Vector3d left, Vector3d right) {
			return new Vector3d(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
		}

		/// <summary>
		/// Divides the vector by the given scalar.
		/// </summary>
		/// <param name="vector">The source vector.</param>
		/// <param name="scalar">The scalar value.</param>
		/// <returns>The result of the division.</returns>
		public static Vector3d operator /(Vector3d vector, double scalar) {
			return new Vector3d(vector.X / scalar, vector.Y / scalar, vector.Z / scalar);
		}

		/// <summary>
		/// Negates a given vector.
		/// </summary>
		/// <param name="vector">The source vector.</param>
		/// <returns>The negated vector.</returns>
		public static Vector3d operator -(Vector3d vector) {
			return new Vector3d(-vector.X, -vector.Y, -vector.Z);
		}

		/// <summary>
		/// Returns a boolean indicating whether the two given vectors are equal.
		/// </summary>
		/// <param name="left">The first vector to compare.</param>
		/// <param name="right">The second vector to compare.</param>
		/// <returns>True if the vectors are equal; False otherwise.</returns>
		public static bool operator ==(Vector3d left, Vector3d right) {
			return left.Equals(right);
		}

		/// <summary>
		/// Returns a boolean indicating whether the two given vectors are not equal.
		/// </summary>
		/// <param name="left">The first vector to compare.</param>
		/// <param name="right">The second vector to compare.</param>
		/// <returns>True if the vectors are not equal; False if they are equal.</returns>
		public static bool operator !=(Vector3d left, Vector3d right) {
			return !(left == right);
		}

		/// <summary>
		/// Copies the contents of the vector into the given array.
		/// </summary>
		public void CopyTo(double[] array) {
			CopyTo(array, 0);
		}

		/// <summary>
		/// Copies the contents of the vector into the given array, starting from index.
		/// </summary>
		/// <exception cref="ArgumentNullException">If array is null.</exception>
		/// <exception cref="RankException">If array is multidimensional.</exception>
		/// <exception cref="ArgumentOutOfRangeException">If index is greater than end of the array or index is less than zero.</exception>
		/// <exception cref="ArgumentException">If number of elements in source vector is greater than those available in destination array.</exception>
		public void CopyTo(double[] array, int index) {
			if (array == null)
				throw new NullReferenceException(nameof(array));

			if (index < 0 || index >= array.Length)
				throw new ArgumentOutOfRangeException(nameof(index));

			if ((array.Length - index) < 3)
				throw new ArgumentException(nameof(array));

			array[index] = X;
			array[index + 1] = Y;
			array[index + 2] = Z;
		}

		/// <summary>
		/// Implicitly convert a given single precision Vector3 into a double precision Vector3d.
		/// </summary>
		/// <param name="vector">The single precision Vector3 to convert.</param>
		public static implicit operator Vector3d(Vector3 vector) {
			return new Vector3d(vector.X, vector.Y, vector.Z);
		}

		/// <summary>
		/// Explicitely convert a given double precision Vector3d into a single precision Vector3.
		/// </summary>
		/// <remarks>
		/// This conversion is lossy so is made explicit.
		/// </remarks>
		/// <param name="vector">The double precision Vector3d to convert.</param>
		public static explicit operator Vector3(Vector3d vector) {
			return new Vector3((float) vector.X, (float) vector.Y, (float) vector.Z);
		}


		/// <summary>
		/// Returns a boolean indicating whether the given Object is equal to this Vector3 instance.
		/// </summary>
		/// <param name="obj">The Object to compare against.</param>
		/// <returns>True if the Object is equal to this Vector3; False otherwise.</returns>
		public override bool Equals(object? obj) {
			return obj is Vector3d d && Equals(d);
		}

		/// <summary>
		/// Returns a boolean indicating whether the given Vector3 is equal to this Vector3 instance.
		/// </summary>
		/// <param name="other">The Vector3 to compare this instance to.</param>
		/// <returns>True if the other Vector3 is equal to this instance; False otherwise.</returns>
		public bool Equals(Vector3d other) {
			return X == other.X &&
				   Y == other.Y &&
				   Z == other.Z;
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		/// <returns>The hash code.</returns>
		public override int GetHashCode() {
			return HashCode.Combine(X, Y, Z);
		}

		/// <summary>
		/// Returns a String representing this Vector3 instance.
		/// </summary>
		/// <returns>The string representation.</returns>
		public override string ToString() {
			return $"<{X}, {Y}, {Z}>";
		}
	}
}
