namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameGlobalsFile : CSerializable {
		public CListO<GameGlobalsOverride> overrides;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			overrides = s.SerializeObject<CListO<GameGlobalsOverride>>(overrides, name: "overrides");
		}
	}
}

