namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionSetCurrentObjective : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9B09C835;
	}
}

