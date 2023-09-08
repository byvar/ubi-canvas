namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class MaskResolverComponent_Template : ActorComponent_Template {
		public bool resolveFrontLightBuffer = true;
		public bool resolveFrontLightBufferInverted;
		public bool resolveBackLightBuffer = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				resolveFrontLightBuffer = s.Serialize<bool>(resolveFrontLightBuffer, name: "resolveFrontLightBuffer");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					resolveFrontLightBufferInverted = s.Serialize<bool>(resolveFrontLightBufferInverted, name: "resolveFrontLightBufferInverted");
				}
				resolveBackLightBuffer = s.Serialize<bool>(resolveBackLightBuffer, name: "resolveBackLightBuffer");
			} else {
				resolveFrontLightBuffer = s.Serialize<bool>(resolveFrontLightBuffer, name: "resolveFrontLightBuffer");
				resolveFrontLightBufferInverted = s.Serialize<bool>(resolveFrontLightBufferInverted, name: "resolveFrontLightBufferInverted");
				resolveBackLightBuffer = s.Serialize<bool>(resolveBackLightBuffer, name: "resolveBackLightBuffer");
			}
		}
		public override uint? ClassCRC => 0x8B4B2DF2;
	}
}

