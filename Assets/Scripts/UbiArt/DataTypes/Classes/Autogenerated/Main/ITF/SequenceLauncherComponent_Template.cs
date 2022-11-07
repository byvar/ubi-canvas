namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class SequenceLauncherComponent_Template : ActorComponent_Template {
		public EventSequenceControl eventPlaySequence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
			} else {
				eventPlaySequence = s.SerializeObject<EventSequenceControl>(eventPlaySequence, name: "eventPlaySequence");
			}
		}
		public override uint? ClassCRC => 0x4CB88B86;
	}
}

