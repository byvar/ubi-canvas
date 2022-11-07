namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_EditableShapeComponent : ActorComponent {
		public EditableShape ZONE;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ZONE = s.SerializeObject<EditableShape>(ZONE, name: "ZONE");
		}
		public override uint? ClassCRC => 0x4F705DE1;
	}
}

