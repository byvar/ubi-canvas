using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_SubAnchor : CSerializable {
		public StringID name;
		public Vec3d pos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			pos = s.SerializeObject<Vec3d>(pos, name: "pos");
		}
	}
}

