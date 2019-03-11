using UnityEngine;

namespace UbiArt.ITF {
	public partial class MoveChildrenComponent_Template : ActorComponent_Template {
		[Serialize("isActive")] public bool isActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isActive));
		}
		public override uint? ClassCRC => 0x0F928FB7;
	}
}

