using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DummyAIReceiveHitBehavior_Template : CSerializable {
		[Serialize("name")] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
		}
		public override uint? ClassCRC => 0xC2F6B54A;
	}
}

