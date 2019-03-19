using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ChildLaunchComponent : ActorComponent {
		[Serialize("nextLaunchIndex")] public uint nextLaunchIndex;
		[Serialize("hintFxEnabled"  )] public int hintFxEnabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(nextLaunchIndex));
			}
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(hintFxEnabled));
			}
		}
		public override uint? ClassCRC => 0xD18C8678;
	}
}

