using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class LinkComponent : ActorComponent {
		public CListO<ChildEntry> Children;
		public CListO<ObjectId> ChildrenObjId;
		public CListO<ObjectPath> LinkedChildren;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					Children = s.SerializeObject<CListO<ChildEntry>>(Children, name: "Children");
				}
				if (!s.HasSerializerFlags(CSerializerObject.Flags.Flags0) && s.HasFlags(SerializeFlags.Flags6)) {
					ChildrenObjId = s.SerializeObject<CListO<ObjectId>>(ChildrenObjId, name: "ChildrenObjId");
					LinkedChildren = s.SerializeObject<CListO<ObjectPath>>(LinkedChildren, name: "LinkedChildren");
				}
			} else if (Settings.s.game == Settings.Game.COL) {
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					Children = s.SerializeObject<CListO<ChildEntry>>(Children, name: "Children");
				}
			}
		}
		public override uint? ClassCRC => 0x44376F1B;
	}
}

