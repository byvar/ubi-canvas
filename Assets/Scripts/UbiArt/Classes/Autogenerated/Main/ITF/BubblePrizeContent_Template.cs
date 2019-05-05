using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR)]
	public partial class BubblePrizeContent_Template : CSerializable {
		[Serialize("popEvent"                )] public Generic<Event> popEvent;
		[Serialize("popEventPainted"         )] public Generic<Event> popEventPainted;
		[Serialize("popSpawn"                )] public Path popSpawn;
		[Serialize("rewardNumberChangeEnable")] public bool rewardNumberChangeEnable;
		[Serialize("contentPopType"          )] public ContentPopType contentPopType;
		[Serialize("bankState"               )] public BubblePrizeBankState bankState;
		
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion == Settings.EngineVersion.RO) {
				SerializeField(s, nameof(popEvent));
				SerializeField(s, nameof(popSpawn));
				SerializeField(s, nameof(bankState));
				SerializeField(s, nameof(rewardNumberChangeEnable));
			} else {
				SerializeField(s, nameof(popEvent));
				SerializeField(s, nameof(popEventPainted));
				SerializeField(s, nameof(popSpawn));
				SerializeField(s, nameof(rewardNumberChangeEnable));
				SerializeField(s, nameof(contentPopType));
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

