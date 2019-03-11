using UnityEngine;

namespace UbiArt.ITF {
	public partial class RewardDetail : CSerializable {
		[Serialize("id"                 )] public StringID id;
		[Serialize("name"               )] public StringID name;
		[Serialize("platformId"         )] public uint platformId;
		[Serialize("noRetroactiveUnlock")] public bool noRetroactiveUnlock;
		[Serialize("uplayId"            )] public string uplayId;
		[Serialize("snsIds"             )] public CMap<online.SNSType, string> snsIds;
		[Serialize("REWARD_TRIGGER"     )] public CArray<Generic<RewardTrigger_Base>> REWARD_TRIGGER;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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

