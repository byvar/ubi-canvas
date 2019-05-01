using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class LinkComponent : ActorComponent {
		[Serialize("Children"            )] public CList<ChildEntry> Children;
		[Serialize("ChildrenObjId"       )] public CList<ObjectId> ChildrenObjId;
		[Serialize("LinkedChildren"      )] public CList<ObjectPath> LinkedChildren;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Children));
				}
				if (!s.HasSerializerFlags(CSerializerObject.Flags.Flags0) && s.HasFlags(SerializeFlags.Flags6)) {
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

