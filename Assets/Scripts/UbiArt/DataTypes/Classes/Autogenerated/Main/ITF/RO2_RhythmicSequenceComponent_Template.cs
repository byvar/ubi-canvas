namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_RhythmicSequenceComponent_Template : ActorComponent_Template {
		public StringID input;
		public bool mainViewRendering;
		public bool remoteViewRendering;
		public uint metronomeID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			input = s.SerializeObject<StringID>(input, name: "input");
			mainViewRendering = s.Serialize<bool>(mainViewRendering, name: "mainViewRendering");
			remoteViewRendering = s.Serialize<bool>(remoteViewRendering, name: "remoteViewRendering");
			metronomeID = s.Serialize<uint>(metronomeID, name: "metronomeID");
		}
		public override uint? ClassCRC => 0x5D3FCD6E;
	}
}

