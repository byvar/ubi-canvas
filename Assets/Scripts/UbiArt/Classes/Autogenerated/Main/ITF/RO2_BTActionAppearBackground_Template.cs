using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionAppearBackground_Template : BTAction_Template {
		[Serialize("animStandHideBack")] public StringID animStandHideBack;
		[Serialize("animAnticipBack"  )] public StringID animAnticipBack;
		[Serialize("animJumpBack"     )] public StringID animJumpBack;
		[Serialize("animLandingBack"  )] public StringID animLandingBack;
		[Serialize("animStandHideFore")] public StringID animStandHideFore;
		[Serialize("animAnticipFore"  )] public StringID animAnticipFore;
		[Serialize("animJumpFore"     )] public StringID animJumpFore;
		[Serialize("animLandingFore"  )] public StringID animLandingFore;
		[Serialize("waitForTrigger"   )] public bool waitForTrigger;
		[Serialize("disablePhys"      )] public bool disablePhys;
		[Serialize("resetAngle"       )] public bool resetAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animStandHideBack));
			SerializeField(s, nameof(animAnticipBack));
			SerializeField(s, nameof(animJumpBack));
			SerializeField(s, nameof(animLandingBack));
			SerializeField(s, nameof(animStandHideFore));
			SerializeField(s, nameof(animAnticipFore));
			SerializeField(s, nameof(animJumpFore));
			SerializeField(s, nameof(animLandingFore));
			SerializeField(s, nameof(waitForTrigger));
			SerializeField(s, nameof(disablePhys));
			SerializeField(s, nameof(resetAngle));
		}
		public override uint? ClassCRC => 0x56A59302;
	}
}

