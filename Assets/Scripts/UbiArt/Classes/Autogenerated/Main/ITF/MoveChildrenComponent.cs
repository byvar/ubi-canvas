using UnityEngine;

namespace UbiArt.ITF {
	public partial class MoveChildrenComponent : ActorComponent {
		[Serialize("isActive")] public bool isActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isActive));
		}
		public override uint? ClassCRC => 0x83124BA2;
	}
}

