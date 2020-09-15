using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InteractionManager_Template : CSerializable {
		public float defaultCameraDistanceToInteractiveButton;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			defaultCameraDistanceToInteractiveButton = s.Serialize<float>(defaultCameraDistanceToInteractiveButton, name: "defaultCameraDistanceToInteractiveButton");
		}
		public override uint? ClassCRC => 0xA742BC85;
	}
}

