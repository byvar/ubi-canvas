using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventEnableAutoFly : Event {
		[Serialize("skipDelay")] public bool skipDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(skipDelay), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x12BE68F5;
	}
}

