using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class MusicComponent_Template : ActorComponent_Template {
		[Serialize("musicPartSet")] public MusicPartSet_Template musicPartSet;
		[Serialize("musicTree"   )] public MusicTree_Template musicTree;
		[Serialize("inputs"      )] public CArray<InputDesc> inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(musicPartSet));
				SerializeField(s, nameof(musicTree));
				SerializeField(s, nameof(inputs));
			} else {
			}
		}
		public override uint? ClassCRC => 0xEE6355D8;
	}
}

