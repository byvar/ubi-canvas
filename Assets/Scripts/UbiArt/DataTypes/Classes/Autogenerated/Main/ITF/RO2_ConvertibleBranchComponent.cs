using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_ConvertibleBranchComponent : RO2_BezierBranchComponent {
		public uint seed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
			} else {
				seed = s.Serialize<uint>(seed, name: "seed");
			}
		}
		public override uint? ClassCRC => 0xEBA1C9DE;
	}
}

