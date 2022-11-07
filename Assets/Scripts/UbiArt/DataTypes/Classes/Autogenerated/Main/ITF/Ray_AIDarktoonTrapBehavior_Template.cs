namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIDarktoonTrapBehavior_Template : TemplateAIBehavior {
		public int startsHidden;
		public float heightFactor;
		public float attackRate;
		public float coolDownDuration;
		public uint returnHitMaxLevel;
		public Placeholder outerShape;
		public Placeholder innerShape;
		public Placeholder idle;
		public Placeholder attack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startsHidden = s.Serialize<int>(startsHidden, name: "startsHidden");
			heightFactor = s.Serialize<float>(heightFactor, name: "heightFactor");
			attackRate = s.Serialize<float>(attackRate, name: "attackRate");
			coolDownDuration = s.Serialize<float>(coolDownDuration, name: "coolDownDuration");
			returnHitMaxLevel = s.Serialize<uint>(returnHitMaxLevel, name: "returnHitMaxLevel");
			outerShape = s.SerializeObject<Placeholder>(outerShape, name: "outerShape");
			innerShape = s.SerializeObject<Placeholder>(innerShape, name: "innerShape");
			idle = s.SerializeObject<Placeholder>(idle, name: "idle");
			attack = s.SerializeObject<Placeholder>(attack, name: "attack");
		}
		public override uint? ClassCRC => 0xED2F49D6;
	}
}

