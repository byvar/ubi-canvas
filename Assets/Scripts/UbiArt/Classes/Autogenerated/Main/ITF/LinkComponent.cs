using UnityEngine;

namespace UbiArt.ITF {
	public partial class LinkComponent : ActorComponent {
		[Serialize("Children"      )] public CList<ChildEntry> Children;
		[Serialize("ChildrenObjId" )] public Placeholder ChildrenObjId;
		[Serialize("LinkedChildren")] public Placeholder LinkedChildren;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Children));
				}
				if (s.HasFlags(SerializeFlags.Flags6)) {
					SerializeField(s, nameof(ChildrenObjId));
					SerializeField(s, nameof(LinkedChildren));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Children));
				}
			}
		}
		public override uint? ClassCRC => 0x44376F1B;
	}
}

