using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class MusicPartSet_Template : CSerializable {
		[Serialize("parts")] public CList<MusicPart_Template> parts;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(parts));
		}
	}
}