using UnityEngine;

namespace UbiArt.ITF {
	public partial class HomeTreeGpeComponent : ActorComponent {
		[Serialize("isDebugActor")] public bool isDebugActor;
		[Serialize("appearCursor")] public float appearCursor;
		[Serialize("useComponent")] public bool useComponent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(isDebugActor));
				SerializeField(s, nameof(appearCursor));
				SerializeField(s, nameof(useComponent));
			}
		}
		public override uint? ClassCRC => 0xB3BCAF8B;
	}
}

