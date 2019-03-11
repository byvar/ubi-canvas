using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_PlatformTreeComponent : CSerializable {
		[Serialize("startActivated")] public bool startActivated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startActivated));
			}
		}
		public override uint? ClassCRC => 0xF4D18DFC;
	}
}

