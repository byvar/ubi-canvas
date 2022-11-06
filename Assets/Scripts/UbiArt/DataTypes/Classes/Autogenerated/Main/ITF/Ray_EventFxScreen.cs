using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventFxScreen : Event {
		public uint isStart;
		public StringID fadeType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isStart = s.Serialize<uint>(isStart, name: "isStart");
			fadeType = s.SerializeObject<StringID>(fadeType, name: "fadeType");
		}
		public override uint? ClassCRC => 0x159E0C37;
	}
}

