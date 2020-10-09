using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossPlantArenaComponent_Template : ActorComponent_Template {
		public bool isMecha;
		public CListO<RO2_BossPlantArenaComponent_Template.BuboBone> buboBones;
		public Placeholder musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				isMecha = s.Serialize<bool>(isMecha, name: "isMecha");
				buboBones = s.SerializeObject<CListO<RO2_BossPlantArenaComponent_Template.BuboBone>>(buboBones, name: "buboBones");
				musics = s.SerializeObject<Placeholder>(musics, name: "musics");
			} else {
				isMecha = s.Serialize<bool>(isMecha, name: "isMecha");
				buboBones = s.SerializeObject<CListO<RO2_BossPlantArenaComponent_Template.BuboBone>>(buboBones, name: "buboBones");
			}
		}
		[Games(GameFlags.RA)]
		public partial class BuboBone : CSerializable {
			public StringID bone;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				bone = s.SerializeObject<StringID>(bone, name: "bone");
			}
		}
		public override uint? ClassCRC => 0xD8EEB546;
	}
}

