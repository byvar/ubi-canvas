namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_Score : CSerializable {
		public CListP<uint> lumCount;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lumCount = s.SerializeObject<CListP<uint>>(lumCount, name: "lumCount");
		}
	}
}

