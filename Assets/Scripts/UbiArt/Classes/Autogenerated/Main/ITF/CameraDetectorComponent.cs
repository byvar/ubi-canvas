using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class CameraDetectorComponent : ShapeDetectorComponent {
		public bool remote;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
			} else {
				remote = s.Serialize<bool>(remote, name: "remote");
			}
		}
		public override uint? ClassCRC => 0x75AA523D;
	}
}

