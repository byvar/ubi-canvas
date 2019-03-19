using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTDeciderRopeCut_Template : BTDecider_Template {
		[Serialize("invert"   )] public bool invert;
		[Serialize("factActor")] public StringID factActor;
		[Serialize("checkAll" )] public bool checkAll;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(invert));
			SerializeField(s, nameof(factActor));
			SerializeField(s, nameof(checkAll));
		}
		public override uint? ClassCRC => 0x97097C82;
	}
}

