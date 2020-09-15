using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.VH)]
	public partial class AnimationAtlas : CSerializable {
		public CList<AnimationAtlas.Key> sequence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sequence = s.SerializeObject<CList<AnimationAtlas.Key>>(sequence, name: "sequence");
		}
		[Games(GameFlags.RA | GameFlags.RL | GameFlags.RFR | GameFlags.VH)]
		public partial class Key : CSerializable {
			public uint atlas;
			public uint count;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				atlas = s.Serialize<uint>(atlas, name: "atlas");
				count = s.Serialize<uint>(count, name: "count");
			}
		}
	}
}

