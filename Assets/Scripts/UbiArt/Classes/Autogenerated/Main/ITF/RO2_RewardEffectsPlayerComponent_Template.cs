using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RewardEffectsPlayerComponent_Template : ActorComponent_Template {
		public StringID pickingLumYellowNormal;
		public StringID pickingLumYellowAccrobatic;
		public StringID pickingLumRedNormal;
		public StringID pickingLumRedAccrobatic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pickingLumYellowNormal = s.SerializeObject<StringID>(pickingLumYellowNormal, name: "pickingLumYellowNormal");
			pickingLumYellowAccrobatic = s.SerializeObject<StringID>(pickingLumYellowAccrobatic, name: "pickingLumYellowAccrobatic");
			pickingLumRedNormal = s.SerializeObject<StringID>(pickingLumRedNormal, name: "pickingLumRedNormal");
			pickingLumRedAccrobatic = s.SerializeObject<StringID>(pickingLumRedAccrobatic, name: "pickingLumRedAccrobatic");
		}
		public override uint? ClassCRC => 0xA0B02B8D;
	}
}

