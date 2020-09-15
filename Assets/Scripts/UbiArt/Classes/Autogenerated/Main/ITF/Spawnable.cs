using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Spawnable : CSerializable {
		public StringID StringID__0;
		public Path Path__1;
		public int int__2;
		public Vec3d Vector3__3;
		public Angle Angle__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
			int__2 = s.Serialize<int>(int__2, name: "int__2");
			Vector3__3 = s.SerializeObject<Vec3d>(Vector3__3, name: "Vector3__3");
			Angle__4 = s.SerializeObject<Angle>(Angle__4, name: "Angle__4");
		}
	}
}

