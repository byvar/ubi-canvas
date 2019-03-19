using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BossPlantArenaAIComponent_Template : AIComponent_Template {
		[Serialize("isMecha"  )] public int isMecha;
		[Serialize("buboBones")] public CList<Ray_BossPlantArenaAIComponent_Template.BuboBone> buboBones;
		[Serialize("musics"   )] public CList<EventPlayMusic> musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isMecha));
			SerializeField(s, nameof(buboBones));
			SerializeField(s, nameof(musics));
		}
		[Games(GameFlags.RFR | GameFlags.RO)]
		public partial class BuboBone : CSerializable {
			[Serialize("bone")] public StringID bone;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(bone));
			}
		}
		public override uint? ClassCRC => 0xA03E6260;
	}
}

