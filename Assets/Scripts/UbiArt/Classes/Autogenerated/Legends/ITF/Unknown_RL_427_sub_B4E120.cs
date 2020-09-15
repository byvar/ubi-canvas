using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_427_sub_B4E120 : ActorComponent {
		public int CheckFirePatch;
		public float SuffocateTimer;
		public float DefaultFlameSize;
		public float LastSpitFireAngle;
		public Enum_StartingState StartingState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				CheckFirePatch = s.Serialize<int>(CheckFirePatch, name: "CheckFirePatch");
				SuffocateTimer = s.Serialize<float>(SuffocateTimer, name: "SuffocateTimer");
				DefaultFlameSize = s.Serialize<float>(DefaultFlameSize, name: "DefaultFlameSize");
				LastSpitFireAngle = s.Serialize<float>(LastSpitFireAngle, name: "LastSpitFireAngle");
				StartingState = s.Serialize<Enum_StartingState>(StartingState, name: "StartingState");
			}
		}
		public enum Enum_StartingState {
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_10")] Value_10 = 10,
		}
		public override uint? ClassCRC => 0xE13278D3;
	}
}

