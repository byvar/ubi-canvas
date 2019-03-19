using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleMenuActionSelection_Template : CSerializable {
		[Serialize("baseActionsTexturePath"     )] public Path baseActionsTexturePath;
		[Serialize("buttonBackgroundTexturePath")] public Path buttonBackgroundTexturePath;
		[Serialize("baseActionsTexture"         )] public Placeholder baseActionsTexture;
		[Serialize("buttonBackgroundTexture"    )] public Placeholder buttonBackgroundTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(baseActionsTexturePath));
				SerializeField(s, nameof(buttonBackgroundTexturePath));
			}
			SerializeField(s, nameof(baseActionsTexture));
			SerializeField(s, nameof(buttonBackgroundTexture));
		}
		public override uint? ClassCRC => 0x96C4970A;
	}
}

