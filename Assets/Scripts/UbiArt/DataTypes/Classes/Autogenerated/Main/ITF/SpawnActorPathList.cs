namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SpawnActorPathList : CSerializable {
		public CListO<SpawnActorPathTuto> tutoList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tutoList = s.SerializeObject<CListO<SpawnActorPathTuto>>(tutoList, name: "tutoList");
		}
	}
}

