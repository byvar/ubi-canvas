using UnityEngine;

namespace UbiArt.ITF {
	public partial class EditableShapeComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6B184832;
	}
}

