namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class ActorPlugPlayableController_Template : ActorPlugBaseController_Template {
		public StringID unplugInputAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			unplugInputAction = s.SerializeObject<StringID>(unplugInputAction, name: "unplugInputAction");
		}
		public override uint? ClassCRC => 0xF961057F;
	}
}

