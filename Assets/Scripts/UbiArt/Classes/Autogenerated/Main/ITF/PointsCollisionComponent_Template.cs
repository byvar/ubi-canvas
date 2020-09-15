using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class PointsCollisionComponent_Template : ActorComponent_Template {
		public CList<PolylineData> polylines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				polylines = s.SerializeObject<CList<PolylineData>>(polylines, name: "polylines");
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class PolylineData : CSerializable {
			public CArray<Vec2d> CArray_Vector2__0;
			public Path Path__1;
			public StringID StringID__2;
			public int int__3;
			public int int__4;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				CArray_Vector2__0 = s.SerializeObject<CArray<Vec2d>>(CArray_Vector2__0, name: "CArray_Vector2__0");
				Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
				StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
				int__3 = s.Serialize<int>(int__3, name: "int__3");
				int__4 = s.Serialize<int>(int__4, name: "int__4");
			}
		}
		public override uint? ClassCRC => 0x421AC687;
	}
}

