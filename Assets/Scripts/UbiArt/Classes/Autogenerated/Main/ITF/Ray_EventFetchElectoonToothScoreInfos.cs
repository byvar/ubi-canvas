using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_EventFetchElectoonToothScoreInfos : CSerializable {
		public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.Serialize<uint>(sender, name: "sender");
		}
		public override uint? ClassCRC => 0xC144D4C2;
	}
}

