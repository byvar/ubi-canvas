using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class gameGlobalsContainer : CSerializable {
		[Serialize("data")] public gameGlobalsData data;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(data));
		}
		public override uint? ClassCRC => 0x6D26004A;
	}
}

