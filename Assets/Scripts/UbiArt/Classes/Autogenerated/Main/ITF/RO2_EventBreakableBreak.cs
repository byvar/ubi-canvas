using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventBreakableBreak : Event {
		[Serialize("Break"    )] public bool Break;
		[Serialize("immediate")] public bool immediate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Break));
			SerializeField(s, nameof(immediate));
		}
		public override uint? ClassCRC => 0xE9121171;
	}
}

