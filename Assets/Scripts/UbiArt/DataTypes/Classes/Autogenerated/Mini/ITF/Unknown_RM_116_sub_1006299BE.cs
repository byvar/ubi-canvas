namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class Unknown_RM_116_sub_1006299BE : CSerializable {
		public Placeholder RLC_GameSequence_EndLevel;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			RLC_GameSequence_EndLevel = s.SerializeObject<Placeholder>(RLC_GameSequence_EndLevel, name: "RLC_GameSequence_EndLevel");
		}
		public override uint? ClassCRC => 0xDA009D33;
	}
}

