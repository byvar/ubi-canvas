using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MusicScoreAIBranchComponent_Template : RO2_BezierBranchComponent_Template {
		public float openingSpeed;
		public float noteIntervalHeight;
		public StringID openSound;
		public StringID closeSound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			openingSpeed = s.Serialize<float>(openingSpeed, name: "openingSpeed");
			noteIntervalHeight = s.Serialize<float>(noteIntervalHeight, name: "noteIntervalHeight");
			openSound = s.SerializeObject<StringID>(openSound, name: "openSound");
			closeSound = s.SerializeObject<StringID>(closeSound, name: "closeSound");
		}
		public override uint? ClassCRC => 0xF74BCCEB;
	}
}

