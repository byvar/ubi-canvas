using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class LinkComponent : ActorComponent {
		[Serialize("Children"            )] public CList<ChildEntry> Children;
		[Serialize("ChildrenObjId"       )] public Placeholder ChildrenObjId;
		[Serialize("LinkedChildren"      )] public Placeholder LinkedChildren;
		[Serialize("CList<ChildEntry>__0")] public CList<ChildEntry> CList_ChildEntry__0;
		[Serialize("CList<ObjectPath>__1")] public CList<ObjectPath> CList_ObjectPath__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(CList_ChildEntry__0));
				}
				SerializeField(s, nameof(CList_ObjectPath__1));
			} else if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Children));
				}
				if (s.HasFlags(SerializeFlags.Flags6)) {
					SerializeField(s, nameof(ChildrenObjId));
					SerializeField(s, nameof(LinkedChildren));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Children));
				}
			}
		}
		public override uint? ClassCRC => 0x44376F1B;
	}
}

