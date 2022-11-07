namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_25_sub_958920 : CSerializable {
		public SoundGUID RTPC;
		public bool stopOnDeactivate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			RTPC = s.SerializeObject<SoundGUID>(RTPC, name: "RTPC");
			stopOnDeactivate = s.Serialize<bool>(stopOnDeactivate, name: "stopOnDeactivate", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0xCC0BBF1B;
	}
}

