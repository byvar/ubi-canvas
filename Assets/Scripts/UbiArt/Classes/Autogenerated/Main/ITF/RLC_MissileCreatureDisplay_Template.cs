using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_MissileCreatureDisplay_Template : RLC_PowerUpCreatureDisplay_Template {
		[Serialize("launchDistance"       )] public float launchDistance;
		[Serialize("launchYOffset"        )] public float launchYOffset;
		[Serialize("reducedLaunchDistance")] public float reducedLaunchDistance;
		[Serialize("reducedLaunchYOffset" )] public float reducedLaunchYOffset;
		[Serialize("depthOffset"          )] public float depthOffset;
		[Serialize("punchActor"           )] public Path punchActor;
		[Serialize("megaFireballActor"    )] public Path megaFireballActor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(launchDistance));
			SerializeField(s, nameof(launchYOffset));
			SerializeField(s, nameof(reducedLaunchDistance));
			SerializeField(s, nameof(reducedLaunchYOffset));
			SerializeField(s, nameof(depthOffset));
			SerializeField(s, nameof(punchActor));
			SerializeField(s, nameof(megaFireballActor));
		}
		public override uint? ClassCRC => 0x2A44F73D;
	}
}

