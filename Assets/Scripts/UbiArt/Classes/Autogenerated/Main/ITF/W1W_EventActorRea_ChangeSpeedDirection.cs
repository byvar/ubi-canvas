using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventActorRea_ChangeSpeedDirection : Event {
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("float__1"   )] public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(float__1));
		}
		public override uint? ClassCRC => 0x07F288AC;
	}
}

