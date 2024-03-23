namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0681ABED;
	}
}

