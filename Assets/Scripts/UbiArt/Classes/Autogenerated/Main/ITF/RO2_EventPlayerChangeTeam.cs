using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventPlayerChangeTeam : Event {
		[Serialize("asker"  )] public uint asker;
		[Serialize("changer")] public uint changer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(asker));
			SerializeField(s, nameof(changer));
		}
		public override uint? ClassCRC => 0x2C0C74A3;
	}
}

