using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PhysShapePolygon : PhysShape {
		[Serialize("Points"   )] public CList<Vector2> Points;
		[Serialize("normals"  )] public CList<Vector2> normals;
		[Serialize("edge"     )] public CList<Vector2> edge;
		[Serialize("distances")] public CArray<float> distances;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (this is PhysShapeBox) return;
				SerializeField(s, nameof(Points));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				if (Settings.s.isCatchThemAll) return;
				SerializeField(s, nameof(Points));
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(normals));
					SerializeField(s, nameof(edge));
					SerializeField(s, nameof(distances));
				}
			} else {
				SerializeField(s, nameof(Points));
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(normals));
					SerializeField(s, nameof(edge));
					SerializeField(s, nameof(distances));
					SerializeField(s, nameof(distances));
				}
			}
		}
		public override uint? ClassCRC => 0xC262C210;
	}
}

