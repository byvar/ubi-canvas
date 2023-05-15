namespace UbiArt.online {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class gameGlobalsContainer : CSerializable {
		public gameGlobalsData data;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			s.DoEncrypted(new uint[] { 0x2d8441f7, 0xe30865fc, 0xc9f5b992, 0x3bb7669 }, () => {
				data = s.SerializeObject<gameGlobalsData>(data, name: "data");
			}, "data");
		}
		public override uint? ClassCRC => 0x6D26004A;
	}
}

