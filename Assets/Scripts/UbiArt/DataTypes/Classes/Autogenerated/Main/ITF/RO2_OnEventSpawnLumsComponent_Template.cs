namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_OnEventSpawnLumsComponent_Template : ActorComponent_Template {
		public CListO<Generic<Event>> listenEvents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			listenEvents = s.SerializeObject<CListO<Generic<Event>>>(listenEvents, name: "listenEvents");
		}
		public override uint? ClassCRC => 0x0961F62F;
	}
}

