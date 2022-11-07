namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_CountdownComponent_Template : ActorComponent_Template {
		public Generic<Event> onFinishEvent;
		public CListO<StringID> fxControls;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			onFinishEvent = s.SerializeObject<Generic<Event>>(onFinishEvent, name: "onFinishEvent");
			fxControls = s.SerializeObject<CListO<StringID>>(fxControls, name: "fxControls");
		}
		public override uint? ClassCRC => 0x3BE6C699;
	}
}

