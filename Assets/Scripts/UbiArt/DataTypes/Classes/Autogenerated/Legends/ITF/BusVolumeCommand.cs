namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class BusVolumeCommand : SoundCommand {
		public CListO<StringID> buslist;
		public Volume volume;
		public float time;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			buslist = s.SerializeObject<CListO<StringID>>(buslist, name: "buslist");
			volume = s.SerializeObject<Volume>(volume, name: "volume");
			time = s.Serialize<float>(time, name: "time");
		}
		public override uint? ClassCRC => 0x7ACD5ABF;
	}
}

