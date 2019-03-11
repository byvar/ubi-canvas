using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossPlantArenaComponent_Template : ActorComponent_Template {
		[Serialize("isMecha"  )] public bool isMecha;
		[Serialize("buboBones")] public CList<RO2_BossPlantArenaComponent_Template.BuboBone> buboBones;
		[Serialize("musics"   )] public Placeholder musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(isMecha));
				SerializeField(s, nameof(buboBones));
				SerializeField(s, nameof(musics));
			} else {
				SerializeField(s, nameof(isMecha));
				SerializeField(s, nameof(buboBones));
			}
		}
		public partial class BuboBone : CSerializable {
			[Serialize("bone")] public StringID bone;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(bone));
			}
		}
		public override uint? ClassCRC => 0xD8EEB546;
	}
}

