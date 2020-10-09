using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RAVersion)]
	public partial class EventSetWwiseAuxBusEffect : Event {
		public StringID WwiseBusGUID;
		public StringID WwiseEffectGUID;
		public AUDIO_BUS_SLOT WwiseBusSlotID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			WwiseBusGUID = s.SerializeObject<StringID>(WwiseBusGUID, name: "WwiseBusGUID");
			WwiseEffectGUID = s.SerializeObject<StringID>(WwiseEffectGUID, name: "WwiseEffectGUID");
			WwiseBusSlotID = s.Serialize<AUDIO_BUS_SLOT>(WwiseBusSlotID, name: "WwiseBusSlotID");
		}
		public enum AUDIO_BUS_SLOT {
			[Serialize("AUDIO_BUS_SLOT_0")] Slot0 = 0,
			[Serialize("AUDIO_BUS_SLOT_1")] Slot1 = 1,
			[Serialize("AUDIO_BUS_SLOT_2")] Slot2 = 2,
			[Serialize("AUDIO_BUS_SLOT_3")] Slot3 = 3,
		}
		public override uint? ClassCRC => 0xACCD0913;
	}
}

