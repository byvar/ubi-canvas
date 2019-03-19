using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL)]
	public partial class EventSetWwiseState : Event {
		[Serialize("WwiseStateGroupGUID")] public StringID WwiseStateGroupGUID;
		[Serialize("WwiseStateGUID"     )] public StringID WwiseStateGUID;
		[Serialize("sender"             )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(WwiseStateGroupGUID));
				SerializeField(s, nameof(WwiseStateGUID));
			} else {
				SerializeField(s, nameof(WwiseStateGroupGUID));
				SerializeField(s, nameof(WwiseStateGUID));
			}
		}
		public override uint? ClassCRC => 0xC7DCAC11;
	}
}

