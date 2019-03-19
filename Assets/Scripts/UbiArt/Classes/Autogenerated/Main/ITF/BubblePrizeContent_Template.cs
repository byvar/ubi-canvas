using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR)]
	public partial class BubblePrizeContent_Template : CSerializable {
		[Serialize("popEvent"                )] public Generic<Event> popEvent;
		[Serialize("popEventPainted"         )] public Generic<Event> popEventPainted;
		[Serialize("popSpawn"                )] public Path popSpawn;
		[Serialize("rewardNumberChangeEnable")] public bool rewardNumberChangeEnable;
		[Serialize("contentPopType"          )] public ContentPopType contentPopType;
		[Serialize("Generic<Event>__0"       )] public Generic<Event> Generic_Event__0;
		[Serialize("Path__1"                 )] public Path Path__1;
		[Serialize("Enum_RJR_0__2"           )] public Enum_RJR_0 Enum_RJR_0__2;
		[Serialize("int__3"                  )] public int int__3;
		[Serialize("Generic<Event>__4"       )] public Generic<Event> Generic_Event__4;
		[Serialize("Path__5"                 )] public Path Path__5;
		[Serialize("Enum_RFR_0__6"           )] public Enum_RFR_0 Enum_RFR_0__6;
		[Serialize("int__7"                  )] public int int__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR) {
				SerializeField(s, nameof(Generic_Event__0));
				SerializeField(s, nameof(Path__1));
				SerializeField(s, nameof(Enum_RJR_0__2));
				SerializeField(s, nameof(int__3));
			} else if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(Generic_Event__4));
				SerializeField(s, nameof(Path__5));
				SerializeField(s, nameof(Enum_RFR_0__6));
				SerializeField(s, nameof(int__7));
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
		public enum Enum_RJR_0 {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
		}
	}
}

