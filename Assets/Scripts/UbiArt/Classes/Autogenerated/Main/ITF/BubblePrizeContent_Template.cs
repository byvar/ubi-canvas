using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RA)]
	public partial class BubblePrizeContent_Template : CSerializable {
		public Generic<Event> popEvent;
		public Generic<Event> popEventPainted;
		public Path popSpawn;
		public bool rewardNumberChangeEnable;
		public ContentPopType contentPopType;
		public BubblePrizeBankState bankState;
		
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion == Settings.EngineVersion.RO) {
				popEvent = s.SerializeObject<Generic<Event>>(popEvent, name: "popEvent");
				popSpawn = s.SerializeObject<Path>(popSpawn, name: "popSpawn");
				bankState = s.Serialize<BubblePrizeBankState>(bankState, name: "bankState");
				rewardNumberChangeEnable = s.Serialize<bool>(rewardNumberChangeEnable, name: "rewardNumberChangeEnable");
			} else {
				popEvent = s.SerializeObject<Generic<Event>>(popEvent, name: "popEvent");
				popEventPainted = s.SerializeObject<Generic<Event>>(popEventPainted, name: "popEventPainted");
				popSpawn = s.SerializeObject<Path>(popSpawn, name: "popSpawn");
				rewardNumberChangeEnable = s.Serialize<bool>(rewardNumberChangeEnable, name: "rewardNumberChangeEnable");
				contentPopType = s.Serialize<ContentPopType>(contentPopType, name: "contentPopType");
			}
		}
		public enum ContentPopType {
			[Serialize("ContentPopType_None"             )] None = 0,
			[Serialize("ContentPopType_ClassicPlayer"    )] ClassicPlayer = 1,
			[Serialize("ContentPopType_TouchScreenPlayer")] TouchScreenPlayer = 2,
			[Serialize("ContentPopType_All"              )] All = 3,
		}
		
		public enum BubblePrizeBankState {
			[Serialize("BubblePrizeBankState_Invalid"           )] Invalid = 0,
			[Serialize("BubblePrizeBankState_Darktoon"          )] Darktoon = 1,
			[Serialize("BubblePrizeBankState_Heart"             )] Heart = 3,
			[Serialize("BubblePrizeBankState_Lum"               )] Lum = 4,
			[Serialize("BubblePrizeBankState_LumKing"           )] LumKing = 5,
			[Serialize("BubblePrizeBankState_SuperPunch_basic"  )] SuperPunch_basic = 6,
			[Serialize("BubblePrizeBankState_SuperPunch_seeking")] SuperPunch_seeking = 7,
			[Serialize("BubblePrizeBankState_SwarmRepeller"     )] SwarmRepeller = 8,
			[Serialize("BubblePrizeBankState_RedLum"            )] RedLum = 9,
			[Serialize("BubblePrizeBankState_Lum_x10"           )] Lum_x10 = 10,
			[Serialize("BubblePrizeBankState_RedLum_x10"        )] RedLum_x10 = 11,
			[Serialize("BubblePrizeBankState_Lum_x5"            )] Lum_x5 = 12,
			[Serialize("BubblePrizeBankState_RedLum_x5"         )] RedLum_x5 = 13,
		}
	}
}

