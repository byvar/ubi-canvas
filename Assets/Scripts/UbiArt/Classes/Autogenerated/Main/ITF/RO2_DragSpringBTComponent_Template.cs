using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DragSpringBTComponent_Template : BTAIComponent_Template {
		[Serialize("disablePhysics")] public bool disablePhysics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(disablePhysics));
		}
		public override uint? ClassCRC => 0x397DE58B;
	}
}

