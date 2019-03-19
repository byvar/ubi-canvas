using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventPowerUp : Event {
		[Serialize("id"    )] public StringID id;
		[Serialize("enable")] public int enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(enable));
		}
		public override uint? ClassCRC => 0x3433DF6C;
	}
}

