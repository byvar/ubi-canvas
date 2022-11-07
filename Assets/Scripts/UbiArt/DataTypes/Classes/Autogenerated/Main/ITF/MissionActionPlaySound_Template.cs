namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionPlaySound_Template : CSerializable {
		public StringID soundGUID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			soundGUID = s.SerializeObject<StringID>(soundGUID, name: "soundGUID");
		}
		public override uint? ClassCRC => 0x5E8E32C6;
	}
}

