using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_LandOfTheDeadTeleportComponent_Template : CSerializable {
		public StringID mapTag;
		public StringID appearAnim;
		public StringID idleAnim;
		public Placeholder shape;
		public Vec2d shapeOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mapTag = s.SerializeObject<StringID>(mapTag, name: "mapTag");
			appearAnim = s.SerializeObject<StringID>(appearAnim, name: "appearAnim");
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
			shape = s.SerializeObject<Placeholder>(shape, name: "shape");
			shapeOffset = s.SerializeObject<Vec2d>(shapeOffset, name: "shapeOffset");
		}
		public override uint? ClassCRC => 0x272D18EF;
	}
}

