namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PuzzlePieceComponent_Template : ActorComponent_Template {
		public uint lineCount;
		public uint columnCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lineCount = s.Serialize<uint>(lineCount, name: "lineCount");
			columnCount = s.Serialize<uint>(columnCount, name: "columnCount");
		}
		public override uint? ClassCRC => 0x224CA0A3;
	}
}

