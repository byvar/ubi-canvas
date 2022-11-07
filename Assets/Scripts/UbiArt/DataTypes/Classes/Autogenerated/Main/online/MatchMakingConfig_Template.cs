namespace UbiArt.online {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class MatchMakingConfig_Template : ITF.TemplateObj {
		public uint DefaultSessionType;
		public uint DefaultQuery;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DefaultSessionType = s.Serialize<uint>(DefaultSessionType, name: "DefaultSessionType");
			DefaultQuery = s.Serialize<uint>(DefaultQuery, name: "DefaultQuery");
		}
		public override uint? ClassCRC => 0x1873E7DF;
	}
}

