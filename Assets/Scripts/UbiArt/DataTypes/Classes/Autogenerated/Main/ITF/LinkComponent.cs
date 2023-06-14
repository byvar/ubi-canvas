namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class LinkComponent : ActorComponent {
		public CListO<ChildEntry> Children;
		public CListO<ObjectId> ChildrenObjId;
		public CListO<ObjectPath> LinkedChildren;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					Children = s.SerializeObject<CListO<ChildEntry>>(Children, name: "Children");
				}
				if (!s.HasProperty(CSerializerObject.SerializerProperty.Binary) && s.HasFlags(SerializeFlags.Flags6)) {
					ChildrenObjId = s.SerializeObject<CListO<ObjectId>>(ChildrenObjId, name: "ChildrenObjId");
					LinkedChildren = s.SerializeObject<CListO<ObjectPath>>(LinkedChildren, name: "LinkedChildren");
				}
			} else if (s.Settings.game == Settings.Game.COL) {
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					Children = s.SerializeObject<CListO<ChildEntry>>(Children, name: "Children");
				}
			}
		}
		public override uint? ClassCRC => 0x44376F1B;
	}
}

