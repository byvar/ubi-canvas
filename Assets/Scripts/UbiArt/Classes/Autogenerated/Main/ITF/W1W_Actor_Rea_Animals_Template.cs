using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Actor_Rea_Animals_Template : W1W_Actor_Rea_Template {
		[Serialize("StringID__0")] public StringID StringID__0_;
		[Serialize("StringID__1")] public StringID StringID__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0_));
			SerializeField(s, nameof(StringID__1));
		}
		public override uint? ClassCRC => 0x9C47DBFC;
	}
}

