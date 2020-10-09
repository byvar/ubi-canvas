using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTActionStayIdle_Template : BTAction_Template {
		public StringID groundAnim;
		public StringID swimAnim;
		public StringID fallAnim;
		public float avoidanceRadius;
		public float maxTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
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

