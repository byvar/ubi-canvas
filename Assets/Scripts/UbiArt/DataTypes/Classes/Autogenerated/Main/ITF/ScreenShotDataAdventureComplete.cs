namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class ScreenShotDataAdventureComplete : online.OpenGraphObject {
		public uint cur_adv_seq;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			cur_adv_seq = s.Serialize<uint>(cur_adv_seq, name: "cur_adv_seq");
		}
		public override uint? ClassCRC => 0xFEDB8477;
	}
}

