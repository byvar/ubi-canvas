using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RO | GameFlags.COL)]
	public partial class BTActionStayIdle_Template : BTAction_Template {
		[Serialize("groundAnim"     )] public StringID groundAnim;
		[Serialize("swimAnim"       )] public StringID swimAnim;
		[Serialize("fallAnim"       )] public StringID fallAnim;
		[Serialize("avoidanceRadius")] public float avoidanceRadius;
		[Serialize("maxTime"        )] public float maxTime;
		[Serialize("name"           )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(groundAnim));
				SerializeField(s, nameof(swimAnim));
				SerializeField(s, nameof(fallAnim));
				SerializeField(s, nameof(avoidanceRadius));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(groundAnim));
				SerializeField(s, nameof(swimAnim));
				SerializeField(s, nameof(fallAnim));
				SerializeField(s, nameof(avoidanceRadius));
				SerializeField(s, nameof(maxTime));
			} else {
				SerializeField(s, nameof(groundAnim));
				SerializeField(s, nameof(swimAnim));
				SerializeField(s, nameof(fallAnim));
				SerializeField(s, nameof(avoidanceRadius));
				SerializeField(s, nameof(maxTime));
			}
		}
		public override uint? ClassCRC => 0x8935097E;
	}
}

