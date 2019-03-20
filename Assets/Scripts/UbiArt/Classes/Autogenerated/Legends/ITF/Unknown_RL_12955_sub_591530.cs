using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_12955_sub_591530 : CSerializable {
		[Serialize("file")] public Path file;
		[Serialize("volume")] public float volume;
		[Serialize("delay")] public float delay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(file));
			SerializeField(s, nameof(volume));
			SerializeField(s, nameof(delay));
		}
	}
}