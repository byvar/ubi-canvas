namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIRobotPatrolBehavior_Template : CSerializable {
		public Placeholder fall;
		public Placeholder defaultPause;
		public Placeholder attack;
		public float uturnDelay2;
		public Placeholder detectionRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fall = s.SerializeObject<Placeholder>(fall, name: "fall");
			defaultPause = s.SerializeObject<Placeholder>(defaultPause, name: "defaultPause");
			attack = s.SerializeObject<Placeholder>(attack, name: "attack");
			uturnDelay2 = s.Serialize<float>(uturnDelay2, name: "uturnDelay2");
			detectionRange = s.SerializeObject<Placeholder>(detectionRange, name: "detectionRange");
		}
		public override uint? ClassCRC => 0x0782F2B4;
	}
}

