using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_186_sub_767ED0 : ActorComponent {
		public StringID tag;
		public uint teensyRecapIndex;
		public StringID behaviorTag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tag = s.SerializeObject<StringID>(tag, name: "tag");
			teensyRecapIndex = s.Serialize<uint>(teensyRecapIndex, name: "teensyRecapIndex");
			behaviorTag = s.SerializeObject<StringID>(behaviorTag, name: "behaviorTag");
		}
		public override uint? ClassCRC => 0x52632D26;
	}
}

