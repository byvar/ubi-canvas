namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventSpawnRewardLum : Ray_EventSpawnReward {
		public int forceYellow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			forceYellow = s.Serialize<int>(forceYellow, name: "forceYellow");
		}
		public override uint? ClassCRC => 0x306D9812;
	}
}

