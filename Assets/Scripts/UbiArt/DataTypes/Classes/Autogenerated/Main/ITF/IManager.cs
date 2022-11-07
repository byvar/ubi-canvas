namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class IManager : CSerializable {
		public Path ConfigPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ConfigPath = s.SerializeObject<Path>(ConfigPath, name: "ConfigPath");
		}
		public override uint? ClassCRC => 0xAC97A187;
	}
}

