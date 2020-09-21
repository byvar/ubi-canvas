using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RewardDetail : CSerializable {
		public StringID id;
		public StringID name;
		public uint platformId;
		public bool noRetroactiveUnlock;
		public string uplayId;
		public CMap<online.SNSType, string> snsIds;
		public CArrayO<Generic<RewardTrigger_Base>> REWARD_TRIGGER;

		public string string__4;
		public string string__5;
		public string string__6;
		public string string__7;
		public string string__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				id = s.SerializeObject<StringID>(id, name: "id");
				name = s.SerializeObject<StringID>(name, name: "name");
				platformId = s.Serialize<uint>(platformId, name: "platformId");
				noRetroactiveUnlock = s.Serialize<bool>(noRetroactiveUnlock, name: "noRetroactiveUnlock");
				string__4 = s.Serialize<string>(string__4, name: "string__4");
				string__5 = s.Serialize<string>(string__5, name: "string__5");
				string__6 = s.Serialize<string>(string__6, name: "string__6");
				string__7 = s.Serialize<string>(string__7, name: "string__7");
				string__8 = s.Serialize<string>(string__8, name: "string__8");
				REWARD_TRIGGER = s.SerializeObject<CArrayO<Generic<RewardTrigger_Base>>>(REWARD_TRIGGER, name: "REWARD_TRIGGER");
			} else if (Settings.s.game == Settings.Game.RL) {
				id = s.SerializeObject<StringID>(id, name: "id");
				name = s.SerializeObject<StringID>(name, name: "name");
				platformId = s.Serialize<uint>(platformId, name: "platformId");
				noRetroactiveUnlock = s.Serialize<bool>(noRetroactiveUnlock, name: "noRetroactiveUnlock");
				REWARD_TRIGGER = s.SerializeObject<CArrayO<Generic<RewardTrigger_Base>>>(REWARD_TRIGGER, name: "REWARD_TRIGGER");
			} else {
				id = s.SerializeObject<StringID>(id, name: "id");
				name = s.SerializeObject<StringID>(name, name: "name");
				platformId = s.Serialize<uint>(platformId, name: "platformId");
				noRetroactiveUnlock = s.Serialize<bool>(noRetroactiveUnlock, name: "noRetroactiveUnlock");
				uplayId = s.Serialize<string>(uplayId, name: "uplayId");
				snsIds = s.SerializeObject<CMap<online.SNSType, string>>(snsIds, name: "snsIds");
				REWARD_TRIGGER = s.SerializeObject<CArrayO<Generic<RewardTrigger_Base>>>(REWARD_TRIGGER, name: "REWARD_TRIGGER");
			}
		}
	}
}

