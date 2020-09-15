using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlayerIDInfo : PlayerIDInfo {
		public Path iconTexturePath;
		public Vec2d iconSizeInTexture;
		public Path loadingPath;
		public Path treePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				iconTexturePath = s.SerializeObject<Path>(iconTexturePath, name: "iconTexturePath");
				iconSizeInTexture = s.SerializeObject<Vec2d>(iconSizeInTexture, name: "iconSizeInTexture");
				deathBubbleColor = s.SerializeObject<Color>(deathBubbleColor, name: "deathBubbleColor");
			} else {
				iconTexturePath = s.SerializeObject<Path>(iconTexturePath, name: "iconTexturePath");
				iconSizeInTexture = s.SerializeObject<Vec2d>(iconSizeInTexture, name: "iconSizeInTexture");
				deathBubbleColor = s.SerializeObject<Color>(deathBubbleColor, name: "deathBubbleColor");
				loadingPath = s.SerializeObject<Path>(loadingPath, name: "loadingPath");
				treePath = s.SerializeObject<Path>(treePath, name: "treePath");
			}
		}
		public override uint? ClassCRC => 0x6A26067F;
	}
}

