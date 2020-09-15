using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_SuperPunchGauge_Template : Ray_PowerUpDisplay_Template {
		[Serialize("fxControl"            )] public StringID fxControl;
		[Serialize("particleGenerator"    )] public StringID particleGenerator;
		[Serialize("punchActor"           )] public Path punchActor;
		[Serialize("playerFollowOffset"   )] public Vec2d playerFollowOffset;
		[Serialize("othersFollowOffset"   )] public Vec2d othersFollowOffset;
		[Serialize("launchDistance"       )] public float launchDistance;
		[Serialize("launchYOffset"        )] public float launchYOffset;
		[Serialize("reducedLaunchDistance")] public float reducedLaunchDistance;
		[Serialize("reducedLaunchYOffset" )] public float reducedLaunchYOffset;
		[Serialize("visibleAmmo"          )] public uint visibleAmmo;
		[Serialize("speedBlend"           )] public float speedBlend;
		[Serialize("speedMin"             )] public float speedMin;
		[Serialize("speedMax"             )] public float speedMax;
		[Serialize("blendAtSpeedMin"      )] public float blendAtSpeedMin;
		[Serialize("blendAtSpeedMax"      )] public float blendAtSpeedMax;
		[Serialize("StringID__0"          )] public StringID StringID__0;
		[Serialize("StringID__1"          )] public StringID StringID__1;
		[Serialize("Path__2"              )] public Path Path__2;
		[Serialize("Vector2__3"           )] public Vec2d Vector2__3;
		[Serialize("Vector2__4"           )] public Vec2d Vector2__4;
		[Serialize("float__5"             )] public float float__5;
		[Serialize("float__6"             )] public float float__6;
		[Serialize("float__7"             )] public float float__7;
		[Serialize("float__8"             )] public float float__8;
		[Serialize("uint__9"              )] public uint uint__9;
		[Serialize("float__10"            )] public float float__10;
		[Serialize("float__11"            )] public float float__11;
		[Serialize("float__12"            )] public float float__12;
		[Serialize("float__13"            )] public float float__13;
		[Serialize("float__14"            )] public float float__14;
		[Serialize("uint__15"             )] public uint uint__15;
		[Serialize("float__16"            )] public float float__16;
		[Serialize("uint__17"             )] public uint uint__17;
		[Serialize("uint__18"             )] public uint uint__18;
		[Serialize("uint__19"             )] public uint uint__19;
		[Serialize("float__20"            )] public float float__20;
		[Serialize("float__21"            )] public float float__21;
		[Serialize("float__22"            )] public float float__22;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1));
				SerializeField(s, nameof(Path__2));
				SerializeField(s, nameof(Vector2__3));
				SerializeField(s, nameof(Vector2__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(uint__9));
				SerializeField(s, nameof(float__10));
				SerializeField(s, nameof(float__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(float__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(uint__15));
				SerializeField(s, nameof(float__16));
				SerializeField(s, nameof(uint__17));
				SerializeField(s, nameof(uint__18));
				SerializeField(s, nameof(uint__19));
				SerializeField(s, nameof(float__20));
				SerializeField(s, nameof(float__21));
				SerializeField(s, nameof(float__22));
			} else {
				SerializeField(s, nameof(fxControl));
				SerializeField(s, nameof(particleGenerator));
				SerializeField(s, nameof(punchActor));
				SerializeField(s, nameof(playerFollowOffset));
				SerializeField(s, nameof(othersFollowOffset));
				SerializeField(s, nameof(launchDistance));
				SerializeField(s, nameof(launchYOffset));
				SerializeField(s, nameof(reducedLaunchDistance));
				SerializeField(s, nameof(reducedLaunchYOffset));
				SerializeField(s, nameof(visibleAmmo));
				SerializeField(s, nameof(speedBlend));
				SerializeField(s, nameof(speedMin));
				SerializeField(s, nameof(speedMax));
				SerializeField(s, nameof(blendAtSpeedMin));
				SerializeField(s, nameof(blendAtSpeedMax));
			}
		}
		public override uint? ClassCRC => 0x24013CDF;
	}
}

