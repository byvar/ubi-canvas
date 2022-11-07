namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_GameGlobalsDurationSinceJoinCondition : online.GameGlobalsCondition {
		public online.TimeInterval duration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			duration = s.SerializeObject<online.TimeInterval>(duration, name: "duration");
		}
		public override uint? ClassCRC => 0xD64891C8;
	}
}

