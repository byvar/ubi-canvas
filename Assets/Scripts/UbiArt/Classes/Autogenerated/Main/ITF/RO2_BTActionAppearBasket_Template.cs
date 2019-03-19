using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_BTActionAppearBasket_Template : BTAction_Template {
		[Serialize("animStand"     )] public StringID animStand;
		[Serialize("animAppear"    )] public StringID animAppear;
		[Serialize("waitForTrigger")] public bool waitForTrigger;
		[Serialize("disablePhys"   )] public bool disablePhys;
		[Serialize("resetAngle"    )] public bool resetAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animStand));
			SerializeField(s, nameof(animAppear));
			SerializeField(s, nameof(waitForTrigger));
			SerializeField(s, nameof(disablePhys));
			SerializeField(s, nameof(resetAngle));
		}
		public override uint? ClassCRC => 0x40ED945F;
	}
}

