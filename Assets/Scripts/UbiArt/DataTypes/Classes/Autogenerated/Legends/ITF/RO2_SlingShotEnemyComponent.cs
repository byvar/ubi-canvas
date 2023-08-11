namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_SlingShotEnemyComponent : ActorComponent {
		public int CheckFirePatch;
		public float SuffocateTimer;
		public float DefaultFlameSize;
		public float LastSpitFireAngle;
		public State StartingState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				CheckFirePatch = s.Serialize<int>(CheckFirePatch, name: "CheckFirePatch");
				SuffocateTimer = s.Serialize<float>(SuffocateTimer, name: "SuffocateTimer");
				DefaultFlameSize = s.Serialize<float>(DefaultFlameSize, name: "DefaultFlameSize");
				LastSpitFireAngle = s.Serialize<float>(LastSpitFireAngle, name: "LastSpitFireAngle");
				StartingState = s.Serialize<State>(StartingState, name: "StartingState");
			}
		}
		public enum State {
			[Serialize("State_HoldGround" )] HoldGround = 2,
			[Serialize("State_Fly"        )] Fly = 4,
			[Serialize("State_InfinitFire")] InfinitFire = 10,
		}
		public override uint? ClassCRC => 0xE13278D3;
	}
}

