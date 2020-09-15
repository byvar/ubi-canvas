using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BossPlantArenaAIComponent_Template : AIComponent_Template {
		public int isMecha;
		public CList<Ray_BossPlantArenaAIComponent_Template.BuboBone> buboBones;
		public CList<EventPlayMusic> musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isMecha = s.Serialize<int>(isMecha, name: "isMecha");
			buboBones = s.SerializeObject<CList<Ray_BossPlantArenaAIComponent_Template.BuboBone>>(buboBones, name: "buboBones");
			musics = s.SerializeObject<CList<EventPlayMusic>>(musics, name: "musics");
		}
		[Games(GameFlags.RFR | GameFlags.RO)]
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

