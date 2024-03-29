namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class ArenaDoorComponent_Template : ActorComponent_Template {
		public StringID openAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			openAnim = s.SerializeObject<StringID>(openAnim, name: "openAnim");
		}
		public override uint? ClassCRC => 0xCDC36415;
	}
}

