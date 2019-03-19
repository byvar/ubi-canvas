using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FireflyCloudComponent_Template : ActorComponent_Template {
		[Serialize("standFX")] public StringID standFX;
		[Serialize("poufFX" )] public StringID poufFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(standFX));
			SerializeField(s, nameof(poufFX));
		}
		public override uint? ClassCRC => 0x39C1D03A;
	}
}

