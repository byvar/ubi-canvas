namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_SuperPunchGauge_Template : Ray_PowerUpDisplay_Template {
		public StringID fxControl;
		public StringID particleGenerator;
		public Path punchActor;
		public Vec2d playerFollowOffset;
		public Vec2d othersFollowOffset;
		public float launchDistance;
		public float launchYOffset;
		public float reducedLaunchDistance;
		public float reducedLaunchYOffset;
		public uint visibleAmmo;
		public float speedBlend;
		public float speedMin;
		public float speedMax;
		public float blendAtSpeedMin;
		public float blendAtSpeedMax;
		public StringID StringID__0;
		public StringID StringID__1;
		public Path Path__2;
		public Vec2d Vector2__3;
		public Vec2d Vector2__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public uint uint__9;
		public float float__10;
		public float float__11;
		public float float__12;
		public float float__13;
		public float float__14;
		public uint uint__15;
		public float float__16;
		public uint uint__17;
		public uint uint__18;
		public uint uint__19;
		public float float__20;
		public float float__21;
		public float float__22;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RFR) {
				StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
				StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
				Path__2 = s.SerializeObject<Path>(Path__2, name: "Path__2");
				Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
				Vector2__4 = s.SerializeObject<Vec2d>(Vector2__4, name: "Vector2__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				float__6 = s.Serialize<float>(float__6, name: "float__6");
				float__7 = s.Serialize<float>(float__7, name: "float__7");
				float__8 = s.Serialize<float>(float__8, name: "float__8");
				uint__9 = s.Serialize<uint>(uint__9, name: "uint__9");
				float__10 = s.Serialize<float>(float__10, name: "float__10");
				float__11 = s.Serialize<float>(float__11, name: "float__11");
				float__12 = s.Serialize<float>(float__12, name: "float__12");
				float__13 = s.Serialize<float>(float__13, name: "float__13");
				float__14 = s.Serialize<float>(float__14, name: "float__14");
				uint__15 = s.Serialize<uint>(uint__15, name: "uint__15");
				float__16 = s.Serialize<float>(float__16, name: "float__16");
				uint__17 = s.Serialize<uint>(uint__17, name: "uint__17");
				uint__18 = s.Serialize<uint>(uint__18, name: "uint__18");
				uint__19 = s.Serialize<uint>(uint__19, name: "uint__19");
				float__20 = s.Serialize<float>(float__20, name: "float__20");
				float__21 = s.Serialize<float>(float__21, name: "float__21");
				float__22 = s.Serialize<float>(float__22, name: "float__22");
			} else {
				fxControl = s.SerializeObject<StringID>(fxControl, name: "fxControl");
				particleGenerator = s.SerializeObject<StringID>(particleGenerator, name: "particleGenerator");
				punchActor = s.SerializeObject<Path>(punchActor, name: "punchActor");
				playerFollowOffset = s.SerializeObject<Vec2d>(playerFollowOffset, name: "playerFollowOffset");
				othersFollowOffset = s.SerializeObject<Vec2d>(othersFollowOffset, name: "othersFollowOffset");
				launchDistance = s.Serialize<float>(launchDistance, name: "launchDistance");
				launchYOffset = s.Serialize<float>(launchYOffset, name: "launchYOffset");
				reducedLaunchDistance = s.Serialize<float>(reducedLaunchDistance, name: "reducedLaunchDistance");
				reducedLaunchYOffset = s.Serialize<float>(reducedLaunchYOffset, name: "reducedLaunchYOffset");
				visibleAmmo = s.Serialize<uint>(visibleAmmo, name: "visibleAmmo");
				speedBlend = s.Serialize<float>(speedBlend, name: "speedBlend");
				speedMin = s.Serialize<float>(speedMin, name: "speedMin");
				speedMax = s.Serialize<float>(speedMax, name: "speedMax");
				blendAtSpeedMin = s.Serialize<float>(blendAtSpeedMin, name: "blendAtSpeedMin");
				blendAtSpeedMax = s.Serialize<float>(blendAtSpeedMax, name: "blendAtSpeedMax");
			}
		}
		public override uint? ClassCRC => 0x24013CDF;
	}
}

