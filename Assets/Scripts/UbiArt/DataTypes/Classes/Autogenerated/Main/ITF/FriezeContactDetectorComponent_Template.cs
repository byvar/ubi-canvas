namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class FriezeContactDetectorComponent_Template : DetectorComponent_Template {
		public uint factionToDetect = uint.MaxValue;
		public bool allowDeadActors;
		public bool detectHang = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factionToDetect = s.Serialize<uint>(factionToDetect, name: "factionToDetect");
			allowDeadActors = s.Serialize<bool>(allowDeadActors, name: "allowDeadActors");
			detectHang = s.Serialize<bool>(detectHang, name: "detectHang");
		}
		public override uint? ClassCRC => 0xF0860387;
	}
}

