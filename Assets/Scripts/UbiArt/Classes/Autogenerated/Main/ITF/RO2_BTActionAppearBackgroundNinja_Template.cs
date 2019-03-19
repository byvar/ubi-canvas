using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionAppearBackgroundNinja_Template : RO2_BTActionAppearBackground_Template {
		[Serialize("animNinjaBack"             )] public StringID animNinjaBack;
		[Serialize("animFallBack"              )] public StringID animFallBack;
		[Serialize("animNinjaFore"             )] public StringID animNinjaFore;
		[Serialize("animFallFore"              )] public StringID animFallFore;
		[Serialize("heightNinja"               )] public float heightNinja;
		[Serialize("fallTime"                  )] public float fallTime;
		[Serialize("jumpToActorMinTime"        )] public float jumpToActorMinTime;
		[Serialize("jumpToActorYFuncPoint0Dist")] public float jumpToActorYFuncPoint0Dist;
		[Serialize("jumpToActorYFuncPoint1Dist")] public float jumpToActorYFuncPoint1Dist;
		[Serialize("jumpToActorXZFuncPoint0T"  )] public float jumpToActorXZFuncPoint0T;
		[Serialize("jumpToActorXZFuncPoint1T"  )] public float jumpToActorXZFuncPoint1T;
		[Serialize("jumpUseEasing"             )] public bool jumpUseEasing;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animNinjaBack));
			SerializeField(s, nameof(animFallBack));
			SerializeField(s, nameof(animNinjaFore));
			SerializeField(s, nameof(animFallFore));
			SerializeField(s, nameof(heightNinja));
			SerializeField(s, nameof(fallTime));
			SerializeField(s, nameof(jumpToActorMinTime));
			SerializeField(s, nameof(jumpToActorYFuncPoint0Dist));
			SerializeField(s, nameof(jumpToActorYFuncPoint1Dist));
			SerializeField(s, nameof(jumpToActorXZFuncPoint0T));
			SerializeField(s, nameof(jumpToActorXZFuncPoint1T));
			SerializeField(s, nameof(jumpUseEasing));
		}
		public override uint? ClassCRC => 0x20D41ABA;
	}
}

