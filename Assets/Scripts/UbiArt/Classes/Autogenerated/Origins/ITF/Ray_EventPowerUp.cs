using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventPowerUp : Event {
		[Serialize("id"    )] public StringID id;
		[Serialize("enable")] public bool enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(enable));
		}
		public override uint? ClassCRC => 0x3433DF6C;
	}
}

