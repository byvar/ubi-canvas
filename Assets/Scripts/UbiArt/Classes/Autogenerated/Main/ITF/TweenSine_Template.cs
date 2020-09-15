using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TweenSine_Template : TweenTranslation_Template {
		public Vec3d movement;
		public float amplitude;
		public float cycleCount;
		public float cycleOffset;
		public bool CosinusOnX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				movement = s.SerializeObject<Vec3d>(movement, name: "movement");
				amplitude = s.Serialize<float>(amplitude, name: "amplitude");
				cycleCount = s.Serialize<float>(cycleCount, name: "cycleCount");
				cycleOffset = s.Serialize<float>(cycleOffset, name: "cycleOffset");
			} else {
				movement = s.SerializeObject<Vec3d>(movement, name: "movement");
				amplitude = s.Serialize<float>(amplitude, name: "amplitude");
				cycleCount = s.Serialize<float>(cycleCount, name: "cycleCount");
				cycleOffset = s.Serialize<float>(cycleOffset, name: "cycleOffset");
				CosinusOnX = s.Serialize<bool>(CosinusOnX, name: "CosinusOnX");
			}
		}
		public override uint? ClassCRC => 0x2D3E7D44;
	}
}

