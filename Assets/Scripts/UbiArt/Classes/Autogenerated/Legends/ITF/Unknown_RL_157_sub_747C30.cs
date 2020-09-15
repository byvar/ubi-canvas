using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_157_sub_747C30 : CSerializable {
		public Angle uvRotationSpeedSelected;
		public Angle uvRotationSpeedUnselected;
		public Color colorFactorSelected;
		public Color colorFactorUnselected;
		public float colorBlendTime;
		public float hightlightAlphaMin;
		public float hightlightAlpha;
		public float hightlightPeriod;
		public float hightlightMinBlendSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uvRotationSpeedSelected = s.SerializeObject<Angle>(uvRotationSpeedSelected, name: "uvRotationSpeedSelected");
			uvRotationSpeedUnselected = s.SerializeObject<Angle>(uvRotationSpeedUnselected, name: "uvRotationSpeedUnselected");
			colorFactorSelected = s.SerializeObject<Color>(colorFactorSelected, name: "colorFactorSelected");
			colorFactorUnselected = s.SerializeObject<Color>(colorFactorUnselected, name: "colorFactorUnselected");
			colorBlendTime = s.Serialize<float>(colorBlendTime, name: "colorBlendTime");
			hightlightAlphaMin = s.Serialize<float>(hightlightAlphaMin, name: "hightlightAlphaMin");
			hightlightAlpha = s.Serialize<float>(hightlightAlpha, name: "hightlightAlpha");
			hightlightPeriod = s.Serialize<float>(hightlightPeriod, name: "hightlightPeriod");
			hightlightMinBlendSpeed = s.Serialize<float>(hightlightMinBlendSpeed, name: "hightlightMinBlendSpeed");
		}
		public override uint? ClassCRC => 0x775D1B5B;
	}
}

