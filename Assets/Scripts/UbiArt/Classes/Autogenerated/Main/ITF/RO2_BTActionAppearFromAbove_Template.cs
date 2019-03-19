using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionAppearFromAbove_Template : BTAction_Template {
		[Serialize("animFloat"                 )] public StringID animFloat;
		[Serialize("animFall"                  )] public StringID animFall;
		[Serialize("animGround"                )] public StringID animGround;
		[Serialize("groundDistance"            )] public float groundDistance;
		[Serialize("fallDist"                  )] public float fallDist;
		[Serialize("transitionDuration"        )] public float transitionDuration;
		[Serialize("transitionGravityFactorMin")] public float transitionGravityFactorMin;
		[Serialize("transitionGravityFactorMax")] public float transitionGravityFactorMax;
		[Serialize("fallGravityFactor"         )] public float fallGravityFactor;
		[Serialize("floatSpeedMax"             )] public float floatSpeedMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animFloat));
			SerializeField(s, nameof(animFall));
			SerializeField(s, nameof(animGround));
			SerializeField(s, nameof(groundDistance));
			SerializeField(s, nameof(groundDistance));
			SerializeField(s, nameof(fallDist));
			SerializeField(s, nameof(transitionDuration));
			SerializeField(s, nameof(transitionGravityFactorMin));
			SerializeField(s, nameof(transitionGravityFactorMax));
			SerializeField(s, nameof(fallGravityFactor));
			SerializeField(s, nameof(floatSpeedMax));
		}
		public override uint? ClassCRC => 0x7C8CAFA7;
	}
}

