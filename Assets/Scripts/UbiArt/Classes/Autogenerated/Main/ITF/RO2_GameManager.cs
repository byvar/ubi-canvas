using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_GameManager : GameManager {
		[Serialize("savedDRCSwappedPlayerIdx"       )] public uint savedDRCSwappedPlayerIdx;
		[Serialize("playersCurrentScale"            )] public float playersCurrentScale;
		[Serialize("savedtouchScreenPlayerMandatory")] public bool savedtouchScreenPlayerMandatory;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(savedDRCSwappedPlayerIdx));
				SerializeField(s, nameof(playersCurrentScale));
				SerializeField(s, nameof(savedtouchScreenPlayerMandatory));
			}
		}
		public override uint? ClassCRC => 0xA133CDA6;
	}
}

