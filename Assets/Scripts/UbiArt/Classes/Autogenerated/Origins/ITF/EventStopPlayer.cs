using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventStopPlayer : CSerializable {
		[Serialize("stop")] public bool stop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stop));
		}
		public override uint? ClassCRC => 0xC8D691F9;
	}
}

