using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ProjectileCustomLaunchComponent : ActorComponent {
		[Serialize("customLaunchData")] public CList<RO2_BTActionThrowObject_Tools.LaunchData> customLaunchData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(customLaunchData));
			}
		}
		public override uint? ClassCRC => 0x0E5D219B;
	}
}

