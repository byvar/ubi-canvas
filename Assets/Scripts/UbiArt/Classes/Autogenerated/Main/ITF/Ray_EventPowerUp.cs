using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventPowerUp : Event {
		public StringID id;
		public int enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<StringID>(id, name: "id");
			enable = s.Serialize<int>(enable, name: "enable");
		}
		public override uint? ClassCRC => 0x3433DF6C;
	}
}

