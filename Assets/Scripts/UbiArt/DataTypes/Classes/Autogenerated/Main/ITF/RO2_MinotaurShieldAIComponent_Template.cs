using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_MinotaurShieldAIComponent_Template : RO2_AIComponent_Template {
		public StringID flyAnimName;
		public StringID landingAnimName;
		public StringID deathAnimName;
		public StringID disappearAnimName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				flyAnimName = s.SerializeObject<StringID>(flyAnimName, name: "flyAnimName");
				landingAnimName = s.SerializeObject<StringID>(landingAnimName, name: "landingAnimName");
				deathAnimName = s.SerializeObject<StringID>(deathAnimName, name: "deathAnimName");
				disappearAnimName = s.SerializeObject<StringID>(disappearAnimName, name: "disappearAnimName");
			}
		}
		public override uint? ClassCRC => 0x3901EADF;
	}
}

