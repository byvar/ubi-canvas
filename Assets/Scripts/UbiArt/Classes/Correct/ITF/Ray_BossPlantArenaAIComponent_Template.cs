using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BossPlantArenaAIComponent_Template : AIComponent_Template {
		public int isMecha;
		public CListO<Ray_BossPlantArenaAIComponent_Template.BuboBone> buboBones;
		public CListO<EventPlayMusic> musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isMecha = s.Serialize<int>(isMecha, name: "isMecha");
			buboBones = s.SerializeObject<CListO<Ray_BossPlantArenaAIComponent_Template.BuboBone>>(buboBones, name: "buboBones");
			musics = s.SerializeObject<CListO<EventPlayMusic>>(musics, name: "musics");
		}
		[Games(GameFlags.RO | GameFlags.RFR)]
		public partial class BuboBone : CSerializable {
			public StringID bone;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				bone = s.SerializeObject<StringID>(bone, name: "bone");
			}
		}
		public override uint? ClassCRC => 0xA03E6260;
	}
}

