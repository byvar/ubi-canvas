using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SuperPunchGauge_Template : RO2_PowerUpDisplay_Template {
		public StringID fxControl;
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
		public float depthOffset;
		public float blendAtSpeedMin;
		public float blendAtSpeedMax;
		public float ritualOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fxControl = s.SerializeObject<StringID>(fxControl, name: "fxControl");
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
			depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
			blendAtSpeedMin = s.Serialize<float>(blendAtSpeedMin, name: "blendAtSpeedMin");
			blendAtSpeedMax = s.Serialize<float>(blendAtSpeedMax, name: "blendAtSpeedMax");
			ritualOffset = s.Serialize<float>(ritualOffset, name: "ritualOffset");
		}
		public override uint? ClassCRC => 0x00A3FB3A;
	}
}

