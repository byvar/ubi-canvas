using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class MaskResolverComponent : ActorComponent {
		public bool clearFrontLightBuffer;
		public Color clearFrontLightColor;
		public bool clearBackLightBuffer;
		public Color clearBackLightColor;
		public float blurSize;
		public int blurFrontLightBuffer;
		public int blurBackLightBuffer;
		public uint blurQuality;
		public uint blurSize2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				clearFrontLightBuffer = s.Serialize<bool>(clearFrontLightBuffer, name: "clearFrontLightBuffer");
				clearFrontLightColor = s.SerializeObject<Color>(clearFrontLightColor, name: "clearFrontLightColor");
				clearBackLightBuffer = s.Serialize<bool>(clearBackLightBuffer, name: "clearBackLightBuffer");
				clearBackLightColor = s.SerializeObject<Color>(clearBackLightColor, name: "clearBackLightColor");
				blurFrontLightBuffer = s.Serialize<int>(blurFrontLightBuffer, name: "blurFrontLightBuffer");
				blurBackLightBuffer = s.Serialize<int>(blurBackLightBuffer, name: "blurBackLightBuffer");
				blurQuality = s.Serialize<uint>(blurQuality, name: "blurQuality");
				blurSize2 = s.Serialize<uint>(blurSize2, name: "blurSize");
			} else {
				clearFrontLightBuffer = s.Serialize<bool>(clearFrontLightBuffer, name: "clearFrontLightBuffer");
				clearFrontLightColor = s.SerializeObject<Color>(clearFrontLightColor, name: "clearFrontLightColor");
				clearBackLightBuffer = s.Serialize<bool>(clearBackLightBuffer, name: "clearBackLightBuffer");
				clearBackLightColor = s.SerializeObject<Color>(clearBackLightColor, name: "clearBackLightColor");
				blurSize = s.Serialize<float>(blurSize, name: "blurSize");
			}
		}
		public override uint? ClassCRC => 0x93D66A6E;
	}
}

