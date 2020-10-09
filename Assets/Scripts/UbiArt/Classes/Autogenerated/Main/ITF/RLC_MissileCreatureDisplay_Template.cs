using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_MissileCreatureDisplay_Template : RLC_PowerUpCreatureDisplay_Template {
		public float launchDistance;
		public float launchYOffset;
		public float reducedLaunchDistance;
		public float reducedLaunchYOffset;
		public float depthOffset;
		public Path punchActor;
		public Path megaFireballActor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			launchDistance = s.Serialize<float>(launchDistance, name: "launchDistance");
			launchYOffset = s.Serialize<float>(launchYOffset, name: "launchYOffset");
			reducedLaunchDistance = s.Serialize<float>(reducedLaunchDistance, name: "reducedLaunchDistance");
			reducedLaunchYOffset = s.Serialize<float>(reducedLaunchYOffset, name: "reducedLaunchYOffset");
			depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
			punchActor = s.SerializeObject<Path>(punchActor, name: "punchActor");
			megaFireballActor = s.SerializeObject<Path>(megaFireballActor, name: "megaFireballActor");
		}
		public override uint? ClassCRC => 0x2A44F73D;
	}
}

