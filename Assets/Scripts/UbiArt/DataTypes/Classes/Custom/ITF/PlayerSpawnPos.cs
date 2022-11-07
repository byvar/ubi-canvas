namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RL)]
	public partial class PlayerSpawnPos : CSerializable {
		public StringID playerID;
		public Vec2d offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playerID = s.SerializeObject<StringID>(playerID, name: "playerID");
			offset = s.SerializeObject<Vec2d>(offset, name: "offset");
		}
	}
}
