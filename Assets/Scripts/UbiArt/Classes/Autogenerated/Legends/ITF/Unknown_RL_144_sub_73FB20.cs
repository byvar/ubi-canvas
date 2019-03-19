using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_144_sub_73FB20 : CSerializable {
		[Serialize("lastPageItemText")] public Placeholder lastPageItemText;
		[Serialize("subMenuNames"    )] public Placeholder subMenuNames;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lastPageItemText));
			SerializeField(s, nameof(subMenuNames));
		}
		public override uint? ClassCRC => 0x25F80892;
	}
}

