namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class RewardTrigger_SumWithTimer : RewardTrigger_Sum {
		public float timeToGet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timeToGet = s.Serialize<float>(timeToGet, name: "timeToGet");
		}
		public override uint? ClassCRC => 0x850FAEDB;
	}
}

