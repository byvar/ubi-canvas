using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_ChildLaunchComponent : ActorComponent {
		public uint nextLaunchIndex;
		public int hintFxEnabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				nextLaunchIndex = s.Serialize<uint>(nextLaunchIndex, name: "nextLaunchIndex");
			}
			if (s.HasFlags(SerializeFlags.Default)) {
				hintFxEnabled = s.Serialize<int>(hintFxEnabled, name: "hintFxEnabled");
			}
		}
		public override uint? ClassCRC => 0xD18C8678;
	}
}

