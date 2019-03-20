using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventGroupAction : Event {
		[Serialize("groupIndex" )] public uint groupIndex;
		[Serialize("groupAction")] public StringID groupAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(groupIndex));
				SerializeField(s, nameof(groupAction));
			} else {
			}
		}
		public override uint? ClassCRC => 0xD61DD8DC;
	}
}

