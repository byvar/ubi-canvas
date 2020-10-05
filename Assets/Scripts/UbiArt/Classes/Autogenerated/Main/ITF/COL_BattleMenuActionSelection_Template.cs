using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleMenuActionSelection_Template : CSerializable {
		public Path baseActionsTexturePath;
		public Path buttonBackgroundTexturePath;
		public Placeholder baseActionsTexture;
		public Placeholder buttonBackgroundTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				baseActionsTexturePath = s.SerializeObject<Path>(baseActionsTexturePath, name: "baseActionsTexturePath");
				buttonBackgroundTexturePath = s.SerializeObject<Path>(buttonBackgroundTexturePath, name: "buttonBackgroundTexturePath");
			}
			baseActionsTexture = s.SerializeObject<Placeholder>(baseActionsTexture, name: "baseActionsTexture");
			buttonBackgroundTexture = s.SerializeObject<Placeholder>(buttonBackgroundTexture, name: "buttonBackgroundTexture");
		}
		public override uint? ClassCRC => 0x793D8966;
	}
}

