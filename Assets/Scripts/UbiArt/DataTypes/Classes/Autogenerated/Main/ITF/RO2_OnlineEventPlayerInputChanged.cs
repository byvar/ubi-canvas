namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_OnlineEventPlayerInputChanged : Event {
		public bool jump;
		public bool helico;
		public bool attack;
		public bool sprint;
		public Vec2d hitWantedDir;
		public char moveDir;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			jump = s.Serialize<bool>(jump, name: "jump");
			helico = s.Serialize<bool>(helico, name: "helico");
			attack = s.Serialize<bool>(attack, name: "attack");
			sprint = s.Serialize<bool>(sprint, name: "sprint");
			hitWantedDir = s.SerializeObject<Vec2d>(hitWantedDir, name: "hitWantedDir");
			moveDir = s.Serialize<char>(moveDir, name: "moveDir");
		}
		public override uint? ClassCRC => 0x9F92E15E;
	}
}

