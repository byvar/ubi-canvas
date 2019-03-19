using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_157_sub_747C30 : CSerializable {
		[Serialize("uvRotationSpeedSelected"  )] public Angle uvRotationSpeedSelected;
		[Serialize("uvRotationSpeedUnselected")] public Angle uvRotationSpeedUnselected;
		[Serialize("colorFactorSelected"      )] public Color colorFactorSelected;
		[Serialize("colorFactorUnselected"    )] public Color colorFactorUnselected;
		[Serialize("colorBlendTime"           )] public float colorBlendTime;
		[Serialize("hightlightAlphaMin"       )] public float hightlightAlphaMin;
		[Serialize("hightlightAlpha"          )] public float hightlightAlpha;
		[Serialize("hightlightPeriod"         )] public float hightlightPeriod;
		[Serialize("hightlightMinBlendSpeed"  )] public float hightlightMinBlendSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uvRotationSpeedSelected));
			SerializeField(s, nameof(uvRotationSpeedUnselected));
			SerializeField(s, nameof(colorFactorSelected));
			SerializeField(s, nameof(colorFactorUnselected));
			SerializeField(s, nameof(colorBlendTime));
			SerializeField(s, nameof(hightlightAlphaMin));
			SerializeField(s, nameof(hightlightAlpha));
			SerializeField(s, nameof(hightlightPeriod));
			SerializeField(s, nameof(hightlightMinBlendSpeed));
		}
		public override uint? ClassCRC => 0x775D1B5B;
	}
}

