using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventTriggerBounce : CSerializable {
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
		}
		public override uint? ClassCRC => 0x70B237E1;
	}
}

