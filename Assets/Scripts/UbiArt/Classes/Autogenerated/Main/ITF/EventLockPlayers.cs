using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventLockPlayers : Event {
		[Serialize("force"      )] public bool force;
		[Serialize("stopPlayers")] public bool stopPlayers;
		[Serialize("stopInputs" )] public bool stopInputs;
		[Serialize("forceRevive")] public bool forceRevive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(force));
			SerializeField(s, nameof(stopPlayers));
			SerializeField(s, nameof(stopInputs));
			SerializeField(s, nameof(forceRevive));
		}
		public override uint? ClassCRC => 0x156EA254;
	}
}

