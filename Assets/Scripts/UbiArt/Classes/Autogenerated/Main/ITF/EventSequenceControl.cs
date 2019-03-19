using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class EventSequenceControl : Event {
		[Serialize("state"     )] public Enum_state state;
		[Serialize("label"     )] public string label;
		[Serialize("forceLabel")] public bool forceLabel;
		[Serialize("state"     )] public SequencePlayerComponent__State state;
		[Serialize("sender"    )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(state));
				SerializeField(s, nameof(label));
				SerializeField(s, nameof(forceLabel));
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(state));
				SerializeField(s, nameof(label));
				SerializeField(s, nameof(forceLabel));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(state));
				SerializeField(s, nameof(label));
				SerializeField(s, nameof(forceLabel));
			} else {
				SerializeField(s, nameof(state));
				SerializeField(s, nameof(label));
				SerializeField(s, nameof(forceLabel));
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
		public enum SequencePlayerComponent__State {
			[Serialize("SequencePlayerComponent::State_Stopped")] Stopped = 0,
			[Serialize("SequencePlayerComponent::State_Playing")] Playing = 1,
			[Serialize("SequencePlayerComponent::State_Paused" )] Paused = 2,
		}
		public enum Enum_state {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x449E20A4;
	}
}

