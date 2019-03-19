using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_BTDeciderHealthEqual_Template : BTDecider_Template {
		[Serialize("factActor")] public StringID factActor;
		[Serialize("invert"   )] public bool invert;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(factActor));
			SerializeField(s, nameof(invert));
		}
		public override uint? ClassCRC => 0xFC405466;
	}
}

