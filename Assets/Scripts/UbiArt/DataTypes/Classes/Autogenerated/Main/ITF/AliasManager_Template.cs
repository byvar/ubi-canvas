namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class AliasManager_Template : CSerializable {
		public CMap<StringID, Path> Alias;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Alias = s.SerializeObject<CMap<StringID, Path>>(Alias, name: "Alias");
		}
		public override uint? ClassCRC => 0xF4734BB3;
	}
}

