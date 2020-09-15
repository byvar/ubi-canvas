using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class AFX_RadialParam : CSerializable {
		public bool use;
		public Vec2d centerOffset;
		public float strength;
		public float size;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
			} else {
				use = s.Serialize<bool>(use, name: "use");
			}
			centerOffset = s.SerializeObject<Vec2d>(centerOffset, name: "centerOffset");
			strength = s.Serialize<float>(strength, name: "strength");
			size = s.Serialize<float>(size, name: "size");
		}
	}
}

