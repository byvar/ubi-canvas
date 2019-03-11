using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PaintBumperComponent : ActorComponent {
		[Serialize("HasBeenDRCified")] public bool HasBeenDRCified;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(HasBeenDRCified));
			}
		}
		public override uint? ClassCRC => 0xD6E104C6;
	}
}

