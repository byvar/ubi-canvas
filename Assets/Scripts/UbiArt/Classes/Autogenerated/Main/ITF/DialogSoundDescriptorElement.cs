using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class DialogSoundDescriptorElement : CSerializable {
		[Serialize("Mood"           )] public uint Mood;
		[Serialize("SoundDescriptor")] public StringID SoundDescriptor;
		[Serialize("Repeat"         )] public float Repeat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Mood));
			SerializeField(s, nameof(SoundDescriptor));
			SerializeField(s, nameof(Repeat));
		}
	}
}

