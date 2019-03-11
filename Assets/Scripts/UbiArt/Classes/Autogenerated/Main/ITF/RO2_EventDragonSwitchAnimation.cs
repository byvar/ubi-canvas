using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventDragonSwitchAnimation : Event {
		[Serialize("Animation")] public StringID Animation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Animation));
		}
		public override uint? ClassCRC => 0xF954098D;
	}
}

