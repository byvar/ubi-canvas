using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class SoundConfig_Template : CSerializable {
		public CListO<WwiseItem> WwiseLookUpTable;
		public CListO<PathRef> WwiseBankList;
		public CListO<WwiseEngineEvent> WwiseEngineEventList;
		public CListO<EventSetWwiseAuxBusEffect> WwiseDefaultAuxEffectList;
		public float microZoffset;
		public CListO<StringID> WwiseStateToRestoreAfterHotReload;
		public Placeholder busses;
		public Placeholder limiters;
		public Placeholder busMixBank;
		public float pauseFadeIn;
		public float pauseFadeOut;
		public Placeholder headphoneBusMix;
		public Placeholder playerNumberBusMix;
		public float limiterStopFade;
		public float engineStopFade;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				busses = s.SerializeObject<Placeholder>(busses, name: "busses");
				limiters = s.SerializeObject<Placeholder>(limiters, name: "limiters");
				busMixBank = s.SerializeObject<Placeholder>(busMixBank, name: "busMixBank");
			} else if (Settings.s.game == Settings.Game.RL) {
				busses = s.SerializeObject<Placeholder>(busses, name: "busses");
				limiters = s.SerializeObject<Placeholder>(limiters, name: "limiters");
				pauseFadeIn = s.Serialize<float>(pauseFadeIn, name: "pauseFadeIn");
				pauseFadeOut = s.Serialize<float>(pauseFadeOut, name: "pauseFadeOut");
				headphoneBusMix = s.SerializeObject<Placeholder>(headphoneBusMix, name: "headphoneBusMix");
				playerNumberBusMix = s.SerializeObject<Placeholder>(playerNumberBusMix, name: "playerNumberBusMix");
				limiterStopFade = s.Serialize<float>(limiterStopFade, name: "limiterStopFade");
				engineStopFade = s.Serialize<float>(engineStopFade, name: "engineStopFade");
			} else if (Settings.s.game == Settings.Game.COL) {
				busses = s.SerializeObject<Placeholder>(busses, name: "busses");
				pauseFadeIn = s.Serialize<float>(pauseFadeIn, name: "pauseFadeIn");
				pauseFadeOut = s.Serialize<float>(pauseFadeOut, name: "pauseFadeOut");
				headphoneBusMix = s.SerializeObject<Placeholder>(headphoneBusMix, name: "headphoneBusMix");
				WwiseBankList = s.SerializeObject<CListO<PathRef>>(WwiseBankList, name: "WwiseBankList");
				microZoffset = s.Serialize<float>(microZoffset, name: "microZoffset");
			} else {
				WwiseLookUpTable = s.SerializeObject<CListO<WwiseItem>>(WwiseLookUpTable, name: "WwiseLookUpTable");
				WwiseBankList = s.SerializeObject<CListO<PathRef>>(WwiseBankList, name: "WwiseBankList");
				WwiseEngineEventList = s.SerializeObject<CListO<WwiseEngineEvent>>(WwiseEngineEventList, name: "WwiseEngineEventList");
				WwiseDefaultAuxEffectList = s.SerializeObject<CListO<EventSetWwiseAuxBusEffect>>(WwiseDefaultAuxEffectList, name: "WwiseDefaultAuxEffectList");
				microZoffset = s.Serialize<float>(microZoffset, name: "microZoffset");
				WwiseStateToRestoreAfterHotReload = s.SerializeObject<CListO<StringID>>(WwiseStateToRestoreAfterHotReload, name: "WwiseStateToRestoreAfterHotReload");
			}
		}
		public override uint? ClassCRC => 0x9BB5D070;
	}
}

