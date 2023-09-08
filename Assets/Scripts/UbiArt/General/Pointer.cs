#nullable enable
using System;
using UbiArt.FileFormat;

namespace UbiArt
{
	public readonly struct Pointer : IEquatable<Pointer> 
	{
		#region Constructor

		public Pointer(long offset, UbiArtFile? file) 
		{
			Offset = offset;
			File = file;
		}

		#endregion

		#region Public Properties

		public long Offset { get; }
		public UbiArtFile? File { get; }

		#endregion

		#region Operators

		public static bool operator ==(Pointer x, Pointer y) => x.Offset == y.Offset && x.File == y.File;
		public static bool operator !=(Pointer x, Pointer y) => !(x == y);

		public static Pointer operator +(Pointer x, long y) => new(x.Offset + y, x.File);
		public static Pointer operator -(Pointer x, long y) => new(x.Offset - y, x.File);

		#endregion

		#region Public Methods

		public bool Equals(Pointer other) => this == other;

		public override bool Equals(object? obj) => obj is Pointer pointer && this == pointer;
		public override int GetHashCode() => File != null ? Offset.GetHashCode() ^ File.GetHashCode() : Offset.GetHashCode();
		public override string ToString() => $"{File?.FilePath ?? "FakeFile"}|0x{Offset:X8}";

		#endregion
	}
}