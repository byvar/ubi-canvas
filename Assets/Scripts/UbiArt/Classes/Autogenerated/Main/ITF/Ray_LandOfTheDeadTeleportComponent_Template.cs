using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_LandOfTheDeadTeleportComponent_Template : CSerializable {
		[Serialize("mapTag"     )] public StringID mapTag;
		[Serialize("appearAnim" )] public StringID appearAnim;
		[Serialize("idleAnim"   )] public StringID idleAnim;
		[Serialize("shape"      )] public Placeholder shape;
		[Serialize("shapeOffset")] public Vector2 shapeOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(mapTag));
			SerializeField(s, nameof(appearAnim));
			SerializeField(s, nameof(idleAnim));
			SerializeField(s, nameof(shape));
			SerializeField(s, nameof(shapeOffset));
		}
		public override uint? ClassCRC => 0x272D18EF;
	}
}

