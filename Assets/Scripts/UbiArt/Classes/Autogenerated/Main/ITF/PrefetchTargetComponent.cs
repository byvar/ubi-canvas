using UnityEngine;

namespace UbiArt.ITF {
	public partial class PrefetchTargetComponent : ActorComponent {
		[Serialize("ZONE")] public EditableShape ZONE;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ZONE));
		}
		public override uint? ClassCRC => 0x9EF331FE;
	}
}

