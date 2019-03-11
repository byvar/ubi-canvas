using UnityEngine;

namespace UbiArt.ITF {
	public partial class MaskResolverComponent : ActorComponent {
		[Serialize("clearFrontLightBuffer")] public bool clearFrontLightBuffer;
		[Serialize("clearFrontLightColor" )] public Color clearFrontLightColor;
		[Serialize("clearBackLightBuffer" )] public bool clearBackLightBuffer;
		[Serialize("clearBackLightColor"  )] public Color clearBackLightColor;
		[Serialize("blurSize"             )] public float blurSize;
		[Serialize("blurFrontLightBuffer" )] public bool blurFrontLightBuffer;
		[Serialize("blurBackLightBuffer"  )] public bool blurBackLightBuffer;
		[Serialize("blurQuality"          )] public uint blurQuality;
		[Serialize("blurSize"             )] public uint blurSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
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

