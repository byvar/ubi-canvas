using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_BezierNode : CSerializable {
		public Vec3d pos;
		public Vec2d tangent;
		public float scale;
		public Nullable<RO2_BezierTween> tween;
		public float lumChainSpeedMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pos = s.SerializeObject<Vec3d>(pos, name: "pos");
			tangent = s.SerializeObject<Vec2d>(tangent, name: "tangent");
			scale = s.Serialize<float>(scale, name: "scale");
			tween = s.SerializeObject<Nullable<RO2_BezierTween>>(tween, name: "tween");
			lumChainSpeedMultiplier = s.Serialize<float>(lumChainSpeedMultiplier, name: "lumChainSpeedMultiplier");
		}
	}
}

