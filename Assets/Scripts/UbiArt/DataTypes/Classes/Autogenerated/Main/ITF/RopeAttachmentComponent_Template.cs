namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class RopeAttachmentComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9CC26775;
	}
}

