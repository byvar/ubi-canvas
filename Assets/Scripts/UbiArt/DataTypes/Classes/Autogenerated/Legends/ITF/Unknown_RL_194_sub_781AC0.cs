namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_194_sub_781AC0 : CSerializable {
		public Placeholder trappedShape;
		public StringID animOff;
		public StringID animTrapped;
		public StringID revealedFx;
		public StringID activatedFx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			trappedShape = s.SerializeObject<Placeholder>(trappedShape, name: "trappedShape");
			animOff = s.SerializeObject<StringID>(animOff, name: "animOff");
			animTrapped = s.SerializeObject<StringID>(animTrapped, name: "animTrapped");
			revealedFx = s.SerializeObject<StringID>(revealedFx, name: "revealedFx");
			activatedFx = s.SerializeObject<StringID>(activatedFx, name: "activatedFx");
		}
		public override uint? ClassCRC => 0x94721363;
	}
}

