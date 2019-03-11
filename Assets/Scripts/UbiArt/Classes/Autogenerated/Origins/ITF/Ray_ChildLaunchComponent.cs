using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ChildLaunchComponent : CSerializable {
		[Serialize("nextLaunchIndex")] public uint nextLaunchIndex;
		[Serialize("hintFxEnabled"  )] public bool hintFxEnabled;
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

