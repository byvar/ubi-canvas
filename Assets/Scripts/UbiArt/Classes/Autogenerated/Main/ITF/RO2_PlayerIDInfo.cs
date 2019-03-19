using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlayerIDInfo : PlayerIDInfo {
		[Serialize("iconTexturePath"  )] public Path iconTexturePath;
		[Serialize("iconSizeInTexture")] public Vector2 iconSizeInTexture;
		[Serialize("deathBubbleColor" )] public Color deathBubbleColor;
		[Serialize("loadingPath"      )] public Path loadingPath;
		[Serialize("treePath"         )] public Path treePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(iconTexturePath));
				SerializeField(s, nameof(iconSizeInTexture));
				SerializeField(s, nameof(deathBubbleColor));
			} else {
				SerializeField(s, nameof(iconTexturePath));
				SerializeField(s, nameof(iconSizeInTexture));
				SerializeField(s, nameof(deathBubbleColor));
				SerializeField(s, nameof(loadingPath));
				SerializeField(s, nameof(treePath));
			}
		}
		public override uint? ClassCRC => 0x6A26067F;
	}
}

