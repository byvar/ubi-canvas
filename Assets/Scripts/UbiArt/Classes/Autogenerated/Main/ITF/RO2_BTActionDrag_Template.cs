using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionDrag_Template : BTAction_Template {
		[Serialize("anim"                       )] public StringID anim;
		[Serialize("animDrop"                   )] public StringID animDrop;
		[Serialize("animFreeFall"               )] public StringID animFreeFall;
		[Serialize("animImpact"                 )] public StringID animImpact;
		[Serialize("animReceiveHitDrag"         )] public StringID animReceiveHitDrag;
		[Serialize("bulletTouchDirNormThreshold")] public float bulletTouchDirNormThreshold;
		[Serialize("DRCSpeedSmoothFactor"       )] public float DRCSpeedSmoothFactor;
		[Serialize("offsetDrag"                 )] public Vector2 offsetDrag;
		[Serialize("speedBulletMultiplier"      )] public float speedBulletMultiplier;
		[Serialize("smoothFactor"               )] public float smoothFactor;
		[Serialize("smoothFactorOnPoly"         )] public float smoothFactorOnPoly;
		[Serialize("smoothFactorOnDoublePoly"   )] public float smoothFactorOnDoublePoly;
		[Serialize("useRehitStim"               )] public bool useRehitStim;
		[Serialize("speedMaxBullet"             )] public float speedMaxBullet;
		[Serialize("acceptRoofCrash"            )] public bool acceptRoofCrash;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(animDrop));
			SerializeField(s, nameof(animFreeFall));
			SerializeField(s, nameof(animImpact));
			SerializeField(s, nameof(animReceiveHitDrag));
			SerializeField(s, nameof(bulletTouchDirNormThreshold));
			SerializeField(s, nameof(DRCSpeedSmoothFactor));
			SerializeField(s, nameof(offsetDrag));
			SerializeField(s, nameof(speedBulletMultiplier));
			SerializeField(s, nameof(smoothFactor));
			SerializeField(s, nameof(smoothFactorOnPoly));
			SerializeField(s, nameof(smoothFactorOnDoublePoly));
			SerializeField(s, nameof(useRehitStim));
			SerializeField(s, nameof(speedMaxBullet));
			SerializeField(s, nameof(acceptRoofCrash));
		}
		public override uint? ClassCRC => 0xB1FA9D86;
	}
}

