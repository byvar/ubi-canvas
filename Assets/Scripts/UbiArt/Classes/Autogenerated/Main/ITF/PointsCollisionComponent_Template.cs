using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class PointsCollisionComponent_Template : ActorComponent_Template {
		[Serialize("polylines")] public CList<PolylineData> polylines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(polylines));
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class PolylineData : CSerializable {
			[Serialize("CArray<Vector2>__0")] public CArray<Vector2> CArray_Vector2__0;
			[Serialize("Path__1"           )] public Path Path__1;
			[Serialize("StringID__2"       )] public StringID StringID__2;
			[Serialize("int__3"            )] public int int__3;
			[Serialize("int__4"            )] public int int__4;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(CArray_Vector2__0));
				SerializeField(s, nameof(Path__1));
				SerializeField(s, nameof(StringID__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(int__4));
			}
		}
		public override uint? ClassCRC => 0x421AC687;
	}
}

