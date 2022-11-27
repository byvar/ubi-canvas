namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTActionStayIdle_Template : BTAction_Template {
		public StringID groundAnim;
		public StringID swimAnim;
		public StringID fallAnim;
		public float avoidanceRadius = 0.4f;
		public float maxTime = -1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				groundAnim = s.SerializeObject<StringID>(groundAnim, name: "groundAnim");
				swimAnim = s.SerializeObject<StringID>(swimAnim, name: "swimAnim");
				fallAnim = s.SerializeObject<StringID>(fallAnim, name: "fallAnim");
				avoidanceRadius = s.Serialize<float>(avoidanceRadius, name: "avoidanceRadius");
			} else {
				groundAnim = s.SerializeObject<StringID>(groundAnim, name: "groundAnim");
				swimAnim = s.SerializeObject<StringID>(swimAnim, name: "swimAnim");
				fallAnim = s.SerializeObject<StringID>(fallAnim, name: "fallAnim");
				avoidanceRadius = s.Serialize<float>(avoidanceRadius, name: "avoidanceRadius");
				maxTime = s.Serialize<float>(maxTime, name: "maxTime");
			}
		}
		public override uint? ClassCRC => 0x8935097E;
	}
}

