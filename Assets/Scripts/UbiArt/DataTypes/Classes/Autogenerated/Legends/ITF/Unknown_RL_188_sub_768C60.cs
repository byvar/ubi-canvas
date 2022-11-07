namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_188_sub_768C60 : CSerializable {
		public Path costumePainting;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			costumePainting = s.SerializeObject<Path>(costumePainting, name: "costumePainting");
		}
		public override uint? ClassCRC => 0x0E10C15E;
	}
}

