using UnityEngine;

namespace UbiArt.ITF {
	public partial class CameraDetectorComponent_Template : ShapeDetectorComponent_Template {
		[Serialize("triggEachCameraController")] public bool triggEachCameraController;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(triggEachCameraController));
		}
		public override uint? ClassCRC => 0x752CD0BE;
	}
}

