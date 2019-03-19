using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_224_sub_A71600 : CSerializable {
		[Serialize("digByDefault"   )] public bool digByDefault;
		[Serialize("digOffset"      )] public Vector2 digOffset;
		[Serialize("digScale"       )] public Vector2 digScale;
		[Serialize("useActorAngle"  )] public bool useActorAngle;
		[Serialize("sendEventToSelf")] public bool sendEventToSelf;
		[Serialize("staticEnabled"  )] public int staticEnabled;
		[Serialize("staticDuration" )] public float staticDuration;
		[Serialize("digShape"       )] public Placeholder digShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(digByDefault), boolAsByte: true);
			SerializeField(s, nameof(digOffset));
			SerializeField(s, nameof(digScale));
			SerializeField(s, nameof(useActorAngle), boolAsByte: true);
			SerializeField(s, nameof(sendEventToSelf), boolAsByte: true);
			SerializeField(s, nameof(staticEnabled));
			SerializeField(s, nameof(staticDuration));
			SerializeField(s, nameof(digShape));
		}
		public override uint? ClassCRC => 0x39406FA0;
	}
}

