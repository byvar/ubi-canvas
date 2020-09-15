using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class DigShapeComponent_Template : ActorComponent_Template {
		[Serialize("digByDefault"   )] public bool digByDefault;
		[Serialize("digOffset"      )] public Vec2d digOffset;
		[Serialize("digScale"       )] public Vec2d digScale;
		[Serialize("useActorAngle"  )] public bool useActorAngle;
		[Serialize("sendEventToSelf")] public bool sendEventToSelf;
		[Serialize("staticEnabled"  )] public bool staticEnabled;
		[Serialize("staticDuration" )] public float staticDuration;
		[Serialize("digShape"       )] public Generic<PhysShape> digShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(digByDefault));
			SerializeField(s, nameof(digOffset));
			SerializeField(s, nameof(digScale));
			SerializeField(s, nameof(useActorAngle));
			SerializeField(s, nameof(sendEventToSelf));
			SerializeField(s, nameof(staticEnabled));
			SerializeField(s, nameof(staticDuration));
			SerializeField(s, nameof(digShape));
		}
		public override uint? ClassCRC => 0x863D1F75;
	}
}

