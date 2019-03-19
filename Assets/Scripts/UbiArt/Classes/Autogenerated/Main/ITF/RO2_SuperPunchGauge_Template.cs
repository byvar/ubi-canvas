using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SuperPunchGauge_Template : RO2_PowerUpDisplay_Template {
		[Serialize("fxControl"            )] public StringID fxControl;
		[Serialize("punchActor"           )] public Path punchActor;
		[Serialize("playerFollowOffset"   )] public Vector2 playerFollowOffset;
		[Serialize("othersFollowOffset"   )] public Vector2 othersFollowOffset;
		[Serialize("launchDistance"       )] public float launchDistance;
		[Serialize("launchYOffset"        )] public float launchYOffset;
		[Serialize("reducedLaunchDistance")] public float reducedLaunchDistance;
		[Serialize("reducedLaunchYOffset" )] public float reducedLaunchYOffset;
		[Serialize("visibleAmmo"          )] public uint visibleAmmo;
		[Serialize("speedBlend"           )] public float speedBlend;
		[Serialize("speedMin"             )] public float speedMin;
		[Serialize("speedMax"             )] public float speedMax;
		[Serialize("depthOffset"          )] public float depthOffset;
		[Serialize("blendAtSpeedMin"      )] public float blendAtSpeedMin;
		[Serialize("blendAtSpeedMax"      )] public float blendAtSpeedMax;
		[Serialize("ritualOffset"         )] public float ritualOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fxControl));
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
			SerializeField(s, nameof(depthOffset));
			SerializeField(s, nameof(blendAtSpeedMin));
			SerializeField(s, nameof(blendAtSpeedMax));
			SerializeField(s, nameof(ritualOffset));
		}
		public override uint? ClassCRC => 0x00A3FB3A;
	}
}

