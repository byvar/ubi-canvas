using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionAppearParachute_Template : BTAction_Template {
		[Serialize("anim"                   )] public StringID anim;
		[Serialize("animLanding"            )] public StringID animLanding;
		[Serialize("animDropParachute"      )] public StringID animDropParachute;
		[Serialize("animCarryingStart"      )] public StringID animCarryingStart;
		[Serialize("animCarryingStop"       )] public StringID animCarryingStop;
		[Serialize("animFreeFall"           )] public StringID animFreeFall;
		[Serialize("animBaseJump"           )] public StringID animBaseJump;
		[Serialize("animBasejumpToParachute")] public StringID animBasejumpToParachute;
		[Serialize("speed"                  )] public float speed;
		[Serialize("speedBasejump"          )] public float speedBasejump;
		[Serialize("distParachute"          )] public float distParachute;
		[Serialize("parachuteForce"         )] public float parachuteForce;
		[Serialize("lateralForce"           )] public float lateralForce;
		[Serialize("intensity"              )] public float intensity;
		[Serialize("frequency"              )] public float frequency;
		[Serialize("windMultiplier"         )] public float windMultiplier;
		[Serialize("freefallWindMultiplier" )] public float freefallWindMultiplier;
		[Serialize("angleRotateMin"         )] public Angle angleRotateMin;
		[Serialize("angleRotateMax"         )] public Angle angleRotateMax;
		[Serialize("actorParachutePath"     )] public Path actorParachutePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(animLanding));
			SerializeField(s, nameof(animDropParachute));
			SerializeField(s, nameof(animCarryingStart));
			SerializeField(s, nameof(animCarryingStop));
			SerializeField(s, nameof(animFreeFall));
			SerializeField(s, nameof(animBaseJump));
			SerializeField(s, nameof(animBasejumpToParachute));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(speedBasejump));
			SerializeField(s, nameof(distParachute));
			SerializeField(s, nameof(parachuteForce));
			SerializeField(s, nameof(lateralForce));
			SerializeField(s, nameof(intensity));
			SerializeField(s, nameof(frequency));
			SerializeField(s, nameof(windMultiplier));
			SerializeField(s, nameof(freefallWindMultiplier));
			SerializeField(s, nameof(angleRotateMin));
			SerializeField(s, nameof(angleRotateMax));
			SerializeField(s, nameof(actorParachutePath));
		}
		public override uint? ClassCRC => 0x9ED56474;
	}
}

