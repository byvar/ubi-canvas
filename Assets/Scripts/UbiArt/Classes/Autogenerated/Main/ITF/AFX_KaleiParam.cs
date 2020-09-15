using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class AFX_KaleiParam : CSerializable {
		public bool use;
		public float pixelSize;
		public Vec2d UV1;
		public Vec2d UV2;
		public Vec2d UV3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
			} else {
				use = s.Serialize<bool>(use, name: "use");
			}
			pixelSize = s.Serialize<float>(pixelSize, name: "pixelSize");
			UV1 = s.SerializeObject<Vec2d>(UV1, name: "UV1");
			UV2 = s.SerializeObject<Vec2d>(UV2, name: "UV2");
			UV3 = s.SerializeObject<Vec2d>(UV3, name: "UV3");
		}
	}
}

