using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionFollowActorSpring_Template : BTAction_Template {
		[Serialize("animFollow"          )] public StringID animFollow;
		[Serialize("animSpring"          )] public StringID animSpring;
		[Serialize("animExplode"         )] public StringID animExplode;
		[Serialize("radiusMax"           )] public float radiusMax;
		[Serialize("durationReturnSpring")] public float durationReturnSpring;
		[Serialize("forceMinBeforeExit"  )] public float forceMinBeforeExit;
		[Serialize("speedReturnSpring"   )] public float speedReturnSpring;
		[Serialize("explode"             )] public bool explode;
		[Serialize("offsetFollow"        )] public Vec2d offsetFollow;
		[Serialize("smoothFactor"        )] public float smoothFactor;
		[Serialize("followMaxDist"       )] public float followMaxDist;
		[Serialize("followMaxTime"       )] public float followMaxTime;
		[Serialize("minPulsation"        )] public float minPulsation;
		[Serialize("maxPulsation"        )] public float maxPulsation;
		[Serialize("minScaleAtStart"     )] public float minScaleAtStart;
		[Serialize("maxScaleAtStart"     )] public float maxScaleAtStart;
		[Serialize("minScaleAtEnd"       )] public float minScaleAtEnd;
		[Serialize("maxScaleAtEnd"       )] public float maxScaleAtEnd;
		[Serialize("speedBlend"          )] public float speedBlend;
		[Serialize("speedMin"            )] public float speedMin;
		[Serialize("speedMax"            )] public float speedMax;
		[Serialize("blendAtSpeedMin"     )] public float blendAtSpeedMin;
		[Serialize("blendAtSpeedMax"     )] public float blendAtSpeedMax;
		[Serialize("followStartFX"       )] public StringID followStartFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animFollow));
			SerializeField(s, nameof(animSpring));
			SerializeField(s, nameof(animExplode));
			SerializeField(s, nameof(radiusMax));
			SerializeField(s, nameof(durationReturnSpring));
			SerializeField(s, nameof(forceMinBeforeExit));
			SerializeField(s, nameof(speedReturnSpring));
			SerializeField(s, nameof(explode));
			SerializeField(s, nameof(offsetFollow));
			SerializeField(s, nameof(smoothFactor));
			SerializeField(s, nameof(followMaxDist));
			SerializeField(s, nameof(followMaxTime));
			SerializeField(s, nameof(minPulsation));
			SerializeField(s, nameof(maxPulsation));
			SerializeField(s, nameof(minScaleAtStart));
			SerializeField(s, nameof(maxScaleAtStart));
			SerializeField(s, nameof(minScaleAtEnd));
			SerializeField(s, nameof(maxScaleAtEnd));
			SerializeField(s, nameof(speedBlend));
			SerializeField(s, nameof(speedMin));
			SerializeField(s, nameof(speedMax));
			SerializeField(s, nameof(blendAtSpeedMin));
			SerializeField(s, nameof(blendAtSpeedMax));
			SerializeField(s, nameof(followStartFX));
		}
		public override uint? ClassCRC => 0x38C2A06A;
	}
}

