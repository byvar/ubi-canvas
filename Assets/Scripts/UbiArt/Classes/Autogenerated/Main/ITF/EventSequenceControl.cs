using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSequenceControl : Event {
		[Serialize("state"     )] public Enum_state state;
		[Serialize("label"     )] public string label;
		[Serialize("forceLabel")] public bool forceLabel;
		[Serialize("sender"    )] public uint sender;
		[Serialize("state"     )] public SequencePlayerComponent__State state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
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
		public override uint? ClassCRC => 0x449E20A4;
	}
}

