using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class PolylineData : CSerializable {
		public CArrayO<Vec2d> points;
		public Path gameMaterial;
		public StringID regionType;
		public bool loop;
		public bool movingPolyline;
		public Vec2d Vector2__0;
		public Path Path__1;
		public StringID StringID__2;
		public bool bool__3;
		public bool bool__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				Vector2__0 = s.SerializeObject<Vec2d>(Vector2__0, name: "Vector2__0");
				Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
				StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
				bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
				bool__4 = s.Serialize<bool>(bool__4, name: "bool__4");
			} else {
				points = s.SerializeObject<CArrayO<Vec2d>>(points, name: "points");
				points = s.SerializeObject<CArrayO<Vec2d>>(points, name: "points");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
				regionType = s.SerializeObject<StringID>(regionType, name: "regionType");
				loop = s.Serialize<bool>(loop, name: "loop");
				movingPolyline = s.Serialize<bool>(movingPolyline, name: "movingPolyline");
			}
		}
	}
}

