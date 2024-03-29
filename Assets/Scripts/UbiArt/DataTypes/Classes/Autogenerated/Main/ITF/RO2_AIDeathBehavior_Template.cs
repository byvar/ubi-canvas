namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AIDeathBehavior_Template : AIDeathBehavior_Template {
		public Generic<RO2_EventSpawnReward> reward;
		public Path soul;
		public CListP<uint> numRewards = new CListP<uint>() { 0, 1, 2, 4 };
		public bool spawnOnMarker = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			reward = s.SerializeObject<Generic<RO2_EventSpawnReward>>(reward, name: "reward");
			soul = s.SerializeObject<Path>(soul, name: "soul");
			numRewards = s.SerializeObject<CListP<uint>>(numRewards, name: "numRewards");
			spawnOnMarker = s.Serialize<bool>(spawnOnMarker, name: "spawnOnMarker");
		}
		public override uint? ClassCRC => 0x54BE1D59;
	}
}

