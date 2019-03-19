using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_189_sub_768CF0 : CSerializable {
		[Serialize("tag")] public StringID tag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tag));
		}
		public override uint? ClassCRC => 0xA10B8681;
	}
}

