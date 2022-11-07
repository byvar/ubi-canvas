namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ElectoonSpawnerComponent : CSerializable {
		public uint numToSpawn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			numToSpawn = s.Serialize<uint>(numToSpawn, name: "numToSpawn");
		}
		public override uint? ClassCRC => 0x34065C0A;
	}
}

