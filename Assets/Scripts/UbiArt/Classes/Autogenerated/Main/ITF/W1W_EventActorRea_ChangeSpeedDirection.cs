using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventActorRea_ChangeSpeedDirection : Event {
		public StringID StringID__0;
		public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
		}
		public override uint? ClassCRC => 0x07F288AC;
	}
}

