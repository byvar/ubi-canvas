using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class CameraDetectorComponent_Template : ShapeDetectorComponent_Template {
		public bool triggEachCameraController;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			triggEachCameraController = s.Serialize<bool>(triggEachCameraController, name: "triggEachCameraController");
		}
		public override uint? ClassCRC => 0x752CD0BE;
	}
}

