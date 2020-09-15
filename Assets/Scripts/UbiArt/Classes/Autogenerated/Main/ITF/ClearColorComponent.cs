using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class ClearColorComponent : ActorComponent {
		public SubRenderParam_ClearColor clearColor;
		public float Weight;
		public uint Priority;
		public Color clearColor2;
		public Color clearFrontLightColor;
		public Color clearBackLightColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				clearColor2 = s.SerializeObject<Color>(clearColor2, name: "clearColor2");
				clearFrontLightColor = s.SerializeObject<Color>(clearFrontLightColor, name: "clearFrontLightColor");
				clearBackLightColor = s.SerializeObject<Color>(clearBackLightColor, name: "clearBackLightColor");
			} else {
				clearColor = s.SerializeObject<SubRenderParam_ClearColor>(clearColor, name: "clearColor");
				Weight = s.Serialize<float>(Weight, name: "Weight");
				Priority = s.Serialize<uint>(Priority, name: "Priority");
			}
		}
		public override uint? ClassCRC => 0xAEBB218B;
	}
}

