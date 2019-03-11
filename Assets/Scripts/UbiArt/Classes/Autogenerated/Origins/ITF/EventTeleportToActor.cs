using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventTeleportToActor : CSerializable {
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
		}
		public override uint? ClassCRC => 0x213F08B6;
	}
}

