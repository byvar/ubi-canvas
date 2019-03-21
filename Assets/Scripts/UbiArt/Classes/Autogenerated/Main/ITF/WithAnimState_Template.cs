using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class WithAnimState_Template : BasicState_Template {
		[Serialize("defaultAnim"        )] public StringID defaultAnim;
		[Serialize("endCheckByAnimEvent")] public bool endCheckByAnimEvent;
		[Serialize("endCheckByAnimEnd"  )] public bool endCheckByAnimEnd;
		[Serialize("restartAnimIfSame"  )] public bool restartAnimIfSame;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultAnim));
			SerializeField(s, nameof(endCheckByAnimEvent));
			SerializeField(s, nameof(endCheckByAnimEnd));
			SerializeField(s, nameof(restartAnimIfSame));
		}
		public override uint? ClassCRC => 0x3DFD8E0F;
	}
}

