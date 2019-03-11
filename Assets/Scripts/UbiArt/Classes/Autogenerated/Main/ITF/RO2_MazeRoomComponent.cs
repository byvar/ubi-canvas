using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MazeRoomComponent : ActorComponent {
		[Serialize("startOnInstance")] public bool startOnInstance;
		[Serialize("startOn"        )] public bool startOn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(startOnInstance));
			}
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOn));
			}
		}
		public override uint? ClassCRC => 0xED53265B;
	}
}

