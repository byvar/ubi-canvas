namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class PlayAnimOnTriggerComponent_Template : ActorComponent_Template {
		public StringID triggerOnAnim;
		public StringID triggerOffAnim;
		public bool playOnGeneric;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			triggerOnAnim = s.SerializeObject<StringID>(triggerOnAnim, name: "triggerOnAnim");
			triggerOffAnim = s.SerializeObject<StringID>(triggerOffAnim, name: "triggerOffAnim");
			playOnGeneric = s.Serialize<bool>(playOnGeneric, name: "playOnGeneric");
		}
		public override uint? ClassCRC => 0xA49D4BD7;
	}
}

