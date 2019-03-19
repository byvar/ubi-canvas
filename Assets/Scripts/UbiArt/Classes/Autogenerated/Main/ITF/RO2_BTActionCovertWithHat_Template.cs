using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_BTActionCovertWithHat_Template : BTAction_Template {
		[Serialize("factTarget"       )] public StringID factTarget;
		[Serialize("animIdle"         )] public StringID animIdle;
		[Serialize("animStartCarrying")] public StringID animStartCarrying;
		[Serialize("animStopCarrying" )] public StringID animStopCarrying;
		[Serialize("animCarrying"     )] public StringID animCarrying;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(factTarget));
			SerializeField(s, nameof(animIdle));
			SerializeField(s, nameof(animStartCarrying));
			SerializeField(s, nameof(animStopCarrying));
			SerializeField(s, nameof(animCarrying));
		}
		public override uint? ClassCRC => 0xB1082C39;
	}
}

