namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_TimeAttackFlagComponent_Template : ActorComponent_Template {
		public float waitTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitTime = s.Serialize<float>(waitTime, name: "waitTime");
		}
		public override uint? ClassCRC => 0x96013423;
	}
}

