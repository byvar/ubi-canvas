using UnityEngine;

namespace UbiArt.ITF {
	public partial class SoundComponent : ActorComponent {
		[Serialize("soundList")] public CList<SoundDescriptor_Template> soundList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(soundList));
		}
		public override uint? ClassCRC => 0x7DD8643C;
	}
}

