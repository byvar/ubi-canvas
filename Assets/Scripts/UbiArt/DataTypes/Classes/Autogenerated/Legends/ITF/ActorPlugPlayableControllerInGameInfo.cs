namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.RM)]
	public partial class ActorPlugPlayableControllerInGameInfo : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x68E2C8C1;
	}
}

