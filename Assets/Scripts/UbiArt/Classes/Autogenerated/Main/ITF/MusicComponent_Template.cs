using UnityEngine;

namespace UbiArt.ITF {
	public partial class MusicComponent_Template : ActorComponent_Template {
		[Serialize("musicPartSet")] public Placeholder musicPartSet;
		[Serialize("musicTree"   )] public Placeholder musicTree;
		[Serialize("inputs"      )] public Placeholder inputs;
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

