namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GameGlobalsCreatureCountCondition : online.GameGlobalsCondition {
		public uint count;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			count = s.Serialize<uint>(count, name: "count");
		}
		public override uint? ClassCRC => 0x0EF97764;
	}
}

