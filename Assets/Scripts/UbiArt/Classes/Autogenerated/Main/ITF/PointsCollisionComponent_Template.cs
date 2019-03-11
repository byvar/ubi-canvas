using UnityEngine;

namespace UbiArt.ITF {
	public partial class PointsCollisionComponent_Template : ActorComponent_Template {
		[Serialize("polylines")] public CList<PolylineData> polylines;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(polylines));
		}
		public override uint? ClassCRC => 0x421AC687;
	}
}

