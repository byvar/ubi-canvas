using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MinotaurShieldAIComponent_Template : RO2_AIComponent_Template {
		[Serialize("flyAnimName"      )] public StringID flyAnimName;
		[Serialize("landingAnimName"  )] public StringID landingAnimName;
		[Serialize("deathAnimName"    )] public StringID deathAnimName;
		[Serialize("disappearAnimName")] public StringID disappearAnimName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(flyAnimName));
				SerializeField(s, nameof(landingAnimName));
				SerializeField(s, nameof(deathAnimName));
				SerializeField(s, nameof(disappearAnimName));
			}
		}
		public override uint? ClassCRC => 0x3901EADF;
	}
}

