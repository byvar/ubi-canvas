using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_212_sub_A71600 : CSerializable {
		[Serialize("digByDefault"   )] public Placeholder digByDefault;
		[Serialize("digByDefault"   )] public bool digByDefault;
		[Serialize("digOffset"      )] public Vector2 digOffset;
		[Serialize("digScale"       )] public Vector2 digScale;
		[Serialize("useActorAngle"  )] public Placeholder useActorAngle;
		[Serialize("useActorAngle"  )] public bool useActorAngle;
		[Serialize("sendEventToSelf")] public Placeholder sendEventToSelf;
		[Serialize("sendEventToSelf")] public bool sendEventToSelf;
		[Serialize("staticEnabled"  )] public bool staticEnabled;
		[Serialize("staticDuration" )] public float staticDuration;
		[Serialize("digShape"       )] public Placeholder digShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(digByDefault));
			SerializeField(s, nameof(digByDefault));
			SerializeField(s, nameof(digOffset));
			SerializeField(s, nameof(digScale));
			SerializeField(s, nameof(useActorAngle));
			SerializeField(s, nameof(useActorAngle));
			SerializeField(s, nameof(sendEventToSelf));
			SerializeField(s, nameof(sendEventToSelf));
			SerializeField(s, nameof(staticEnabled));
			SerializeField(s, nameof(staticDuration));
			SerializeField(s, nameof(digShape));
		}
		public override uint? ClassCRC => 0x39406FA0;
	}
}

