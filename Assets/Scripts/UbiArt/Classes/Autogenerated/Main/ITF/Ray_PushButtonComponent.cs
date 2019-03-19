using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PushButtonComponent : CSerializable {
		[Serialize("activator"   )] public uint activator;
		[Serialize("triggerCount")] public Enum_triggerCount triggerCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(activator));
				SerializeField(s, nameof(triggerCount));
			}
		}
		public enum Enum_triggerCount {
		}
		public override uint? ClassCRC => 0x85C4E907;
	}
}

