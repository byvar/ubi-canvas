namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class BTAIComponent : EntityComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEBC372C1;
	}
}

