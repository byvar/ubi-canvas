using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class ClearColorComponent : ActorComponent {
		[Serialize("clearColor"          )] public SubRenderParam_ClearColor clearColor;
		[Serialize("Weight"              )] public float Weight;
		[Serialize("Priority"            )] public uint Priority;
		[Serialize("clearColor"          )] public Color clearColor2;
		[Serialize("clearFrontLightColor")] public Color clearFrontLightColor;
		[Serialize("clearBackLightColor" )] public Color clearBackLightColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(clearColor2));
				SerializeField(s, nameof(clearFrontLightColor));
				SerializeField(s, nameof(clearBackLightColor));
			} else {
				SerializeField(s, nameof(clearColor));
				SerializeField(s, nameof(Weight));
				SerializeField(s, nameof(Priority));
			}
		}
		public override uint? ClassCRC => 0xAEBB218B;
	}
}

