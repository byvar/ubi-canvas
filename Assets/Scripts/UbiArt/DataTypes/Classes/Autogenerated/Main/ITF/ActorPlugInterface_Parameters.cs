namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class ActorPlugInterface_Parameters : CSerializable {
		public CListO<PlugConfig> configList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			configList = s.SerializeObject<CListO<PlugConfig>>(configList, name: "configList");
		}
	}
}

