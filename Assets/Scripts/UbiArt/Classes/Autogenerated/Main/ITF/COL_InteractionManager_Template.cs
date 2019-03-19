using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InteractionManager_Template : CSerializable {
		[Serialize("defaultCameraDistanceToInteractiveButton")] public float defaultCameraDistanceToInteractiveButton;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultCameraDistanceToInteractiveButton));
		}
		public override uint? ClassCRC => 0xA742BC85;
	}
}

