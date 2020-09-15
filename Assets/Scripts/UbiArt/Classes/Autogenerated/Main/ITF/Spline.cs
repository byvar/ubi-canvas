using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RFR)]
	public partial class Spline : CSerializable {
		[Serialize("Points"      )] public CList<Spline.SplinePoint> Points;
		[Serialize("TimeLoopMode")] public uint TimeLoopMode;
		[Serialize("TimeLoop"    )] public float TimeLoop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion == Settings.EngineVersion.RO) {
				SerializeField(s, nameof(Points));
			} else {
				SerializeField(s, nameof(Points));
				SerializeField(s, nameof(TimeLoopMode));
				SerializeField(s, nameof(TimeLoop));
			}
		}
		[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
		public partial class SplinePoint : CSerializable {
			[Serialize("Point"        )] public Vec3d Point;
			[Serialize("Time"         )] public float Time;
			[Serialize("NormalIn"     )] public Vec3d NormalIn;
			[Serialize("NormalInTime" )] public Vec3d NormalInTime;
			[Serialize("NormalOut"    )] public Vec3d NormalOut;
			[Serialize("NormalOutTime")] public Vec3d NormalOutTime;
			[Serialize("Interpolation")] public interp Interpolation;
			[Serialize("Interpolation")] public interp_RO Interpolation_RO;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Point));
				SerializeField(s, nameof(Time));
				SerializeField(s, nameof(NormalIn));
				SerializeField(s, nameof(NormalInTime));
				SerializeField(s, nameof(NormalOut));
				SerializeField(s, nameof(NormalOutTime));
				if (Settings.s.engineVersion == Settings.EngineVersion.RO) {
					SerializeField(s, nameof(Interpolation_RO));
				} else {
					SerializeField(s, nameof(Interpolation));
				}
			}
			public enum interp_RO {
				[Serialize("interp_linear")] linear = 0,
				[Serialize("interp_spline")] spline = 1,
			}
			public enum interp {
				[Serialize("interp_linear"         )] linear = 0,
				[Serialize("interp_spline"         )] spline = 1,
				[Serialize("interp_bezier"         )] bezier = 2,
				[Serialize("interp_constant"       )] constant = 3,
				[Serialize("interp_bezier_standard")] bezier_standard = 4,
			}
		}

		public enum UsageMode {
			X,
			Y,
			Z,
			XY,
			XYZ,
			RGB,
			WZ
		}
	}
}

