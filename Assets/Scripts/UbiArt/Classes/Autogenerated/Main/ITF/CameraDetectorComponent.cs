using UnityEngine;

namespace UbiArt.ITF {
	public partial class CameraDetectorComponent : ShapeDetectorComponent {
		[Serialize("remote")] public bool remote;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(remote));
		}
		public override uint? ClassCRC => 0x75AA523D;
	}
}

