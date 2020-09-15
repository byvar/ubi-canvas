using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ProjectileCustomLaunchComponent : ActorComponent {
		public CList<RO2_BTActionThrowObject_Tools.LaunchData> customLaunchData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				customLaunchData = s.SerializeObject<CList<RO2_BTActionThrowObject_Tools.LaunchData>>(customLaunchData, name: "customLaunchData");
			}
		}
		public override uint? ClassCRC => 0x0E5D219B;
	}
}

