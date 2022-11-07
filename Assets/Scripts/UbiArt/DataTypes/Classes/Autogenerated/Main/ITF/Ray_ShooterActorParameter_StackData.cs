namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.RL)]
	public partial class Ray_ShooterActorParameter_StackData : CSerializable {
		public Path projectilePath;
		public uint numProjectiles;
		public uint max;
		public uint inStackSize;
		public int notStackable;
		public int notStackableKeepAlive;
		public StringID type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			projectilePath = s.SerializeObject<Path>(projectilePath, name: "projectilePath");
			numProjectiles = s.Serialize<uint>(numProjectiles, name: "numProjectiles");
			max = s.Serialize<uint>(max, name: "max");
			inStackSize = s.Serialize<uint>(inStackSize, name: "inStackSize");
			notStackable = s.Serialize<int>(notStackable, name: "notStackable");
			notStackableKeepAlive = s.Serialize<int>(notStackableKeepAlive, name: "notStackableKeepAlive");
			type = s.SerializeObject<StringID>(type, name: "type");
		}
	}
}

