using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class SoundConfig_Template : CSerializable {
		[Serialize("WwiseLookUpTable"                 )] public CList<WwiseItem> WwiseLookUpTable;
		[Serialize("WwiseBankList"                    )] public CList<PathRef> WwiseBankList;
		[Serialize("WwiseEngineEventList"             )] public CList<WwiseEngineEvent> WwiseEngineEventList;
		[Serialize("WwiseDefaultAuxEffectList"        )] public CList<EventSetWwiseAuxBusEffect> WwiseDefaultAuxEffectList;
		[Serialize("microZoffset"                     )] public float microZoffset;
		[Serialize("WwiseStateToRestoreAfterHotReload")] public CList<StringID> WwiseStateToRestoreAfterHotReload;
		[Serialize("busses"                           )] public Placeholder busses;
		[Serialize("limiters"                         )] public Placeholder limiters;
		[Serialize("busMixBank"                       )] public Placeholder busMixBank;
		[Serialize("pauseFadeIn"                      )] public float pauseFadeIn;
		[Serialize("pauseFadeOut"                     )] public float pauseFadeOut;
		[Serialize("headphoneBusMix"                  )] public Placeholder headphoneBusMix;
		[Serialize("playerNumberBusMix"               )] public Placeholder playerNumberBusMix;
		[Serialize("limiterStopFade"                  )] public float limiterStopFade;
		[Serialize("engineStopFade"                   )] public float engineStopFade;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(busses));
				SerializeField(s, nameof(limiters));
				SerializeField(s, nameof(busMixBank));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(busses));
				SerializeField(s, nameof(limiters));
				SerializeField(s, nameof(pauseFadeIn));
				SerializeField(s, nameof(pauseFadeOut));
				SerializeField(s, nameof(headphoneBusMix));
				SerializeField(s, nameof(playerNumberBusMix));
				SerializeField(s, nameof(limiterStopFade));
				SerializeField(s, nameof(engineStopFade));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(busses));
				SerializeField(s, nameof(pauseFadeIn));
				SerializeField(s, nameof(pauseFadeOut));
				SerializeField(s, nameof(headphoneBusMix));
				SerializeField(s, nameof(WwiseBankList));
				SerializeField(s, nameof(microZoffset));
			} else {
				SerializeField(s, nameof(WwiseLookUpTable));
				SerializeField(s, nameof(WwiseBankList));
				SerializeField(s, nameof(WwiseEngineEventList));
				SerializeField(s, nameof(WwiseDefaultAuxEffectList));
				SerializeField(s, nameof(microZoffset));
				SerializeField(s, nameof(WwiseStateToRestoreAfterHotReload));
			}
		}
		public override uint? ClassCRC => 0x9BB5D070;
	}
}

