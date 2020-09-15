using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class gameGlobalsContainer : CSerializable {
		public gameGlobalsData data;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			data = s.SerializeObject<gameGlobalsData>(data, name: "data");
		}
		public override uint? ClassCRC => 0x6D26004A;
	}
}

