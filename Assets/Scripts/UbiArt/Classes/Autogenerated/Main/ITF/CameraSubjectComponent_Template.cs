using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class CameraSubjectComponent_Template : ActorComponent_Template {
		[Serialize("boundingBoxMin")] public Vec2d boundingBoxMin;
		[Serialize("boundingBoxMax")] public Vec2d boundingBoxMax;
		[Serialize("offset"        )] public Vec2d offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(boundingBoxMin));
			SerializeField(s, nameof(boundingBoxMax));
			SerializeField(s, nameof(offset));
		}
		public override uint? ClassCRC => 0x5B4423A1;
	}
}

