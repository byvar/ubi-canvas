namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class PlugConfig : CSerializable {
		public StringID plugId;
		public uint slotId;
		public Nullable<PlugSnapConfig> snapConfig;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			plugId = s.SerializeObject<StringID>(plugId, name: "plugId");
			slotId = s.Serialize<uint>(slotId, name: "slotId");
			snapConfig = s.SerializeObject<Nullable<PlugSnapConfig>>(snapConfig, name: "snapConfig");
		}
	}
}

