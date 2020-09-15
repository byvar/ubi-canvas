using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class HomeTreeGpeComponent : ActorComponent {
		public bool isDebugActor;
		public float appearCursor;
		public bool useComponent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				isDebugActor = s.Serialize<bool>(isDebugActor, name: "isDebugActor");
				appearCursor = s.Serialize<float>(appearCursor, name: "appearCursor");
				useComponent = s.Serialize<bool>(useComponent, name: "useComponent");
			}
		}
		public override uint? ClassCRC => 0xB3BCAF8B;
	}
}

