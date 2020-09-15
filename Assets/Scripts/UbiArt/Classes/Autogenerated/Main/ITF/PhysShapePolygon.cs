using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PhysShapePolygon : PhysShape {
		public CList<Vec2d> Points;
		public CList<Vec2d> normals;
		public CList<Vec2d> edge;
		public CArray<float> distances;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (this is PhysShapeBox) return;
				Points = s.SerializeObject<CList<Vec2d>>(Points, name: "Points");
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				if (Settings.s.isCatchThemAll) return;
				Points = s.SerializeObject<CList<Vec2d>>(Points, name: "Points");
				if (s.HasFlags(SerializeFlags.Flags10)) {
					normals = s.SerializeObject<CList<Vec2d>>(normals, name: "normals");
					edge = s.SerializeObject<CList<Vec2d>>(edge, name: "edge");
					distances = s.SerializeObject<CArray<float>>(distances, name: "distances");
				}
			} else {
				Points = s.SerializeObject<CList<Vec2d>>(Points, name: "Points");
				if (s.HasFlags(SerializeFlags.Flags10)) {
					normals = s.SerializeObject<CList<Vec2d>>(normals, name: "normals");
					edge = s.SerializeObject<CList<Vec2d>>(edge, name: "edge");
					distances = s.SerializeObject<CArray<float>>(distances, name: "distances");
					distances = s.SerializeObject<CArray<float>>(distances, name: "distances");
				}
			}
		}
		public override uint? ClassCRC => 0xC262C210;
	}
}

