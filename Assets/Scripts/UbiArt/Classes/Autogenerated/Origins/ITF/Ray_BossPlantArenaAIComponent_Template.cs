using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BossPlantArenaAIComponent_Template : AIComponent_Template {
		[Serialize("isMecha"  )] public bool isMecha;
		[Serialize("buboBones")] public Placeholder buboBones;
		[Serialize("musics"   )] public Placeholder musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isMecha));
			SerializeField(s, nameof(buboBones));
			SerializeField(s, nameof(musics));
		}
		public override uint? ClassCRC => 0xA03E6260;
	}
}

