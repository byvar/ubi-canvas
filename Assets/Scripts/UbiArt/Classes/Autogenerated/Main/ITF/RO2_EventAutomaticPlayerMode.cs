using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventAutomaticPlayerMode : Event {
		[Serialize("active")] public bool active;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(active));
		}
		public override uint? ClassCRC => 0xF96AE5FF;
	}
}

