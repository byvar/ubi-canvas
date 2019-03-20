using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class EventLockPlayers : Event {
		[Serialize("force"         )] public bool force;
		[Serialize("stopPlayers"   )] public bool stopPlayers;
		[Serialize("stopInputs"    )] public bool stopInputs;
		[Serialize("forceRevive"   )] public bool forceRevive;
		[Serialize("lock"          )] public int _lock;
		[Serialize("applyToPlayers")] public int applyToPlayers;
		[Serialize("applyToInputs" )] public int applyToInputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(_lock));
				SerializeField(s, nameof(applyToPlayers));
				SerializeField(s, nameof(applyToInputs));
				SerializeField(s, nameof(forceRevive));
			} else {
				SerializeField(s, nameof(force));
				SerializeField(s, nameof(stopPlayers));
				SerializeField(s, nameof(stopInputs));
				SerializeField(s, nameof(forceRevive));
			}
		}
		public override uint? ClassCRC => 0x156EA254;
	}
}

