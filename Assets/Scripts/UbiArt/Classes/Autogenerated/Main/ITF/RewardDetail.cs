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
		[Serialize("StringID__0"                           )] public StringID StringID__0;
		[Serialize("StringID__1"                           )] public StringID StringID__1;
		[Serialize("uint__2"                               )] public uint uint__2;
		[Serialize("bool__3"                               )] public bool bool__3;
		[Serialize("string__4"                             )] public string string__4;
		[Serialize("string__5"                             )] public string string__5;
		[Serialize("string__6"                             )] public string string__6;
		[Serialize("string__7"                             )] public string string__7;
		[Serialize("string__8"                             )] public string string__8;
		[Serialize("CArray<Generic<RewardTrigger_Base>>__9")] public CArray<Generic<RewardTrigger_Base>> CArray_Generic_RewardTrigger_Base__9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1));
				SerializeField(s, nameof(uint__2));
				SerializeField(s, nameof(bool__3));
				SerializeField(s, nameof(string__4));
				SerializeField(s, nameof(string__5));
				SerializeField(s, nameof(string__6));
				SerializeField(s, nameof(string__7));
				SerializeField(s, nameof(string__8));
				SerializeField(s, nameof(CArray_Generic_RewardTrigger_Base__9));
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

