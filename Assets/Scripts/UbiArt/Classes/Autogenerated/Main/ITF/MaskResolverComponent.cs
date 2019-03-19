using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class MaskResolverComponent : ActorComponent {
		[Serialize("clearFrontLightBuffer")] public bool clearFrontLightBuffer;
		[Serialize("clearFrontLightColor" )] public Color clearFrontLightColor;
		[Serialize("clearBackLightBuffer" )] public bool clearBackLightBuffer;
		[Serialize("clearBackLightColor"  )] public Color clearBackLightColor;
		[Serialize("blurSize"             )] public float blurSize;
		[Serialize("blurFrontLightBuffer" )] public int blurFrontLightBuffer;
		[Serialize("blurBackLightBuffer"  )] public int blurBackLightBuffer;
		[Serialize("blurQuality"          )] public uint blurQuality;
		[Serialize("blurSize"             )] public uint blurSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(clearFrontLightBuffer));
				SerializeField(s, nameof(clearFrontLightColor));
				SerializeField(s, nameof(clearBackLightBuffer));
				SerializeField(s, nameof(clearBackLightColor));
				SerializeField(s, nameof(blurFrontLightBuffer));
				SerializeField(s, nameof(blurBackLightBuffer));
				SerializeField(s, nameof(blurQuality));
				SerializeField(s, nameof(blurSize));
			} else {
				SerializeField(s, nameof(clearFrontLightBuffer));
				SerializeField(s, nameof(clearFrontLightColor));
				SerializeField(s, nameof(clearBackLightBuffer));
				SerializeField(s, nameof(clearBackLightColor));
				SerializeField(s, nameof(blurSize));
			}
		}
		public override uint? ClassCRC => 0x93D66A6E;
	}
}

