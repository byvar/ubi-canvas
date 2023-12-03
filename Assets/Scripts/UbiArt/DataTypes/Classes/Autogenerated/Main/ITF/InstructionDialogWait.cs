namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class InstructionDialogWait : InstructionDialog {
		public float time = 1f;
		public float timeMin;
		public float timeMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			time = s.Serialize<float>(time, name: "time");
			timeMin = s.Serialize<float>(timeMin, name: "timeMin");
			timeMax = s.Serialize<float>(timeMax, name: "timeMax");
		}
		public override uint? ClassCRC => 0x03259DFB;
	}
}

