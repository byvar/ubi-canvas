namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class Spline : CSerializable {
		public CListO<Spline.SplinePoint> Points;
		public uint TimeLoopMode;
		public float TimeLoop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.engineVersion == Settings.EngineVersion.RO) {
				Points = s.SerializeObject<CListO<Spline.SplinePoint>>(Points, name: "Points");
			} else {
				Points = s.SerializeObject<CListO<Spline.SplinePoint>>(Points, name: "Points");
				TimeLoopMode = s.Serialize<uint>(TimeLoopMode, name: "TimeLoopMode");
				TimeLoop = s.Serialize<float>(TimeLoop, name: "TimeLoop");
			}
		}
		[Games(GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
		public partial class SplinePoint : CSerializable {
			public Vec3d Point;
			public float Time;
			public Vec3d NormalIn;
			public Vec3d NormalInTime = Vec3d.One;
			public Vec3d NormalOut;
			public Vec3d NormalOutTime = Vec3d.One;
			public interp Interpolation;
			public interp_RO Interpolation_RO;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Point = s.SerializeObject<Vec3d>(Point, name: "Point");
				Time = s.Serialize<float>(Time, name: "Time");
				NormalIn = s.SerializeObject<Vec3d>(NormalIn, name: "NormalIn");
				NormalInTime = s.SerializeObject<Vec3d>(NormalInTime, name: "NormalInTime");
				NormalOut = s.SerializeObject<Vec3d>(NormalOut, name: "NormalOut");
				NormalOutTime = s.SerializeObject<Vec3d>(NormalOutTime, name: "NormalOutTime");
				if (s.Settings.engineVersion == Settings.EngineVersion.RO) {
					Interpolation_RO = s.Serialize<interp_RO>(Interpolation_RO, name: "Interpolation");
				} else {
					Interpolation = s.Serialize<interp>(Interpolation, name: "Interpolation");
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

