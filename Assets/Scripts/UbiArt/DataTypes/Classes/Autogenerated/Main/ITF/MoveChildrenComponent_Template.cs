namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class MoveChildrenComponent_Template : ActorComponent_Template {
		public bool isActive = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isActive = s.Serialize<bool>(isActive, name: "isActive");
		}
		public override uint? ClassCRC => 0x0F928FB7;
	}
}

