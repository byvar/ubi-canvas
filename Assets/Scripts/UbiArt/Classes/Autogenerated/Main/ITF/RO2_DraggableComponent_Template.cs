using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DraggableComponent_Template : ActorComponent_Template {
		public Vec2d offsetDrag;
		public float smoothFactor;
		public float smoothFactorOnPoly;
		public float smoothFactorOnDoublePoly;
		public float speedMaxBullet;
		public float speedBulletMultiplier;
		public float speedToBullet;
		public float smoothFactorCoeff;
		public float radiusMax;
		public float borderBounciness;
		public float borderDurationSpring;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			offsetDrag = s.SerializeObject<Vec2d>(offsetDrag, name: "offsetDrag");
			smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
			smoothFactorOnPoly = s.Serialize<float>(smoothFactorOnPoly, name: "smoothFactorOnPoly");
			smoothFactorOnDoublePoly = s.Serialize<float>(smoothFactorOnDoublePoly, name: "smoothFactorOnDoublePoly");
			speedMaxBullet = s.Serialize<float>(speedMaxBullet, name: "speedMaxBullet");
			speedBulletMultiplier = s.Serialize<float>(speedBulletMultiplier, name: "speedBulletMultiplier");
			speedToBullet = s.Serialize<float>(speedToBullet, name: "speedToBullet");
			smoothFactorCoeff = s.Serialize<float>(smoothFactorCoeff, name: "smoothFactorCoeff");
			radiusMax = s.Serialize<float>(radiusMax, name: "radiusMax");
			borderBounciness = s.Serialize<float>(borderBounciness, name: "borderBounciness");
			borderDurationSpring = s.Serialize<float>(borderDurationSpring, name: "borderDurationSpring");
		}
		public override uint? ClassCRC => 0x94FAD866;
	}
}

