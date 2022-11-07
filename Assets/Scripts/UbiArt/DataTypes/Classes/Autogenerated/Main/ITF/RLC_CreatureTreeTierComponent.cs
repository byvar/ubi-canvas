namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_CreatureTreeTierComponent : ActorComponent {
		public bool isTrunk;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isTrunk = s.Serialize<bool>(isTrunk, name: "isTrunk");
		}
		public override uint? ClassCRC => 0x23EA5FC6;
	}
}

