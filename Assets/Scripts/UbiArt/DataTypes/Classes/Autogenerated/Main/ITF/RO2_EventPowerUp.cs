namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_EventPowerUp : Event {
		public StringID id;
		public bool enable;
		public Vec3d startingPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<StringID>(id, name: "id");
			enable = s.Serialize<bool>(enable, name: "enable");
			startingPos = s.SerializeObject<Vec3d>(startingPos, name: "startingPos");
		}
		public override uint? ClassCRC => 0x35C9FDBD;
	}
}

