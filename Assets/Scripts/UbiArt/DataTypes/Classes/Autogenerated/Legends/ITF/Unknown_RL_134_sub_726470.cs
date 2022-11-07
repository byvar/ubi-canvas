namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_134_sub_726470 : CSerializable {
		public bool disableWindForce;
		public bool startWithHalo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				disableWindForce = s.Serialize<bool>(disableWindForce, name: "disableWindForce", options: CSerializerObject.Options.BoolAsByte);
				startWithHalo = s.Serialize<bool>(startWithHalo, name: "startWithHalo", options: CSerializerObject.Options.BoolAsByte);
			}
		}
		public override uint? ClassCRC => 0x389D417B;
	}
}

