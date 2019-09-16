using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RewardDetail : CSerializable {
		[Serialize("id"                                    )] public StringID id;
		[Serialize("name"                                  )] public StringID name;
		[Serialize("platformId"                            )] public uint platformId;
		[Serialize("noRetroactiveUnlock"                   )] public bool noRetroactiveUnlock;
		[Serialize("uplayId"                               )] public string uplayId;
		[Serialize("snsIds"                                )] public CMap<online.SNSType, string> snsIds;
		[Serialize("REWARD_TRIGGER"                        )] public CArray<Generic<RewardTrigger_Base>> REWARD_TRIGGER;

		[Serialize("string__4"                             )] public string string__4;
		[Serialize("string__5"                             )] public string string__5;
		[Serialize("string__6"                             )] public string string__6;
		[Serialize("string__7"                             )] public string string__7;
		[Serialize("string__8"                             )] public string string__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(platformId));
				SerializeField(s, nameof(noRetroactiveUnlock));
				SerializeField(s, nameof(string__4));
				SerializeField(s, nameof(string__5));
				SerializeField(s, nameof(string__6));
				SerializeField(s, nameof(string__7));
				SerializeField(s, nameof(string__8));
				SerializeField(s, nameof(REWARD_TRIGGER));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(platformId));
				SerializeField(s, nameof(noRetroactiveUnlock));
				SerializeField(s, nameof(REWARD_TRIGGER));
			} else {
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(platformId));
				SerializeField(s, nameof(noRetroactiveUnlock));
				SerializeField(s, nameof(uplayId));
				SerializeField(s, nameof(snsIds));
				SerializeField(s, nameof(REWARD_TRIGGER));
			}
		}
	}
}

