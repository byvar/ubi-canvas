using UnityEngine;

namespace UbiArt.ITF {
	public partial class MusicControllerComponent_Template : CSerializable {
		[Serialize("musicVolume"  )] public Placeholder musicVolume;
		[Serialize("metronomeType")] public uint metronomeType;
		[Serialize("inputs"       )] public Placeholder inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(musicVolume));
			SerializeField(s, nameof(metronomeType));
			SerializeField(s, nameof(inputs));
		}
		public override uint? ClassCRC => 0xFBE85770;
	}
}

