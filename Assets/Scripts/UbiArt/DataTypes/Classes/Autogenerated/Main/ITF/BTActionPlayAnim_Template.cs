namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTActionPlayAnim_Template : BTAction_Template {
		public StringID anim;
		public StringID restartOnFact;
		public bool retOnFinish = true;
		public float playTime = -1f;
		public bool useAnimationRootDelta;
		public bool disablePhys;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				anim = s.SerializeObject<StringID>(anim, name: "anim");
				restartOnFact = s.SerializeObject<StringID>(restartOnFact, name: "restartOnFact");
				retOnFinish = s.Serialize<bool>(retOnFinish, name: "retOnFinish");
			} else {
				anim = s.SerializeObject<StringID>(anim, name: "anim");
				restartOnFact = s.SerializeObject<StringID>(restartOnFact, name: "restartOnFact");
				retOnFinish = s.Serialize<bool>(retOnFinish, name: "retOnFinish");
				playTime = s.Serialize<float>(playTime, name: "playTime");
				useAnimationRootDelta = s.Serialize<bool>(useAnimationRootDelta, name: "useAnimationRootDelta");
				disablePhys = s.Serialize<bool>(disablePhys, name: "disablePhys");
			}
		}
		public override uint? ClassCRC => 0xAB33BDE8;
	}
}

