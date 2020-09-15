using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class DigShapeComponent_Template : ActorComponent_Template {
		public bool digByDefault;
		public Vec2d digOffset;
		public Vec2d digScale;
		public bool useActorAngle;
		public bool sendEventToSelf;
		public bool staticEnabled;
		public float staticDuration;
		public Generic<PhysShape> digShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			digByDefault = s.Serialize<bool>(digByDefault, name: "digByDefault");
			digOffset = s.SerializeObject<Vec2d>(digOffset, name: "digOffset");
			digScale = s.SerializeObject<Vec2d>(digScale, name: "digScale");
			useActorAngle = s.Serialize<bool>(useActorAngle, name: "useActorAngle");
			sendEventToSelf = s.Serialize<bool>(sendEventToSelf, name: "sendEventToSelf");
			staticEnabled = s.Serialize<bool>(staticEnabled, name: "staticEnabled");
			staticDuration = s.Serialize<float>(staticDuration, name: "staticDuration");
			digShape = s.SerializeObject<Generic<PhysShape>>(digShape, name: "digShape");
		}
		public override uint? ClassCRC => 0x863D1F75;
	}
}

