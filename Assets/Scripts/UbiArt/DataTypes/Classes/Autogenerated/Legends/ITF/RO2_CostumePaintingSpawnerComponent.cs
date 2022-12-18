namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_CostumePaintingSpawnerComponent : CSerializable {
		public StringID tag;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tag = s.SerializeObject<StringID>(tag, name: "tag");
		}
		public override uint? ClassCRC => 0xA10B8681;
	}
}

