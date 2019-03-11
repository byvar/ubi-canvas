using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventAIOrder : EventCameraShake {
		[Serialize("targetReachedRadius")] public float targetReachedRadius;
		[Serialize("playerDetectRadius" )] public float playerDetectRadius;
		[Serialize("orderType"          )] public ORDERTYPE orderType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(targetReachedRadius));
			SerializeField(s, nameof(playerDetectRadius));
			SerializeField(s, nameof(orderType));
		}
		public enum ORDERTYPE {
			[Serialize("ORDERTYPE_Unknown"       )] Unknown = 0,
			[Serialize("ORDERTYPE_WaitForPlayer" )] WaitForPlayer = 1,
			[Serialize("ORDERTYPE_WaitForTrigger")] WaitForTrigger = 2,
		}
		public override uint? ClassCRC => 0x3EE79EC4;
	}
}

