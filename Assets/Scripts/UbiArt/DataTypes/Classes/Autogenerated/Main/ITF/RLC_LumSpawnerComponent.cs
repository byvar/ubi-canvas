namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_LumSpawnerComponent : ActorComponent {
		public uint nbLums;
		public bool isRed;
		public bool triggerOnce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nbLums = s.Serialize<uint>(nbLums, name: "nbLums");
			isRed = s.Serialize<bool>(isRed, name: "isRed");
			triggerOnce = s.Serialize<bool>(triggerOnce, name: "triggerOnce");
		}
		public override uint? ClassCRC => 0x43CBBD0B;
	}
}

