using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class WithAnimState_Template : BasicState_Template {
		[Serialize("defaultAnim"        )] public StringID defaultAnim;
		[Serialize("endCheckByAnimEvent")] public bool endCheckByAnimEvent;
		[Serialize("endCheckByAnimEnd"  )] public bool endCheckByAnimEnd;
		[Serialize("restartAnimIfSame"  )] public bool restartAnimIfSame;
		[Serialize("stateName"          )] public StringID stateName;
		[Serialize("defaultNextState"   )] public StringID defaultNextState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(stateName));
				SerializeField(s, nameof(defaultNextState));
				SerializeField(s, nameof(defaultAnim));
				SerializeField(s, nameof(endCheckByAnimEvent));
				SerializeField(s, nameof(endCheckByAnimEnd));
				SerializeField(s, nameof(restartAnimIfSame));
			} else {
				SerializeField(s, nameof(defaultAnim));
				SerializeField(s, nameof(endCheckByAnimEvent));
				SerializeField(s, nameof(endCheckByAnimEnd));
				SerializeField(s, nameof(restartAnimIfSame));
			}
		}
		public override uint? ClassCRC => 0x3DFD8E0F;
	}
}

