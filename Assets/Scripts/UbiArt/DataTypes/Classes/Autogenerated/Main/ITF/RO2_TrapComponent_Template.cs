namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TrapComponent_Template : ActorComponent_Template {
		public StringID animOff;
		public StringID animTrapped;
		public StringID activatedFx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animOff = s.SerializeObject<StringID>(animOff, name: "animOff");
			animTrapped = s.SerializeObject<StringID>(animTrapped, name: "animTrapped");
			activatedFx = s.SerializeObject<StringID>(activatedFx, name: "activatedFx");
		}
		public override uint? ClassCRC => 0x2B10AC82;
	}
}

