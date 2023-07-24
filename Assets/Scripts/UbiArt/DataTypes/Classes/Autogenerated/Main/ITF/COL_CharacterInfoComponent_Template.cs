namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CharacterInfoComponent_Template : ActorComponent_Template {
		public StringID characterID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			characterID = s.SerializeObject<StringID>(characterID, name: "characterID");
		}
		public override uint? ClassCRC => 0x0EC51E00;
	}
}

