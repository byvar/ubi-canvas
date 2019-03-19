using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class EditableShapeComponent : ActorComponent {
		[Serialize("ZONE")] public EditableShape ZONE;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ZONE));
		}
		public override uint? ClassCRC => 0xB1C11137;
	}
}

