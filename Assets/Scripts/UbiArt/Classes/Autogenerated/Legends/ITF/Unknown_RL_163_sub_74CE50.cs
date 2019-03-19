using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_163_sub_74CE50 : CSerializable {
		[Serialize("murphyIconPath")] public Path murphyIconPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(murphyIconPath));
		}
		public override uint? ClassCRC => 0x8697A56D;
	}
}

