namespace UbiArt.ITF {
	public partial class RegionPathList : CSerializable {
		public CListO<Path> RegionBackgroundPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			RegionBackgroundPath = s.SerializeObject<CListO<Path>>(RegionBackgroundPath, name: "RegionBackgroundPath");
		}
	}
}

