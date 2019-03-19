using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_186_sub_767ED0 : CSerializable {
		[Serialize("tag"             )] public StringID tag;
		[Serialize("teensyRecapIndex")] public uint teensyRecapIndex;
		[Serialize("behaviorTag"     )] public StringID behaviorTag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tag));
			SerializeField(s, nameof(teensyRecapIndex));
			SerializeField(s, nameof(behaviorTag));
		}
		public override uint? ClassCRC => 0x52632D26;
	}
}

