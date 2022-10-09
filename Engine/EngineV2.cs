

using System.Numerics;
using System;

namespace Engine
{
	public struct V2
	{
		public const float kEpsilon = .0001f;

		public float X;
		public float Y;

		public float SqrMagnitude => X * X + Y * Y;
		public float Magnitude => FMath.Sqrt(SqrMagnitude);

		public V2 Normalised => this / FMath.Sqrt(SqrMagnitude);

		readonly static V2 zero = new V2(0F, 0F);

		public static V2 Zero => zero;

		public V2(float X, float Y)
		{
			this.X = X;
			this.Y = Y;
		}

		public static V2 Interp(V2 L, V2 R, float Alpha)
		{
			return new V2(
				(float)Math.Ceiling(L.X + (R.X - L.X) * Alpha),
				(float)Math.Ceiling(L.Y + (R.Y - L.Y) * Alpha)
			);
		}

		public static V2 Smooth(V2 Current, V2 Target, ref V2 Velocity, float Time, float MaxDelta, float DeltaTime)
		{
			FMath.ClampMin(ref Time, kEpsilon);
			float Omega = 2F / Time;

			float X = Omega * DeltaTime;
			float Exp = 1F / (1F + X + .48F * X * X + .235F * X * X * X);

			float DeltaX = Current.X - Target.X;
			float DeltaY = Current.Y - Target.Y;
			V2 OriginalTarget = Target;

			float MaxDeltaMagnitude = MaxDelta * Time;
			float MaxDeltaSquared = MaxDeltaMagnitude * MaxDeltaMagnitude;
			float DeltaSquared = DeltaX * DeltaX + DeltaY * DeltaY;

			if (DeltaSquared > MaxDeltaSquared)
			{
				float Magnitude = FMath.Sqrt(DeltaSquared);
				float RMagnitude = 1F / Magnitude;
				DeltaX = DeltaX * RMagnitude * MaxDeltaMagnitude;
				DeltaY = DeltaY * RMagnitude * MaxDeltaMagnitude;
			}

			Target.X = Current.X - DeltaX;
			Target.Y = Current.Y - DeltaY;

			float TX = (Velocity.X + Omega * DeltaX) * DeltaTime;
			float TY = (Velocity.Y + Omega * DeltaY) * DeltaTime;

			Velocity.X = (Velocity.X - Omega * TX) * Exp;
			Velocity.Y = (Velocity.Y - Omega * TY) * Exp;

			float OX = Target.X + (DeltaX + TX) * Exp;
			float OY = Target.Y + (DeltaY + TY) * Exp;

			float DeltaOriginX = OriginalTarget.X - Current.X;
			float DeltaOriginY = OriginalTarget.Y - Current.Y;

			float DeltaCurrentX = OX - OriginalTarget.X;
			float DeltaCurrentY = OY - OriginalTarget.Y;

			if (DeltaOriginX * DeltaCurrentX + DeltaOriginY * DeltaCurrentY > 0)
			{
				OX = OriginalTarget.X;
				OY = OriginalTarget.Y;

				float RDeltaTime = 1f / DeltaTime;
				Velocity.X = (OX - OriginalTarget.X) * RDeltaTime;
				Velocity.Y = (OY - OriginalTarget.Y) * RDeltaTime;
			}
			return new V2(OX, OY);
		}

		/// <summary>The distance between Left and Right.</summary>
		/// <decorations decors="public static float"></decorations>
		/// <param name="Left">Source of the distance.</param>
		/// <param name="Right">Distance from source.</param>
		public static float Distance(V2 Left, V2 Right) => FMath.Sqrt(SqrDistance(Left, Right));

		/// <summary>Square Euclidean distance between Left and Right.</summary>
		/// <decorations decors="public static float"></decorations>
		/// <param name="Left"></param>
		/// <param name="Right"></param>
		public static float SqrDistance(V2 Left, V2 Right)
		{
			float x = Left.X - Right.X;
			float y = Left.Y - Right.Y;

			return x * x + y * y;
		}

		/// <summary>Euclidean distance between this V2 and another V.</summary>
		/// <param name="V">The V2 to find distance.</param>
		/// <decorations decors="public float"></decorations>
		/// <returns>The Euclidean distance between this V2 and V.</returns>
		public float Distance(V2 V) => Distance(this, V);
		/// <summary>The Euclidean distance, but without the square root calculation.</summary>
		/// <param name="V">The V2 to find square distance.</param>
		/// <decorations decors="public float"></decorations>
		/// <returns>The square distance between this V2 and V.</returns>
		public float SqrDistance(V2 V) => SqrDistance(this, V);

		/// <summary>Get the <see cref="SqrMagnitude"/> of <paramref name="M"/>.</summary>
		/// <docs>Get the SqrMagnitude of M.</docs>
		/// <param name="M">The V2.</param>
		/// <docreturns>The SquMagnitude of M.</docreturns>
		/// <returns><see cref="SqrMagnitude"/>.</returns>
		public static float operator ~(V2 M) => M.SqrMagnitude;

		/// <summary>Adds two V2s together.</summary>
		/// <decorations decors="public static V2 operator+"></decorations>
		/// <param name="Left">Left-side V2.</param>
		/// <param name="Right">Right-side V2.</param>
		/// <returns>(V2 Left, V2 Right) => new V2(Left.X + Right.X, Left.Y + Right.Y, Left.Z + Right.Z)</returns>
		public static V2 operator +(V2 Left, V2 Right) => new(Left.X + Right.X, Left.Y + Right.Y);
		/// <summary>Subtracts two V2s.</summary>
		/// <decorations decors="public static V2 operator-"></decorations>
		/// <param name="Left">Left-side V2.</param>
		/// <param name="Right">Right-side V2.</param>
		/// <returns>(V2 Left, V2 Right) => new V2(Left.X - Right.X, Left.Y - Right.Y, Left.Z - Right.Z)</returns>
		public static V2 operator -(V2 Left, V2 Right) => new(Left.X - Right.X, Left.Y - Right.Y);
		/// <summary>Negates an V2.</summary>
		/// <decorations decors="public static V2 operator-"></decorations>
		/// <param name="V">The V2 to negate all components.</param>
		/// <returns>(V2 V) => V *= -1f</returns>
		public static V2 operator -(V2 V) => -1f * V;
		/// <summary>Multiplies an V2 by a scalar on all components.</summary>
		/// <decorations decors="public static V2 operator*"></decorations>
		/// <param name="S">The Scalar to multiply.</param>
		/// <param name="V">The V2.</param>
		/// <returns>(V2 V, float S) => new V2(V.X * S, V.Y * S, V.Z * S)</returns>
		public static V2 operator *(float S, V2 V) => new(V.X * S, V.Y * S);
		/// <summary>Divides an V2 by a scalar on all components.</summary>
		/// <remarks>If d == 0, this will throw a DivideByZeroException.</remarks>
		/// <decorations decors="public static V2 operator/"></decorations>
		/// <param name="V">The V2.</param>
		/// <param name="D">The denominator under all components.</param>
		/// <returns>(V2 V, float D) => float S = 1 / D; return S * V</returns>
		public static V2 operator /(V2 V, float D)
		{
			if (D == 0)
			{
				throw new DivideByZeroException("Attempted division by zero.");
			}

			float S = 1 / D;

			return S * V;
		}

		/// <summary>Normalised direction from to.</summary>
		/// <decorations decors="public static V2 operator>"></decorations>
		/// <param name="From"></param>
		/// <param name="To"></param>
		/// <returns>(V2 From, V2 To) => (To - From).Normalised</returns>
		public static V2 operator >(V2 From, V2 To) => (To - From).Normalised;
		/// <summary>Normalised direction from to.</summary>
		/// <decorations decors="public static V2 operator&lt;"></decorations>
		/// <param name="From"></param>
		/// <param name="To"></param>
		/// <returns>(V2 To, V2 From) => From > To</returns>
		public static V2 operator <(V2 To, V2 From) => From > To;

		/// <summary>Compares two V2s for equality.</summary>
		/// <decorations decors="public static bool operator=="></decorations>
		/// <param name="Left">Left-side comparison.</param>
		/// <param name="Right">Right-side comparison.</param>
		/// <docreturns>True if the square distance between Left and Right is less than kEpsilon ^ 2.</docreturns>
		/// <returns>True if the square distance between Left and Right is less than <see cref="kEpsilon"/>^2.</returns>
		public static bool operator ==(V2 Left, V2 Right)
		{
			float x = Left.X - Right.X;
			float y = Left.Y - Right.Y;
			float Sqr = x * x + y * y;
			return Sqr < kEpsilon;
		}

		/// <summary>Compares two V2s for inequality.</summary>
		/// <decorations decors="public static bool operator!="></decorations>
		/// <param name="Left">Left-side comparison.</param>
		/// <param name="Right">Right-side comparison.</param>
		/// <returns>The opposite of operator ==.</returns>
		public static bool operator !=(V2 Left, V2 Right) => !(Left == Right);

		public override bool Equals(object O) => O is V2 V && Equals(V);
		public bool Equals(V2 V) => this == V || FMath.Abs(V.X - X + V.Y - Y) < 4f * kEpsilon;

		/// <summary>Automatic conversion from an V2 to a bool. <see cref="operator true(V2)"/> and <see cref="operator false(V2)"/>.</summary>
		/// <docs>Automatic conversion from an V2 to a bool. See operator true and operator false.</docs>
		/// <decorations decor="public static implicit operator bool"></decorations>
		public static implicit operator bool(V2 M) => M;

		public static implicit operator Point(V2 V) => new((int)V.X, (int)V.Y);
		public static implicit operator V2(Point P) => new(P.X, P.Y);

		/// <summary>Hash code for use in Maps, Sets, MArrays, etc.</summary>
		/// <decorations decors="public override int"></decorations>
		/// <returns>GetHashCode() => X.GetHashCode() ^ (Y.GetHashCode() &lt;&lt; 2) ^ (Z.GetHashCode() &gt;&gt; 2)</returns>
		public override int GetHashCode() => X.GetHashCode() ^ (Y.GetHashCode() << 2);

	}
}