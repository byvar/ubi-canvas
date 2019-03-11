using UnityEngine;

namespace UbiArt.ITF {
	public partial class Spline : CSerializable {
		[Serialize("Points"      )] public CList<Spline.SplinePoint> Points;
		[Serialize("TimeLoopMode")] public uint TimeLoopMode;
		[Serialize("TimeLoop"    )] public float TimeLoop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Points));
			SerializeField(s, nameof(TimeLoopMode));
			SerializeField(s, nameof(TimeLoop));
		}
		public partial class SplinePoint : CSerializable {
			[Serialize("Point"        )] public Vector3 Point;
			[Serialize("Time"         )] public float Time;
			[Serialize("NormalIn"     )] public Vector3 NormalIn;
			[Serialize("NormalInTime" )] public Vector3 NormalInTime;
			[Serialize("NormalOut"    )] public Vector3 NormalOut;
			[Serialize("NormalOutTime")] public Vector3 NormalOutTime;
			[Serialize("Interpolation")] public interp Interpolation;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Point));
				SerializeField(s, nameof(Time));
				SerializeField(s, nameof(NormalIn));
				SerializeField(s, nameof(NormalInTime));
				SerializeField(s, nameof(NormalOut));
				SerializeField(s, nameof(NormalOutTime));
				SerializeField(s, nameof(Interpolation));
			}
			public enum interp {
				[Serialize("interp_linear"         )] linear = 0,
				[Serialize("interp_spline"         )] spline = 1,
				[Serialize("interp_bezier"         )] bezier = 2,
				[Serialize("interp_constant"       )] constant = 3,
				[Serialize("interp_bezier_standard")] bezier_standard = 4,
			}
		}
	}
}

