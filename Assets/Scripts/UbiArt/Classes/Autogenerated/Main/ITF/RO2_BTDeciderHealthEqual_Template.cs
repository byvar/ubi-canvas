using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_BTDeciderHealthEqual_Template : BTDecider_Template {
		public StringID factActor;
		public bool invert;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factActor = s.SerializeObject<StringID>(factActor, name: "factActor");
			invert = s.Serialize<bool>(invert, name: "invert");
		}
		public override uint? ClassCRC => 0xFC405466;
	}
}

