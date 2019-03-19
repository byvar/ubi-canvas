using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventLockPlayers : Event {
		[Serialize("bool__0"     )] public bool bool__0;
		[Serialize("bool__1"     )] public bool bool__1;
		[Serialize("Enum_VH_0__2")] public Enum_VH_0 Enum_VH_0__2;
		[Serialize("bool__3"     )] public bool bool__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(bool__1));
			SerializeField(s, nameof(Enum_VH_0__2));
			SerializeField(s, nameof(bool__3));
		}
		public enum Enum_VH_0 {
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_0")] Value_0 = 0,
		}
		public override uint? ClassCRC => 0xCAB6A9B8;
	}
}

