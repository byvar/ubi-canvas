using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimationAtlas : CSerializable {
		[Serialize("sequence")] public CList<AnimationAtlas.Key> sequence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sequence));
		}
		public partial class Key : CSerializable {
			[Serialize("atlas")] public uint atlas;
			[Serialize("count")] public uint count;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(atlas));
				SerializeField(s, nameof(count));
			}
		}
	}
}

