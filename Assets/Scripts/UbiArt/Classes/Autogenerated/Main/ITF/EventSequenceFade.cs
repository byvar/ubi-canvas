using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventSequenceFade : Event {
		[Serialize("name"    )] public StringID name;
		[Serialize("isFadeIn")] public bool isFadeIn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(isFadeIn));
		}
		public override uint? ClassCRC => 0x3A768F0A;
	}
}

