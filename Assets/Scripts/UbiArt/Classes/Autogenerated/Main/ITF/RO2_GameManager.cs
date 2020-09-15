using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_GameManager : GameManager {
		public uint savedDRCSwappedPlayerIdx;
		public float playersCurrentScale;
		public bool savedtouchScreenPlayerMandatory;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				savedDRCSwappedPlayerIdx = s.Serialize<uint>(savedDRCSwappedPlayerIdx, name: "savedDRCSwappedPlayerIdx");
				playersCurrentScale = s.Serialize<float>(playersCurrentScale, name: "playersCurrentScale");
				savedtouchScreenPlayerMandatory = s.Serialize<bool>(savedtouchScreenPlayerMandatory, name: "savedtouchScreenPlayerMandatory");
			}
		}
		public override uint? ClassCRC => 0xA133CDA6;
	}
}

