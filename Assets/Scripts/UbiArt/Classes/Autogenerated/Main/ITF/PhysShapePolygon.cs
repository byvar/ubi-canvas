using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhysShapePolygon : PhysShape {
		[Serialize("Points"   )] public CList<Vector2> Points;
		[Serialize("normals"  )] public CList<Vector2> normals;
		[Serialize("edge"     )] public CList<Vector2> edge;
		[Serialize("distances")] public CArray<float> distances;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(Points));
			} else {
				SerializeField(s, nameof(Points));
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(normals));
					SerializeField(s, nameof(edge));
					SerializeField(s, nameof(distances));
				}
			}
		}
		public override uint? ClassCRC => 0xC262C210;
	}
}

