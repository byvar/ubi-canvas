namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ActivationSequenceTriggerComponent_Template : ActorComponent_Template {
		public Path fx;
		public StringID fxBone;
		public int canActivate;
		public int npc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fx = s.SerializeObject<Path>(fx, name: "fx");
			fxBone = s.SerializeObject<StringID>(fxBone, name: "fxBone");
			canActivate = s.Serialize<int>(canActivate, name: "canActivate");
			npc = s.Serialize<int>(npc, name: "npc");
		}
		public override uint? ClassCRC => 0xF8367EB7;
	}
}

