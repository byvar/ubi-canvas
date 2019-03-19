using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_BarbedWire : W1W_InteractiveGenComponent {
		[Serialize("bool__0"          )] public bool bool__0;
		[Serialize("Enum_VH_0__1"     )] public Enum_VH_0 Enum_VH_0__1;
		[Serialize("uint__2"          )] public uint uint__2;
		[Serialize("uint__3"          )] public uint uint__3;
		[Serialize("Generic<Event>__4")] public Generic<Event> Generic_Event__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enum_VH_0__1));
			SerializeField(s, nameof(uint__2));
			SerializeField(s, nameof(uint__3));
			SerializeField(s, nameof(Generic_Event__4));
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(bool__0));
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x34FD17E0;
	}
}

