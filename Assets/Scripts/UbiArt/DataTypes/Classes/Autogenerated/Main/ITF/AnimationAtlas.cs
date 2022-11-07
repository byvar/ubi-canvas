namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class AnimationAtlas : CSerializable {
		public CListO<AnimationAtlas.Key> sequence;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sequence = s.SerializeObject<CListO<AnimationAtlas.Key>>(sequence, name: "sequence");
		}
		[Games(GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.RA)]
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

