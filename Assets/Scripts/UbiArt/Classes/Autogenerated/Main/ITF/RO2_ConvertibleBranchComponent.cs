using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ConvertibleBranchComponent : RO2_BezierBranchComponent {
		[Serialize("seed")] public uint seed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(seed));
			}
		}
		public override uint? ClassCRC => 0xEBA1C9DE;
	}
}

