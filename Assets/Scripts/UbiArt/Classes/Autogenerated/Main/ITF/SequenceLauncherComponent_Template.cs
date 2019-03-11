using UnityEngine;

namespace UbiArt.ITF {
	public partial class SequenceLauncherComponent_Template : ActorComponent_Template {
		[Serialize("eventPlaySequence")] public EventSequenceControl eventPlaySequence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(eventPlaySequence));
		}
		public override uint? ClassCRC => 0x4CB88B86;
	}
}

