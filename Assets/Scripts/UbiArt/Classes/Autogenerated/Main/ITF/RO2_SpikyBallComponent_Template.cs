using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SpikyBallComponent_Template : ActorComponent_Template {
		public CList<RO2_SpikyBallComponent_Template.BoneData> bones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bones = s.SerializeObject<CList<RO2_SpikyBallComponent_Template.BoneData>>(bones, name: "bones");
		}
		[Games(GameFlags.RA)]
		public partial class BoneData : CSerializable {
			public StringID boneName;
			public Vec2d offset;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
				offset = s.SerializeObject<Vec2d>(offset, name: "offset");
			}
		}
		public override uint? ClassCRC => 0x275E583D;
	}
}

