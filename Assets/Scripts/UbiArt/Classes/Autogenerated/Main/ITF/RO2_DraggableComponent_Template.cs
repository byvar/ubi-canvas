using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DraggableComponent_Template : ActorComponent_Template {
		[Serialize("offsetDrag"              )] public Vector2 offsetDrag;
		[Serialize("smoothFactor"            )] public float smoothFactor;
		[Serialize("smoothFactorOnPoly"      )] public float smoothFactorOnPoly;
		[Serialize("smoothFactorOnDoublePoly")] public float smoothFactorOnDoublePoly;
		[Serialize("speedMaxBullet"          )] public float speedMaxBullet;
		[Serialize("speedBulletMultiplier"   )] public float speedBulletMultiplier;
		[Serialize("speedToBullet"           )] public float speedToBullet;
		[Serialize("smoothFactorCoeff"       )] public float smoothFactorCoeff;
		[Serialize("radiusMax"               )] public float radiusMax;
		[Serialize("borderBounciness"        )] public float borderBounciness;
		[Serialize("borderDurationSpring"    )] public float borderDurationSpring;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(offsetDrag));
			SerializeField(s, nameof(smoothFactor));
			SerializeField(s, nameof(smoothFactorOnPoly));
			SerializeField(s, nameof(smoothFactorOnDoublePoly));
			SerializeField(s, nameof(speedMaxBullet));
			SerializeField(s, nameof(speedBulletMultiplier));
			SerializeField(s, nameof(speedToBullet));
			SerializeField(s, nameof(smoothFactorCoeff));
			SerializeField(s, nameof(radiusMax));
			SerializeField(s, nameof(borderBounciness));
			SerializeField(s, nameof(borderDurationSpring));
		}
		public override uint? ClassCRC => 0x94FAD866;
	}
}

