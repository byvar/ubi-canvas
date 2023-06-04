namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_GameSequence_StartLevel : CSerializable {
		public Placeholder RLC_GameSequence_StartLevel;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			RLC_GameSequence_StartLevel = s.SerializeObject<Placeholder>(RLC_GameSequence_StartLevel, name: "RLC_GameSequence_StartLevel");
		}
		public override uint? ClassCRC => 0x372966BF;
	}
}

