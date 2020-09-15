using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class CollisionTexture : CSerializable {
		public uint build;
		public float offset;
		public Vec2d cornerIn;
		public Vec2d cornerOut;
		public bool cornerInCur;
		public bool cornerOutCur;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			build = s.Serialize<uint>(build, name: "build");
			offset = s.Serialize<float>(offset, name: "offset");
			cornerIn = s.SerializeObject<Vec2d>(cornerIn, name: "cornerIn");
			cornerOut = s.SerializeObject<Vec2d>(cornerOut, name: "cornerOut");
			if (s.HasFlags(SerializeFlags.Flags10)) {
				cornerInCur = s.Serialize<bool>(cornerInCur, name: "cornerInCur");
				cornerOutCur = s.Serialize<bool>(cornerOutCur, name: "cornerOutCur");
			}
		}
	}
}

