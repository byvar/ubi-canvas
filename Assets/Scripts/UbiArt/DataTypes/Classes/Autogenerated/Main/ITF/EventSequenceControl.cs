namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class EventSequenceControl : Event {
		public Enum_state state2;
		public string label;
		public bool forceLabel;
		public SequencePlayerComponent__State state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				state2 = s.Serialize<Enum_state>(state2, name: "state");
				label = s.Serialize<string>(label, name: "label");
				forceLabel = s.Serialize<bool>(forceLabel, name: "forceLabel");
			} else {
				state = s.Serialize<SequencePlayerComponent__State>(state, name: "state");
				label = s.Serialize<string>(label, name: "label");
				forceLabel = s.Serialize<bool>(forceLabel, name: "forceLabel");
			}
		}
		public enum Enum_state {
			[Serialize("Stopped")] Stopped = 0,
			[Serialize("Playing")] Playing = 1,
			[Serialize("Paused" )] Paused = 2,
		}
		public enum SequencePlayerComponent__State {
			[Serialize("SequencePlayerComponent::State_Stopped")] Stopped = 0,
			[Serialize("SequencePlayerComponent::State_Playing")] Playing = 1,
			[Serialize("SequencePlayerComponent::State_Paused" )] Paused = 2,
		}
		public override uint? ClassCRC => 0x449E20A4;
	}
}

