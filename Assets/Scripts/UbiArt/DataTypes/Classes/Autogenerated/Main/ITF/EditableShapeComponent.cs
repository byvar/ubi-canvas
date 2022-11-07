namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EditableShapeComponent : ActorComponent {
		public EditableShape ZONE;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ZONE = s.SerializeObject<EditableShape>(ZONE, name: "ZONE");
		}
		public override uint? ClassCRC => 0xB1C11137;
	}
}

